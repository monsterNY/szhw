﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DapperContext.Const;
using Model.Common.ConfigModels;
using Model.Common.Models;
using Model.Vlxm.Entity;
using Model.Vlxm.Tools;
using NLog;

namespace DapperContext
{
  public class DapperTools
  {
    public static ILogger Logger = LogManager.GetCurrentClassLogger();

    #region common method

    protected static string GetWhereSql(IEnumerable<string> whereEnumerable)
    {
      var whereSql = string.Empty;
      if (whereEnumerable != null && whereEnumerable.Any())
        whereSql = $"{SqlCharConst.WHERE} {string.Join($"\n{SqlCharConst.AND} ", whereEnumerable)}";
      return whereSql;
    }

    #endregion

    #region Update

    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="conn"></param>
    /// <param name="tableName"></param>
    /// <param name="whereList"></param>
    /// <param name="param"></param>
    /// <returns></returns>
    public static async Task<int> Edit(IDbConnection conn, string tableName,
      IEnumerable<string> whereList, object param)
    {
      var whereSql = GetWhereSql(whereList);

      return await Edit(conn, tableName, whereSql, param);

    }

    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="conn"></param>
    /// <param name="tableName"></param>
    /// <param name="whereSql"></param>
    /// <param name="param"></param>
    /// <returns></returns>
    public static async Task<int> Edit(IDbConnection conn, string tableName,
      string whereSql, object param)
    {
      var sql = $@"
{SqlCharConst.UPDATE} tableName
{SqlCharConst.SET} {string.Join(",", param.GetType().GetProperties().Select(u => $"{u.Name} = @{u.Name}"))}
{whereSql}
";

      Logger.Debug(sql);

      var result = await conn.ExecuteAsync(sql, param);

      return result;

    }

    #endregion

    /// <summary>
    /// 
    /// </summary>
    /// <param name="conn"></param>
    /// <param name="tableName"></param>
    /// <param name="whereArr"></param>
    /// <param name="param"></param>
    /// <returns></returns>
    public static async Task<bool> IsExists(IDbConnection conn, string tableName,
      List<string> whereArr, object param = null)
    {
      var whereSql = GetWhereSql(whereArr);

      var sql = $@"{SqlCharConst.SELECT} {SqlCharConst.EXISTS} (
{SqlCharConst.SELECT} 0 
{SqlCharConst.FROM} {tableName}
{whereSql}
)";

      Logger.Debug($"{nameof(GetItem)}:{sql}");

      var isExists = await conn.ExecuteScalarAsync<bool>(sql, param);

      return isExists;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="conn"></param>
    /// <param name="tableName"></param>
    /// <param name="whereArr"></param>
    /// <param name="param"></param>
    /// <returns></returns>
    public static async Task<T> GetItem<T>(IDbConnection conn, string tableName,
      List<string> whereArr, object param = null) where T : BaseModel
    {
      var whereSql = string.Empty;
      if (whereArr != null && whereArr.Count > 0)
        whereSql = $"{SqlCharConst.WHERE} {string.Join($"\n{SqlCharConst.AND} ", whereArr)}";

      return await GetItem<T>(conn, tableName, whereSql, param);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="conn"></param>
    /// <param name="tableName"></param>
    /// <param name="whereSql"></param>
    /// <param name="param"></param>
    /// <returns></returns>
    public static async Task<T> GetItem<T>(IDbConnection conn, string tableName,
      string whereSql, object param = null) where T : BaseModel
    {
      var sql = $@"
{SqlCharConst.SELECT} {string.Join(",", EntityTools.GetFields<T>())}
{SqlCharConst.FROM} {EntityTools.GetTableName<T>()}
{whereSql}";

      Logger.Debug($"{nameof(GetItem)}:{sql}");

      return await conn.QueryFirstOrDefaultAsync<T>(sql, param);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="pageNo"></param>
    /// <param name="pageSize"></param>
    /// <param name="conn"></param>
    /// <param name="whereArr"></param>
    /// <param name="loadNow"></param>
    /// <returns></returns>
    public static async Task<PageModel<IEnumerable<T>>> GetPageList<T>(int pageNo, int pageSize, IDbConnection conn,
      List<string> whereArr, bool loadNow = true) where T : BaseModel
    {
      var whereSql = string.Empty;
      if (whereArr != null && whereArr.Count > 0)
        whereSql = $"{SqlCharConst.WHERE} {string.Join($"\n{SqlCharConst.AND}", whereArr)}";

      return await GetPageList<T>(pageNo, pageSize, conn, whereSql, loadNow);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="pageNo"></param>
    /// <param name="pageSize"></param>
    /// <param name="conn"></param>
    /// <param name="whereSql"></param>
    /// <param name="loadNow"></param>
    /// <returns></returns>
    public static async Task<PageModel<IEnumerable<T>>> GetPageList<T>(int pageNo, int pageSize, IDbConnection conn,
      string whereSql, bool loadNow = true) where T : BaseModel
    {
      var selectCountSql = $@"
{SqlCharConst.SELECT} {SqlCharConst.COUNT}(1) 
{SqlCharConst.FROM} {EntityTools.GetTableName<T>()}
{whereSql}
";

      var count = await conn.QueryFirstAsync<int>(selectCountSql);

      Logger.Debug($"{nameof(GetPageList)}:{selectCountSql}");

      var resultPage = new PageModel<IEnumerable<T>>()
      {
        Count = count,
        PageNo = pageNo,
        PageSize = pageSize
      };

      if ((pageNo - 1) * pageSize <= count)
      {
        var enumerable = await conn.QueryAsync<T>($@"
{SqlCharConst.SELECT} {string.Join(",", EntityTools.GetFields<T>())}
{SqlCharConst.FROM} {EntityTools.GetTableName<T>()}
{whereSql}

{SqlCharConst.ORDERBY} {EntityTools.GetField<T>(nameof(BaseModel.Id))} {SqlCharConst.DESC}

{SqlCharConst.LIMIT} {(pageNo - 1) * pageSize},{pageSize}

");

        resultPage.Result = enumerable;

        if (loadNow) resultPage.Result = resultPage.Result.ToList();
      }

      return resultPage;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="conn"></param>
    /// <param name="tableName"></param>
    /// <param name="param"></param>
    /// <returns></returns>
    public static async Task<int> CreateItem<T>(IDbConnection conn, string tableName, T param)
    {
      var sql = $@"
{SqlCharConst.INSERT} {SqlCharConst.INTO} {tableName}
(
  {string.Join(",", EntityTools.GetFields<T>())}
)
{SqlCharConst.VALUES} 
(
  {string.Join(",", EntityTools.GetFields<T>("@"))}
)
";

      Logger.Debug($"{nameof(CreateItem)}:{sql}");

      var result = await conn.ExecuteAsync(sql, param);

      return result;
    }
  }
}