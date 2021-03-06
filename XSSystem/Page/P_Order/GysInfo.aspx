﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GysInfo.aspx.cs" Inherits="XSSystem.Page.P_Order.GysInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>供应商信息</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
    text-align: center;
    border-style: none;
        }
        .auto-style3 {
            height: 20px;
            width:600px;
            text-align:right;
            }
        .Wdate {}
        .auto-style4 {
            text-align:left;
        }
        .auto-style5 {
            height:auto;
            width:auto;
            text-align:center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div> <p class="auto-style5">供应商信息</p>
        <div>
            <p>供应商信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">供应商名称<asp:TextBox ID="gysmc" runat="server" Height="16px" Width="500px"></asp:TextBox></td>
                    <td class="auto-style3">供应商简称<asp:TextBox id="gysjc" runat="server" Height="16px" Width ="500px"></asp:TextBox> </td>
                    

                </tr>
                <tr>
                    <td class="auto-style3">供应编码<asp:TextBox id="gybm" runat="server" Height="16px" Width ="500px"></asp:TextBox> </td>
                    <td class="auto-style3">助记码<asp:TextBox id="zjm" runat="server" Height="16px" Width ="500px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">关联类型<asp:DropDownList id="gllx" runat="server" Height="25px" Width ="500px" CssClass="auto-style4">
                        <asp:ListItem>供应商</asp:ListItem>
                        <asp:ListItem>煤站</asp:ListItem>
                        </asp:DropDownList> </td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">信用吨数<asp:TextBox id="xyds" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">信用额度<asp:TextBox id="xyed" runat="server" Height="16px" Width ="500px"></asp:TextBox> 
                    </td>
                </tr>
                
                <tr>
                    <td class="auto-style4" colspan="2">描述<asp:TextBox id="ms" runat="server" Height="16px" Width ="1100px"></asp:TextBox> 
                    </td>
                </tr>
            </table>   
            <hr width="100%" color="#987cb9" size="1" />      
            <p>
                 <asp:Button ID="addUser" text="添加账户" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp&nbsp;&nbsp;&nbsp;&nbsp;
                    开户银行<asp:TextBox id="khyh" runat="server" Height="16px" Width ="280px"></asp:TextBox>
                账户名称<asp:TextBox id="zhmc" runat="server" Height="16px" Width ="280px"></asp:TextBox>
                账号<asp:TextBox id="zh" runat="server" Height="16px" Width ="280px"></asp:TextBox>
            </p>   
        </div>
        


        <p class="auto-style5">
                <asp:Button ID="submit" text="保存" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp
                <asp:Button ID="refresh" text="重填" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp
            <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>
