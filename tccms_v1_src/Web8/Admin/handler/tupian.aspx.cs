using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tc.Web.Admin.handler
{
    public partial class tupian : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string path = LibFile.rootpath;
                HttpPostedFile postfile = Request.Files["Filedata"];
                string res = "0";
                string filename = "";
                var sj = DateTime.Now.ToString("yyyyMM");
                if (!Directory.Exists(Server.MapPath(path + sj)))
                {
                    Directory.CreateDirectory(Server.MapPath(path + sj));
                }
                var viewwidth = "";
                var viewheight = "";
                try
                {
                    path = path + sj + "/";
                    FileInfo file = new FileInfo(postfile.FileName);
                    string ext = file.Extension;
                    Random rd = new Random();
                    var randomname = DateTime.Now.ToString("ddHHmmss") + rd.Next(100000, 200000);
                    filename = randomname + ext;
                    postfile.SaveAs(Server.MapPath(path + "y_" + filename));

                    ProcessImage p = new ProcessImage();

                    //0:创建缩略图失败，1：传入的文件格式错误，2：创建成功
                    int r = p.CreateThumbnail(postfile, Server.MapPath(path + filename));
                    if (r == 2)
                    {
                        string[] wh = Request.QueryString["wh"].GetString().Split(',');
                        var len = wh.Length;
                        if (len >= 2)
                        {
                            viewwidth = wh[0];
                            viewheight = wh[1];
                            for (int i = 0; i + 1 < len; i += 2)
                            {
                                if (wh[i].GetInt() > 0 && wh[i + 1].GetInt() > 0)
                                {
                                    r = p.CreateThumbnail(postfile, Server.MapPath(path + wh[i] + wh[i + 1] + "_" + filename), wh[i].GetInt(), wh[i + 1].GetInt(), true);
                                }
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            File.Delete(Server.MapPath(path + sj + "/y_" + filename));
                        }
                        catch { }
                    }
                    if (r == 2)
                    {
                        res = "1";
                    }
                    else
                    {
                        res = "0";
                    }
                }
                catch
                {
                    Response.Write(res);
                    Response.End();
                }

                //状态（1：成功，0：失败）|文件名称
                Response.Write("{res:'" + res + "',rukuname:'" + sj + "/" + filename + "',viewname:'" + LibFile.get_img(sj + "/" + filename, viewwidth, viewheight) + "'}");
                Response.End();
            }
        }
    }
}