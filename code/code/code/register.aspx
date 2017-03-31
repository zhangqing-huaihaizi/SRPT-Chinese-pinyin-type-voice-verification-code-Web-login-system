<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="code.register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style9
        {
            width: 127px;
        }
        
        .style1
        {
            width: 100%;
            height: 131px;
            margin-top: 0px;
        }
        .style18
        {
            width: 50px;
            height: 63px;
        }
        .style21
        {
            font-size: medium;
            width: 9px;
        }
        .style22
        {
            width: 9px;
        }
        .style23
        {
            width: 127px;
            height: 63px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style22">
                    User</td>
                <td class="style9">
                    <asp:TextBox ID="TextBox3" runat="server" ontextchanged="TextBox3_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style21">
                    Password</td>
                <td class="style9">
                    <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" 
                        ontextchanged="TextBox4_TextChanged"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
     
        <table class="style1">
            <tr>
                <td class="style18">
                    Password Again</td>
                <td class="style23">
                    <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" 
                        ontextchanged="TextBox4_TextChanged"></asp:TextBox>
                </td>
            </tr>
        </table>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="确认注册" />
        &nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox6" runat="server" 
            ontextchanged="TextBox6_TextChanged" Height="31px" Width="253px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" 
            onclick="Button2_Click" Text="点此返回登录界面！" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
