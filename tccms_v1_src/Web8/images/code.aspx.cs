using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tc.Web.images
{
    public partial class code : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateCodeImg(CreateCode());
        }

        //******************************************************************* 
        //函数名称: CreateCode 
        //函数说明: 生成并返回随机的校验码 
        //输入参数: 
        //输出参数: 
        //函数返回: 
        // CreateCode --随机生成的校验码 
        //其他说明: 
        //******************************************************************* 
        private string CreateCode()
        {
            //string sCode = LibConst.UC_STR_NULL;
            //int iCnt;
            Random iRad = new Random();
            //for (iCnt = 0; iCnt <= LibConst.UC_VCODE_LEN - 1; iCnt++)
            //{
            //    char cCode;
            //    int iCode = iRad.Next();

            //    cCode = Strings.Chr(Strings.Asc("0") + (int)(iCode % 10));
            //    sCode = (sCode + cCode.ToString());
            //}
            int sCode = iRad.Next(0, 10000);
            if (sCode < 1000)
            {
                sCode = 9999 - sCode;
            }
            Session["vcode"] = sCode.ToString();
            return sCode.ToString();
        }

        //******************************************************************* 
        //函数名称: CreateCodeImg 
        //函数说明: 将随机生成校验码转化成图片 
        //输入参数: 
        // sCode --随机生成的校验码字符串 
        //输出参数: 
        //函数返回: 
        //其他说明: 
        //******************************************************************* 
        private void CreateCodeImg(string sCode)
        {
            if ((((sCode != null)) & (sCode.Trim() != "")))
            {
                double width = sCode.Length * 13;
                Bitmap CodeBitmap = new Bitmap(Convert.ToInt32(Math.Ceiling(width)), 20);
                Graphics CodeGraphics = Graphics.FromImage(CodeBitmap);

                try
                {
                    // 生成随机生成器 
                    Random LineRand = new Random();

                    // 清空图片背景色 
                    CodeGraphics.Clear(Color.White);

                    // 画图片的背景噪音线 
                    int iLineCnt;
                    for (iLineCnt = 0; iLineCnt <= 25 - 1; iLineCnt++)
                    {
                        int PointBeginX = LineRand.Next(CodeBitmap.Width);
                        int PointBeginY = LineRand.Next(CodeBitmap.Height);
                        int PointEndX = LineRand.Next(CodeBitmap.Width);
                        int PointEndY = LineRand.Next(CodeBitmap.Height);
                        CodeGraphics.DrawLine(new Pen(Color.Moccasin), PointBeginX, PointBeginY, PointEndX, PointEndY);
                    }

                    Font CodeFont = new Font("Arial", 12f, (FontStyle.Italic | FontStyle.Bold));
                    LinearGradientBrush CodeBrush = new LinearGradientBrush(new Rectangle(0, 0, CodeBitmap.Width, CodeBitmap.Height), Color.Black, Color.Black, 1.2f, true);
                    CodeGraphics.DrawString(sCode, CodeFont, CodeBrush, 2f, 2f);

                    // 画图片的前景噪音点 
                    int iPointCnt;
                    for (iPointCnt = 0; iPointCnt <= 100 - 1; iPointCnt++)
                    {
                        int PointX = LineRand.Next(CodeBitmap.Width);
                        int PointY = LineRand.Next(CodeBitmap.Height);
                        CodeBitmap.SetPixel(PointX, PointY, Color.FromArgb(LineRand.Next()));
                    }

                    // 画图片的边框线 
                    CodeGraphics.DrawRectangle(new Pen(Color.Gainsboro), 0, 0, (int)(CodeBitmap.Width - 1), (int)(CodeBitmap.Height - 1));

                    // 输出图片 
                    MemoryStream CodeStram = new MemoryStream();
                    CodeBitmap.Save(CodeStram, ImageFormat.Gif);
                    Response.ClearContent();
                    Response.ContentType = "image/Gif";
                    Response.CacheControl = "no-cache";
                    Response.Expires = -1;
                    Response.BinaryWrite(CodeStram.ToArray());
                }
                finally
                {
                    CodeGraphics.Dispose();
                    CodeBitmap.Dispose();
                }
            }
        }
    }
}