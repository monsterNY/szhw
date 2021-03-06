﻿using System.Threading.Tasks;
using Api.Manage.Assist.Req;
using Api.Manage.Assist.Entity;
using Api.Manage.Assist.Extension;
using Api.Manage.Assist.Param;
using Api.Manage.CusInterface;
using DapperContext;
using Microsoft.AspNetCore.Http;
using Model.Common.ConfigModels;
using Model.Vlxm.Entity;
using Model.Vlxm.Tools;

namespace Api.Manage.CusInherit.Article
{
  public class CreateArticleAuthService : IAuthDeal
  {
    public async Task<ResultModel> Run(AcceptParam acceptParam, AppSetting appSetting, HttpContext context,long userId)
    {
      var req = acceptParam.AnalyzeParam<CreateArticleReq>();

      if (req == null)
      {
        return ResultModel.GetNullErrorModel(string.Empty);
      }

      string msg;

      if ((msg = req.ValidInfo()) != string.Empty)
      {
        return ResultModel.GetNullErrorModel(string.Empty, msg);
      }

      var createArticleParam = (CreateArticleParam)req;

      createArticleParam.UserId = userId;

      var mysqlConn = appSetting.GetMysqlConn();

      var dbConnection = context.GetConnection(mysqlConn.FlagKey, mysqlConn.ConnStr);

      var result =
        await DapperTools.CreateItem(dbConnection, EntityTools.GetTableName<ArticleInfo>(), createArticleParam);

      return ResultModel.GetSuccessModel(string.Empty, result);
    }

    #region first

//    public async Task<ResultModel> Run(AcceptParam acceptParam, AppSetting appSetting, HttpContext context)
//    {
//      var createArticleDto = acceptParam.AnalyzeParam<CreateArticleDto>();
//
//      if (createArticleDto == null)
//      {
//        return await Task.Run(() => ResultModel.GetNullErrorModel(String.Empty));
//      }
//
//      string msg;
//
//      if ((msg = createArticleDto.ValidInfo()) != string.Empty)
//      {
//        return await Task.Run(() => ResultModel.GetNullErrorModel(string.Empty, msg));
//      }
//
//      var createArticleParam = (CreateArticleParam) createArticleDto;
//
//      var mysqlConn = appSetting.GetMysqlConn();
//
//      var dbConnection = context.GetConnection(mysqlConn.FlagKey, mysqlConn.ConnStr);
//
//      var result =
//        await DapperTools.CreateItem(dbConnection, EntityTools.GetTableName<ArticleInfo>(), createArticleParam);
//
//      return ResultModel.GetSuccessModel(string.Empty, result);
//
////      logger.Info($@"
////{SqlCharConst.INSERT} {SqlCharConst.INTO} {EntityTools.GetTableName<ArticleInfo>()}
////(
////  {string.Join(",", EntityTools.GetFields<CreateArticleParam>())}
////)
////{SqlCharConst.VALUES} 
////(
////  {string.Join(",", EntityTools.GetFields<CreateArticleParam>("@"))}
////)
////");
////
////      var result = await dbConnection.ExecuteAsync($@"
////{SqlCharConst.INSERT} {SqlCharConst.INTO} {EntityTools.GetTableName<ArticleInfo>()}
////(
////  {string.Join(",", EntityTools.GetFields<CreateArticleParam>())}
////)
////{SqlCharConst.VALUES} 
////(
////  {string.Join(",", EntityTools.GetFields<CreateArticleParam>("@"))}
////)
////", createArticleParam);
////
////      return ResultModel.GetSuccessModel(string.Empty, result);
//    }

    #endregion

  }
}