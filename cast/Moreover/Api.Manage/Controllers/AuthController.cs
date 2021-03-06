﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Api.Manage.Assist.CusAttribute;
using Api.Manage.Assist.Entity;
using Api.Manage.Assist.Menu;
using Api.Manage.CusInterface;
using IdentityModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Model.Common.ConfigModels;
using Model.Common.CusAttr;
using Model.Common.Extension;
using NLog;

namespace Api.Manage.Controllers
{

  /// <summary>
  /// 需要身份验证的功能入口
  /// </summary>
  [EnableCors("AllowCors")]
  [ApiController]
  [Route("api/[controller]")]
//  [NotFoundActionFilter]//
  public class AuthController : ControllerBase
  {
    protected AppSetting AppSetting { get; set; }

    protected ILogger Logger = LogManager.GetCurrentClassLogger();

    public AuthController(IOptionsMonitor<AppSetting> optionsMonitor)
    {
      AppSetting = optionsMonitor.CurrentValue;
    }

    /// <summary>
    /// 统一请求地址 [需授权]
    /// </summary>
    /// <param name="acceptParam"> detail in <see cref="AcceptParam"/> </param>
    /// <returns></returns>
    [Route("")]
    [HttpPost]
    [Authorize]
    public async Task<object> AuthIndex([FromBody] AcceptParam acceptParam)
    {

      var acceptUserId = User.Claims.FirstOrDefault(u => u.Type == JwtClaimTypes.Id)?.Value;//获取用户id

      if (acceptUserId == null)
      {
        return ResultModel.GetParamErrorModel("account not found");
      }

      var userId = Convert.ToInt64(acceptUserId);

      try
      {
        if (Enum.TryParse(acceptParam.OperationFlag, true, out AuthOperationMenu operationMenu))//通过操作符找到处理对象
        {
          var dealAttribute = operationMenu.GetAttribute<AuthDealAttribute>();//获取相关特性信息

          //处理对象验证
          if (dealAttribute == null)
            return operationMenu.ToString();

          //验签处理
          if (dealAttribute.NeedValidSign)
            if (acceptParam.Param != null || !ValidSign(acceptParam))
              return "验签失败！";

          //执行操作
          var resultModel = await Run(acceptParam, AppSetting, dealAttribute,userId);

          //结果集标识
          resultModel.Title = dealAttribute.Description;

          return resultModel;

        }
        else
        {
        }

        return acceptParam;

      }
      catch (Exception e)
      {
        return e;
      }
    }

    /// <summary>
    /// 执行操作
    /// </summary>
    /// <param name="acceptParam"></param>
    /// <param name="appSetting"></param>
    /// <param name="dealAttribute"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    [NonAction]
    public async Task<ResultModel> Run(AcceptParam acceptParam, AppSetting appSetting,
      AuthDealAttribute dealAttribute,long userId)
    {

      var instance = Activator.CreateInstance(dealAttribute.DealService) as IAuthDeal;
      Logger.Info($"调用:{dealAttribute.DealService.Name}");

      return await instance.Run(acceptParam, appSetting, HttpContext,userId);
    }
    
    /// <summary>
    /// 验证签名
    /// </summary>
    /// <returns></returns>
    public bool ValidSign(AcceptParam acceptParam)
    {
      return true;
    }
  }
}