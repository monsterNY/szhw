﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Manage.Assist.Dto
{
  public class ArticlePageFilterDto:FilterDto
  {

    public int? ArticleType { get; set; }

    /// <summary>
    /// 筛选类型 0 -- 全部  1 -- 仅自己 
    /// </summary>
    public int FilterType { get; set; }

  }
}