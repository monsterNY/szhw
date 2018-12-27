﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace XD.Store.Api.ImgServer.UploadInfo
{
    public abstract class SuperUpload
    {

        protected const string SUCCESS = "success";

        /// <summary>
        /// 开启上传 【由子类实现】
        /// </summary>
        /// <param name="imgFile"></param>
        /// <param name="saveUrl"></param>
        /// <returns></returns>
        protected abstract string Run(HttpPostedFileBase imgFile, string saveUrl);

        /// <summary>
        /// 进行上传
        /// </summary>
        /// <param name="imgFile"></param>
        /// <param name="saveUrl"></param>
        /// <returns></returns>
        public string UploadInfo(HttpPostedFileBase imgFile, string saveUrl)
        {
            if (ValidImg(imgFile))
            {
                try
                {
                    return Run(imgFile, saveUrl);
                }
                catch (Exception e)
                {
                    //日志记录
                    throw e;
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// 图片文件验证
        /// </summary>
        /// <param name="imgFile"></param>
        /// <returns></returns>
        protected virtual bool ValidImg(HttpPostedFileBase imgFile)
        {
            if (imgFile == null)
            {
                return false;
            }

            //1.valid file type
            var ext = Path.GetExtension(imgFile.FileName);

            if (!(ext == ".jpeg" || ext == ".jpg" || ext == ".png" || ext == ".gif"))
            {
                //不是图片的时候：
                return false;
            }
            return true;
        }
        
    }
}