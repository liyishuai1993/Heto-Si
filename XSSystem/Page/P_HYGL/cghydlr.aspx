<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cghydlr.aspx.cs" Inherits="XSSystem.Page.P_Order.cghydlr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>采购化验单录入</title>
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
    <div> <p class="auto-style5">采购化验单录入</p>
        <div>
            <p>基本信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*化验单编号<asp:TextBox ID="hydbh" runat="server" Height="16px" Width="500px"></asp:TextBox></td>
                    <td class="auto-style3">*化验日期<asp:TextBox ID="hyrq" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox></td>                                    
                </tr>
                <tr>
                    <td class="auto-style3">供应商<asp:TextBox id="gys" runat="server" Height="16px" Width ="500px"></asp:TextBox> </td>
                    <td class="auto-style3">煤场名称<asp:TextBox id="mkmc" runat="server" Height="16px" Width ="500px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">物料名称<asp:TextBox id="wlmc" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">采样人<asp:TextBox id="cyr" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">化验人<asp:TextBox id="hyr" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3"></td>
                    
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
