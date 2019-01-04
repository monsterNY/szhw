﻿using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Api.Authorization;
using IdentityModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Api.Manage.Authorization
{
  public class CusAuthorizationFilter : IAuthorizationFilter
  {
    public void OnAuthorization(AuthorizationFilterContext context)
    {
      if (context.Filters.Any(item => item is IAllowAnonymousFilter))
      {
        return;
      }

      if (!(context.ActionDescriptor is ControllerActionDescriptor))
      {
        return;
      }

      var attributeList = new List<object>();
      attributeList.AddRange(
        (context.ActionDescriptor as ControllerActionDescriptor).MethodInfo.GetCustomAttributes(true));
      attributeList.AddRange((context.ActionDescriptor as ControllerActionDescriptor).MethodInfo.DeclaringType
        .GetCustomAttributes(true));
      var authorizeAttributes = attributeList.OfType<TestAuthorizeAttribute>().ToList();

      var firstOrDefault = context.HttpContext.User.Claims.FirstOrDefault(u=>JwtClaimTypes.Id.Equals(u.Type));

//      if (firstOrDefault == null)
//      {
//        context.Result;
//      }

//      var claims = context.HttpContext.User.Claims;
//      // 从claims取出用户相关信息，到数据库中取得用户具备的权限码，与当前Controller或Action标识的权限码做比较
//      var userPermissions = "User_Edit";
//      if (!authorizeAttributes.Any(s => s.Permission.Equals(userPermissions)))
//      {
//        context.Result = new JsonResult("没有权限");
//      }

      return;
    }
  }
}