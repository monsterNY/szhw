﻿using System.Collections.Generic;
using System.Data;
using System.Security.Claims;
using System.Threading.Tasks;
using Dapper;
using DapperContext;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Validation;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using Model.Common.ConfigModels;
using Model.Vlxm.Entity;
using Model.Vlxm.Tools;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using NLog;

namespace Monster.AuthServer.CusInherit
{
  public class CusResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
  {
    private readonly ISystemClock _clock;
    protected AppSetting AppSetting { get; set; }

    public static ILogger Logger = LogManager.GetCurrentClassLogger();

    public CusResourceOwnerPasswordValidator(ISystemClock clock, IOptionsMonitor<AppSetting> optionsMonitor)
    {
      _clock = clock;

      AppSetting = optionsMonitor.CurrentValue;
    }

    public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
    {
      if (true)
      {
        //验证失败
        context.Result =
          new GrantValidationResult(TokenRequestErrors.InvalidGrant, "invalid custom credential");
      }

      Logger.Debug(JsonConvert.SerializeObject(AppSetting));

      UserInfo clientUserInfo = null;

      IDbConnection conn = new MySqlConnection(AppSetting.DbConnMap["Mysql"].ConnStr);

//        var param = new UserInfo()
//        {
//          UserName = context.UserName,
//          LoginPwd = context.Password
//        };

      var whereList = new List<string>()
      {
        $"{nameof(UserInfo.UserName)} = '{context.UserName}'",
        $"{nameof(UserInfo.LoginPwd)} = '{context.Password}'"
      };

      //根据用户唯一标识查找用户信息
      clientUserInfo = await DapperTools.GetItem<UserInfo>(conn, EntityTools.GetTableName<UserInfo>(), whereList);
//        clientUserInfo = conn.QueryFirst<UserInfo>(
//          $"select * from article_info WHERE {nameof(UserInfo.UserName)} = {context.UserName} AND {nameof(UserInfo.LoginPwd)} = {context.Password}");

      //此处使用context.UserName, context.Password 用户名和密码来与数据库的数据做校验
      if (clientUserInfo != null)
      {
//                var user = _users.FindByUsername(context.UserName);

        //验证通过返回结果 
        //subjectId 为用户唯一标识 一般为用户id
        //authenticationMethod 描述自定义授权类型的认证方法 
        //authTime 授权时间
        //claims 需要返回的用户身份信息单元 此处应该根据我们从数据库读取到的用户信息 添加Claims 如果是从数据库中读取角色信息，那么我们应该在此处添加

        context.Result = new GrantValidationResult(clientUserInfo.RoleCode,
          OidcConstants.AuthenticationMethods.Password, _clock.UtcNow.UtcDateTime, new[]
          {
            new Claim(JwtClaimTypes.Id, clientUserInfo.Id.ToString()),
          });

        //                context.Result = new GrantValidationResult(
        ////                    user.SubjectId ?? throw new ArgumentException("Subject ID not set", nameof(user.SubjectId)),
        ////                    OidcConstants.AuthenticationMethods.Password, _clock.UtcNow.UtcDateTime,
        ////                    user.Claims
        //                    );
      }
      else
      {
        //验证失败
        context.Result =
          new GrantValidationResult(TokenRequestErrors.InvalidGrant, "invalid custom credential");
      }

      return;
    }
  }
}