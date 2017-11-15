<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Cdxx.aspx.cs" Inherits="XSSystem.Page.P_Order.Cdxx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>车队信息</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <link href="../../style/sysCss.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
    text-align: center;
    border-style: none;
        }
        .auto-style3 {
            height: 20px;
            width:1200px;
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
    <div> <p class="auto-style5">车队信息</p>
        <div>
            <p>基本信息</p>
            <table border="1" aria-haspopup="False" class="xs_table" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">车队名称<asp:TextBox ID="cdmc" runat="server" Height="16px" Width="1100px"></asp:TextBox></td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">车队编号<asp:TextBox id="cdbh" runat="server" Height="16px" Width ="1100px"></asp:TextBox> </td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">联系电话<asp:TextBox id="lxdh" runat="server" Height="16px" Width ="1100px" CssClass="auto-style4"></asp:TextBox> </td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">合理路耗<asp:TextBox id="hllh" runat="server" Height="16px" Width ="1100px" CssClass="auto-style4"></asp:TextBox> </td>
                    
                   
                </tr>
                
                <tr>
                    <td class="auto-style3">车队描述<asp:TextBox id="cdms" runat="server" Height="16px" Width ="1100px"></asp:TextBox> 
                    </td>
                </tr>
            </table>        
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
