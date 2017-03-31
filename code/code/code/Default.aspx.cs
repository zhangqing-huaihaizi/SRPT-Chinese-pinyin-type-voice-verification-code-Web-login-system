using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; //使用OleDb连接模式
using System.Drawing;
using System.Web.SessionState;
using System.Web.UI.HtmlControls;
using System.IO;
using System.IO.Compression;
using sounding;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using System.Runtime.InteropServices;
using System.Threading;

namespace code
{
    public partial class _Default : System.Web.UI.Page
    {
        [DllImport("winmm.dll")]
        public static extern bool PlaySound(string pszSound, int hmod, int fdwSound);
        public const int SND_FILENAME = 0x00020000;
        public const int SND_ASYNC = 0x0001;
        
        static Random random = new Random();

        int a = random.Next(7, 60);
        int b = random.Next(7, 60);
        int c = random.Next(7, 60);
        protected void Page_Load(object sender, EventArgs e)
        {
              //string code;
         //   string sourceDir = Server.MapPath("~");
         //   File.Delete(sourceDir + "\\sound\\asdf.jpg");
         //   File.Delete(sourceDir + "\\sound\\dfg.jpg");
         //   File.Delete(sourceDir + "\\sound\\hgf.jpg");

              //Image1.ImageUrl = "~/picturedone/1_finished.jpg";
              //Image2.ImageUrl = "~/picturedone/2_finished.jpg";
              //Image3.ImageUrl = "~/picturedone/3_finished.jpg";

           //   File.Delete("E:\\SRTP\\code\\code\\code\\picturedone\\1_finished.jpg");
           //   File.Delete("E:\\SRTP\\code\\code\\code\\picturedone\\2_finished.jpg");
           //   File.Delete("E:\\SRTP\\code\\code\\code\\picturedone\\3_finished.jpg");
           //   File.Delete("E:\\SRTP\\code\\sounddone\\1.wav");
           //   File.Delete("E:\\SRTP\\code\\sounddone\\2.wav");
           //   File.Delete("E:\\SRTP\\code\\sounddone\\3.wav");
            
           // string aa = string.Empty;
           // string bb = string.Empty;
           // string cc = string.Empty;




           // MWNumericArray u = null;
           // MWNumericArray v = null;
           // MWNumericArray w = null;
           // SoundTest obj = null;
           // u = a; v = b; w = c;
           // obj = new SoundTest();

           // MWArray result = null;
           // result = obj.mix( u, v, w);


           // //MWNumericArray output = null;
           ////output = (MWNumericArray)result[0];


           // //SoundTest1 obj1 = null;
           // //MWArray u = null;
           // //u = 11;
           // //obj1 = new SoundTest1();
           // //MWArray result = null;
           // //result = obj1.mix1(u);



           // //SoundTest2 obj2 = null;
           // //MWArray v = null;
           // //v = 12;
           // //obj2 = new SoundTest2();
           // //MWArray result2 = null;
           // //result2 = obj2.mix2(v);

           // //SoundTest3 obj3 = null;
           // //MWArray w = null;
           // //w = 13;
           // //obj3 = new SoundTest3();
           // //MWArray result3 = null;
           // //result3 = obj3.mix3(w);

           // //定义连接字符串，该连接字符串是使用OleDb连接模式连接Access数据库的方法 
           // string connString = "provider=Microsoft.Jet.OleDb.4.0;Data Source=E:\\SRTP\\code\\db1.mdb;";
           // using (OleDbConnection oConn = new OleDbConnection(connString))
           // {
           //     OleDbCommand oCmd = oConn.CreateCommand(); //定义命令对象
           //     oConn.Open();//打开连接对象 
           //     oCmd.CommandText = "select * from pinyin";   //指定命令对象的命令文本  
             
           //     //oCmd.CommandType = CommandType.Text;

           //     oCmd.Connection = oConn; //指定命令对象使用的连接
              
           ///*     if (oConn.State == ConnectionState.Open)
           //     {
           //         Response.Write("数据库连接成功！<br>");
           //      }
           // */
           //     OleDbDataReader odr;
           //     odr = oCmd.ExecuteReader(CommandBehavior.CloseConnection); //定义数据读取器,执行命令对象，并用odr指向结果集

           //     if (odr != null) //如果odr不为空 
           //     {
           //         while (odr.Read()) //调用数据读取器的Read方法读取一条数据       
           //         {   
           //             if (a != b && a!=c && b!=c)
           //             {
           //                 if (odr.GetInt32(0) == a)
           //                     aa = odr.GetString(1);
           //                 else if (odr.GetInt32(0) == b)
           //                     bb = odr.GetString(1);
           //                 else if (odr.GetInt32(0) == c)
           //                     cc = odr.GetString(1);
           //             }
           //             else if (a == b && b != c)
           //             {
           //                 if (odr.GetInt32(0) == a)
           //                 {
           //                     aa = odr.GetString(1);
           //                     bb = odr.GetString(1);
           //                 }
           //                 else if (odr.GetInt32(0) == c)
           //                     cc = odr.GetString(1);
           //             }
           //             else if (a == c && a != b)
           //             {
           //                 if (odr.GetInt32(0) == a)
           //                 {
           //                     aa = odr.GetString(1);
           //                     cc = odr.GetString(1);
           //                 }
           //                 else if (odr.GetInt32(0) == b)
           //                     bb = odr.GetString(1);
           //             }
           //             else if (b == c && a != b)
           //             {
           //                 if (odr.GetInt32(0) == b)
           //                 {
           //                     bb = odr.GetString(1);
           //                     cc = odr.GetString(1);
           //                 }
           //                 else if (odr.GetInt32(0) == a)
           //                     aa = odr.GetString(1);
           //             }
           //             else if (a == b && b == c)
           //             {
           //                 if (odr.GetInt32(0) == a)
           //                 {
           //                     bb = odr.GetString(1);
           //                     cc = odr.GetString(1);
           //                     aa = odr.GetString(1);
           //                 }
           //             }
           //           }
           //         code=aa+bb+cc;
           //         //Label1.Text = code;
           //         Response.Cookies.Add(new HttpCookie("CheckCode", code));
           //      } 
                
           //     odr.Close(); //关闭数据读取器 
           // if (oConn.State != ConnectionState.Closed) //如果连接不是关闭状态则将连接关闭       
           //     oConn.Close(); 
           //}
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string sourceDir = Server.MapPath("~");
            string user = TextBox3.Text;
            string password = TextBox4.Text;
            int t=0;

            string connString = "provider=Microsoft.Jet.OleDb.4.0;Data Source=E:\\SRTP\\code\\db1.mdb;";
            using (OleDbConnection oConn = new OleDbConnection(connString))
            {
                OleDbCommand oCmd = oConn.CreateCommand(); //定义命令对象
                oConn.Open();//打开连接对象 
                oCmd.CommandText = "select * from info";   //指定命令对象的命令文本  

                //oCmd.CommandType = CommandType.Text;

                oCmd.Connection = oConn; //指定命令对象使用的连接

          /*      if (oConn.State == ConnectionState.Open)
                {
                    Response.Write("数据库2连接成功！<br>");
                }
            */
                OleDbDataReader odr;
                odr = oCmd.ExecuteReader(CommandBehavior.CloseConnection); //定义数据读取器,执行命令对象，并用odr指向结果集

                if (odr != null) //如果odr不为空 
                {
                    while (odr.Read()) //调用数据读取器的Read方法读取一条数据       
                    {     
                        if (String.Compare(odr.GetString(0), user, true) == 0)
                        {
                            if (String.Compare(odr.GetString(1), password, true) == 0)   //登录成功
                                t = 1;    //登录成功
                            else
                            {
                                TextBox1.Text = "密码错误!"; //密码错误
                                PlaySound(sourceDir + "\\sounddone\\" + "密码错误.wav", 0, SND_ASYNC | SND_FILENAME);//播放WAV格式声音
                                t = 2;
                            }
                        }
                    }
                    if (t == 0)
                    {
                        TextBox1.Text = "用户名错误!";
                        PlaySound(sourceDir + "\\sounddone\\" + "用户名错误.wav", 0, SND_ASYNC | SND_FILENAME);//播放WAV格式声音
                    }
                }
                odr.Close(); //关闭数据读取器 
                if (oConn.State != ConnectionState.Closed) //如果连接不是关闭状态则将连接关闭       
                    oConn.Close();
                if (t == 1)
                {
                    if (Request.Cookies["CheckCode"] == null)
                    {
                        TextBox1.Text = "您的浏览器禁用Cookie，请打开Cookie功能以使用本系统";
                        TextBox1.Visible = true;
                        return;
                    }
                    if (String.Compare(Request.Cookies["CheckCode"].Value, TextBox2.Text, true) != 0)
                    {
                        TextBox1.Text = "验证码错误,请输入正确的验证码!";
                        TextBox1.Visible = true;
                        PlaySound(sourceDir+"\\sounddone\\" + "输入错误提示音.wav", 0, SND_ASYNC | SND_FILENAME);//播放WAV格式声音
                        Thread.Sleep(3500);//播放1500毫秒（1.5秒）
                        return;
                    }
                    else
                    {
                        TextBox1.Text = "验证码正确!";
                        PlaySound(sourceDir + "\\sounddone\\" + "登录成功.wav", 0, SND_ASYNC | SND_FILENAME);//播放WAV格式声音
                        Response.Write("登录成功");
                        Button2.PostBackUrl = "~/login.aspx";
                        // Response.Write("<script>window.showModalDialog('Default2.aspx')</script>");
                        Response.Redirect("login.aspx");

                    }
                }

            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            string code;
            string sourceDir = Server.MapPath("~");


              File.Delete(sourceDir+"\\picturedone\\1_finished.jpg");
              File.Delete(sourceDir + "\\picturedone\\2_finished.jpg");
              File.Delete(sourceDir + "\\picturedone\\3_finished.jpg");
              File.Delete(sourceDir + "\\sounddone\\1.wav");
              File.Delete(sourceDir + "\\sounddone\\2.wav");
              File.Delete(sourceDir + "\\sounddone\\3.wav");
            
            string aa = string.Empty;
            string bb = string.Empty;
            string cc = string.Empty;

            MWNumericArray u = null;
            MWNumericArray v = null;
            MWNumericArray w = null;
            SoundTest obj = null;
            u = a; v = b; w = c;
            obj = new SoundTest();

            MWArray result = null;
            result = obj.mix( u, v, w);


            //定义连接字符串，该连接字符串是使用OleDb连接模式连接Access数据库的方法 
            string connString = "provider=Microsoft.Jet.OleDb.4.0;Data Source=E:\\SRTP\\code\\db1.mdb;";
            using (OleDbConnection oConn = new OleDbConnection(connString))
            {
                OleDbCommand oCmd = oConn.CreateCommand(); //定义命令对象
                oConn.Open();//打开连接对象 
                oCmd.CommandText = "select * from pinyin";   //指定命令对象的命令文本  

                //oCmd.CommandType = CommandType.Text;

                oCmd.Connection = oConn; //指定命令对象使用的连接

                /*     if (oConn.State == ConnectionState.Open)
                     {
                         Response.Write("数据库连接成功！<br>");
                      }
                 */
                OleDbDataReader odr;
                odr = oCmd.ExecuteReader(CommandBehavior.CloseConnection); //定义数据读取器,执行命令对象，并用odr指向结果集

                if (odr != null) //如果odr不为空 
                {
                    while (odr.Read()) //调用数据读取器的Read方法读取一条数据       
                    {
                        if (a != b && a != c && b != c)
                        {
                            if (odr.GetInt32(0) == a)
                                aa = odr.GetString(1);
                            else if (odr.GetInt32(0) == b)
                                bb = odr.GetString(1);
                            else if (odr.GetInt32(0) == c)
                                cc = odr.GetString(1);
                        }
                        else if (a == b && b != c)
                        {
                            if (odr.GetInt32(0) == a)
                            {
                                aa = odr.GetString(1);
                                bb = odr.GetString(1);
                            }
                            else if (odr.GetInt32(0) == c)
                                cc = odr.GetString(1);
                        }
                        else if (a == c && a != b)
                        {
                            if (odr.GetInt32(0) == a)
                            {
                                aa = odr.GetString(1);
                                cc = odr.GetString(1);
                            }
                            else if (odr.GetInt32(0) == b)
                                bb = odr.GetString(1);
                        }
                        else if (b == c && a != b)
                        {
                            if (odr.GetInt32(0) == b)
                            {
                                bb = odr.GetString(1);
                                cc = odr.GetString(1);
                            }
                            else if (odr.GetInt32(0) == a)
                                aa = odr.GetString(1);
                        }
                        else if (a == b && b == c)
                        {
                            if (odr.GetInt32(0) == a)
                            {
                                bb = odr.GetString(1);
                                cc = odr.GetString(1);
                                aa = odr.GetString(1);
                            }
                        }
                    }
                    code = aa + bb + cc;
                    //Label1.Text = code;
                    Response.Cookies.Add(new HttpCookie("CheckCode", code));
                }

                odr.Close(); //关闭数据读取器 
                if (oConn.State != ConnectionState.Closed) //如果连接不是关闭状态则将连接关闭       
                    oConn.Close();
            }

            

            //Response.Write(a.ToString());
            //Response.Write(b.ToString());
            //Response.Write(c.ToString());
            PlaySound(sourceDir+"\\sounddone\\"+"1.wav", 0, SND_ASYNC | SND_FILENAME);//播放WAV格式声音
            Thread.Sleep(2000);//播放1500毫秒（1.5秒）
            PlaySound(sourceDir + "\\sounddone\\" + "2.wav", 0, SND_ASYNC | SND_FILENAME);//播放WAV格式声音
            Thread.Sleep(2000);//播放1500毫秒（1.5秒）
            PlaySound(sourceDir + "\\sounddone\\" + "3.wav", 0, SND_ASYNC | SND_FILENAME);//播放WAV格式声音
            Thread.Sleep(2000);//播放1500毫秒（1.5秒）
         //   PlaySound("E:\\SRTP\\code\\sound1\\2.wav", 0, SND_ASYNC | SND_FILENAME);//播放WAV格式声音


            Image1.ImageUrl = "~/picturedone/1_finished.jpg";
            Image2.ImageUrl = "~/picturedone/2_finished.jpg";
            Image3.ImageUrl = "~/picturedone/3_finished.jpg";


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button3.PostBackUrl = "~/register.aspx";
            Response.Redirect("register.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string sourceDir = Server.MapPath("~");
            PlaySound(sourceDir + "\\sounddone\\" + "1.wav", 0, SND_ASYNC | SND_FILENAME);//播放WAV格式声音
            Thread.Sleep(2000);//播放1500毫秒（1.5秒）
            PlaySound(sourceDir + "\\sounddone\\" + "2.wav", 0, SND_ASYNC | SND_FILENAME);//播放WAV格式声音
            Thread.Sleep(2000);//播放1500毫秒（1.5秒）
            PlaySound(sourceDir + "\\sounddone\\" + "3.wav", 0, SND_ASYNC | SND_FILENAME);//播放WAV格式声音
            Thread.Sleep(2000);//播放1500毫秒（1.5秒）
        }
    }
}
