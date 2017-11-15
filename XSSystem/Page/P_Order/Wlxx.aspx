<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wlxx.aspx.cs" Inherits="XSSystem.Page.P_Order.Wlxx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>物料信息</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
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
    <div> <p class="auto-style5">物料信息</p>
        <div>
            <p>基本信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">物料名称<asp:TextBox ID="wlmc" runat="server" Height="16px" Width="1100px"></asp:TextBox></td>
                                   
                </tr>
                <tr>
                    <td class="auto-style3">物料编码<asp:TextBox id="wlbm" runat="server" Height="16px" Width ="1100px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">排序<asp:TextBox id="px" runat="server" Height="16px" Width ="1100px" ></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">所属分类<asp:TextBox id="ssfl" runat="server" Height="16px" Width ="1100px" ></asp:TextBox> </td>
                </tr>
            </table>     
        </div>
        


        <p class="auto-style5">
                <asp:Button ID="submit" text="保存" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp
                <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>
