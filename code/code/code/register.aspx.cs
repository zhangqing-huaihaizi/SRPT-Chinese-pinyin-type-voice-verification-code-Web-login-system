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
using System.Runtime.InteropServices;
using System.Threading;

namespace code
{
    public partial class register : System.Web.UI.Page
    {
        [DllImport("winmm.dll")]
        public static extern bool PlaySound(string pszSound, int hmod, int fdwSound);
        public const int SND_FILENAME = 0x00020000;
        public const int SND_ASYNC = 0x0001;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sourceDir = Server.MapPath("~");
            string myuser = TextBox3.Text;
            string mypassword;
            int i = 0;
            if (TextBox3.Text.Trim() == string.Empty)
            {
                TextBox6.Text = "请输入用户名!";
                PlaySound(sourceDir + "\\sounddone\\" + "请输入用户名.wav", 0, SND_ASYNC | SND_FILENAME);//播放WAV格式声音
            }
            else
            {
                string connString = "provider=Microsoft.Jet.OleDb.4.0;Data Source=E:\\SRTP\\code\\db1.mdb;";
                using (OleDbConnection oConn = new OleDbConnection(connString))
                {
                    OleDbCommand oCmd = oConn.CreateCommand(); //定义命令对象
                    oConn.Open();//打开连接对象 
                    oCmd.CommandText = "select * from info";   //指定命令对象的命令文本  

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
                            if (String.Compare(TextBox3.Text, odr.GetString(0), true) == 0)
                            {
                                TextBox6.Text = "用户名已存在，请更换用户名！";
                                PlaySound(sourceDir + "\\sounddone\\" + "用户名已存在.wav", 0, SND_ASYNC | SND_FILENAME);//播放WAV格式声音
                                i = 1;
                            }

                        } 
                    }

                    odr.Close(); //关闭数据读取器 
                    if (oConn.State != ConnectionState.Closed) //如果连接不是关闭状态则将连接关闭       
                        oConn.Close();
                }
                if (i == 0)
                {
                    if (TextBox4.Text.Trim() == string.Empty)
                    {
                        TextBox6.Text = "请输入密码!";
                        PlaySound(sourceDir + "\\sounddone\\" + "请输入密码.wav", 0, SND_ASYNC | SND_FILENAME);//播放WAV格式声音
                    }

                    else
                    {
                        if (String.Compare(TextBox4.Text, TextBox5.Text, true) == 0)
                        {
                            mypassword = TextBox4.Text;
                            string sql = "insert into info([user],[password]) values(@user,@password)";
                            string connString2 = "provider=Microsoft.Jet.OleDb.4.0;Data Source=E:\\SRTP\\code\\db1.mdb;";

                            OleDbParameter[] parameters = { new OleDbParameter("@user", myuser), new OleDbParameter("@password", mypassword) };

                            using (OleDbConnection oConn = new OleDbConnection(connString2))
                            {
                                //  OleDbCommand oCmd = oConn.CreateCommand(); //定义命令对象
                                oConn.Open();//打开连接对象 
                                //if (oConn.State == ConnectionState.Open)
                                //{
                                //    Response.Write("数据库连接成功！<br>");
                                //}

                                using (OleDbCommand oCmd = oConn.CreateCommand())
                                {
                                    oCmd.Connection = oConn; //指定命令对象使用的连接

                                    oCmd.CommandText = sql;
                                    oCmd.Parameters.AddRange(parameters);
                                    oCmd.ExecuteNonQuery();
                                }
                                if (oConn.State != ConnectionState.Closed) //如果连接不是关闭状态则将连接关闭       
                                    oConn.Close();
                            }
                            //   Response.Write("<script>window.showModalDialog('Default2.aspx')</script>");
                            //Response.Write("<script>alert('注册成功')</script>");
                            // Thread.Sleep(1500);
                            PlaySound(sourceDir + "\\sounddone\\" + "注册成功.wav", 0, SND_ASYNC | SND_FILENAME);//播放WAV格式声音
                            Thread.Sleep(1500);
                            Response.Redirect("Default.aspx");
                        }
                        else
                        {
                            TextBox6.Text = "两次输入密码不一致!";
                            PlaySound(sourceDir + "\\sounddone\\" + "两次输入密码不一致.wav", 0, SND_ASYNC | SND_FILENAME);//播放WAV格式声音
                        }
                    }
                }
            }

      //  if(String.Compare(TextBox4.Text, TextBox5.Text, true) == 0)
      //      Response.Redirect("Default.aspx");
            
            
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}