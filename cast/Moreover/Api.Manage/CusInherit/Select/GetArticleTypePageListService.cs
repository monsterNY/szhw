﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Manage.Assist.Req;
using Api.Manage.Assist.Entity;
using Api.Manage.Assist.Extension;
using Api.Manage.CusInterface;
using DapperContext;
using DapperContext.Const;
using Microsoft.AspNetCore.Http;
using Model.Common.ConfigModels;
using Model.Common.Models;
using Model.Vlxm.Entity;
using Model.Vlxm.Tools;

namespace Api.Manage.CusInherit.Select
{
  public class GetArticleTypePageListService:IDeal
  {
    public async Task<ResultModel> Run(AcceptParam acceptParam, AppSetting appSetting, HttpContext context)
    {
      //解析参数
      var pageModel = acceptParam.AnalyzeParam<PageModel<FilterReq>>();

      if (pageModel == null)
      {
        return ResultModel.GetNullErrorModel(string.Empty);
      }

      //动态sql
//      StringBuilder whereBuilder = new StringBuilder();
      List<string> whereList = new List<string>();

      if (pageModel.Result.ValidFlag != null && pageModel.Result.ValidFlag >= 0)
      {
//        whereBuilder.Append($@"
//{SqlCharConst.WHERE} {EntityTools.GetField<ArticleType>(nameof(ArticleType.ValidFlag))} = {pageModel.Result.ValidFlag}
//");
        whereList.Add($"{EntityTools.GetField<ArticleType>(nameof(ArticleType.ValidFlag))} = {pageModel.Result.ValidFlag}");
      }

      //获取连接
      var mysqlConn = appSetting.GetMysqlConn();

      var dbConnection = context.GetConnection(mysqlConn.FlagKey, mysqlConn.ConnStr);

      //采用工具类分页查询
      var pageList = await DapperTools.GetPageList<ArticleType>(pageModel.PageNo, pageModel.PageSize, dbConnection,
        whereList);

      //返回结果集
      return ResultModel.GetSuccessModel(string.Empty, pageList);
    }
  }
}
