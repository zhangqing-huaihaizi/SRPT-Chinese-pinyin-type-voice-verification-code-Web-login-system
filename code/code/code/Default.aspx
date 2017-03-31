<%@ Page Title="主页" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="code._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">

        .style1
        {
            width: 100%;
            height: 131px;
            margin-top: 0px;
        }
        .style17
        {
            width: 71px;
        }
        .style9
        {
            width: 127px;
        }
        .style8
        {
            width: 49px;
        }
        .style16
        {
            width: 221px;
        }
        </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        欢迎使用 ASP.NET!
    </h2>
    <p>
        若要了解关于 ASP.NET 的详细信息，请访问 <a href="http://www.asp.net/cn" title="ASP.NET 网站">www.asp.net/cn</a>。
    </p>
     
        <table class="style1">
            <tr>
                <td class="style17">
                    User</td>
                <td class="style9">
                    <asp:TextBox ID="TextBox3" runat="server" ontextchanged="TextBox3_TextChanged"></asp:TextBox>
                </td>
                <td class="style8">
                    &nbsp;</td>
                <td class="style16">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style17">
                    Password</td>
                <td class="style9">
                    <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" 
                        ontextchanged="TextBox4_TextChanged"></asp:TextBox>
                </td>
                <td class="style8">
                    &nbsp;</td>
                <td class="style16">
                    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                        Text="没有注册点此进行注册" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style17">
                    <asp:Label ID="Label2" runat="server" Text="Input"></asp:Label>
                </td>
                <td class="style9">
                    <asp:TextBox ID="TextBox2" runat="server" ontextchanged="TextBox2_TextChanged"></asp:TextBox>
                </td>
                <td class="style8">
                    &nbsp;</td>
                <td class="style16">
                    <asp:Button ID="Button1" runat="server" Text="显示验证码（看不清楚，换一张）" 
                        onclick="Button1_Click" Width="236px" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                        Text="输入完毕，确认提交" />
                </td>
            </tr>
            <tr>
                <td class="style17">
                    <asp:Label ID="Label3" runat="server" BackColor="#66FFFF" BorderColor="#FF3300" 
                        ForeColor="Red" Text="Checkcode"></asp:Label>
                </td>
                <td class="style9">
                    <asp:Image ID="Image1" runat="server" Height="45px" Width="150px" />
                </td>
                <td class="style8">
                    <asp:Image ID="Image2" runat="server" Height="42px" style="margin-top: 0px" 
                        Width="130px" />
                </td>
                <td class="style16">
                    <asp:Image ID="Image3" runat="server" Height="37px" Width="151px" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="重听 " />
                </td>
            </tr>
            <tr>
                <td class="style17">
                    &nbsp;</td>
                <td class="style9">
                    &nbsp;</td>
                <td class="style8">
                    &nbsp;</td>
                <td class="style16">
                    <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged" 
                        Width="232px" Height="28px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    <p>
        您还可以找到 <a href="http://go.microsoft.com/fwlink/?LinkID=152368"
            title="MSDN ASP.NET 文档">MSDN 上有关 ASP.NET 的文档</a>。
    </p>
</asp:Content>
