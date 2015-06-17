using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Tc
{
    public class LibFile
    {
        public static string rootpath = "/upload/";

        /// <summary>
        /// 图片转换为带有尺寸路径的图片
        /// </summary>
        /// <param name="imgpath">数据库内存入的路径(格式为 201211/_文件名称)</param>
        /// <param name="width">可以留空</param>
        /// <param name="height">可以留空</param>
        /// <returns></returns>
        public static string get_img(string imgpath, string width, string height)
        {
            if (imgpath.Length > 0)
            {
                if (width.Length <= 0 && height.Length <= 0)
                {
                    return rootpath + imgpath;
                }
                else
                {
                    var res = rootpath + imgpath.Replace("/", "/" + width + height + "_");
                    var server = HttpContext.Current.Server;
                    if (!File.Exists(server.MapPath(res)))
                    {
                        if (File.Exists(server.MapPath(rootpath + imgpath)))
                            new ProcessImage().CreateThumbnail(server.MapPath(rootpath + imgpath), server.MapPath(res), width.GetInt(), height.GetInt(), true);
                    }
                    return res;
                }
            }
            else
            {
                return "";
            }
        }
    }
}