<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pmdlr.aspx.cs" Inherits="XSSystem.Page.P_Order.Pmdlr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>配煤单录入</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
    text-align: center;
    border-style: none;
        }
        .auto-style3 {
            height: 20px;
            width:640px;
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
<body style="height: auto; width: auto">
    <form id="form1" runat="server">
    <div> <p class="auto-style5">配煤单录入</p>
        <div>
            <p>基本信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1271px" >
                <tr>
                    <td class="auto-style3">配煤编号<asp:TextBox ID="pmbh" runat="server" Height="16px" Width="500px"></asp:TextBox></td>
                    <td class="auto-style3">配煤日期<asp:TextBox ID="pmrq" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox> </td>                                    
                </tr>
                
                <tr>
                    <td class="auto-style3">生产煤场<asp:TextBox id="scmc" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">公司名称<asp:TextBox id="gsmc" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox></td>
                </tr>                      
            </table>     
        </div>


        <div>
            <p class="auto-style5">原料煤种</p>
            <p>
                <asp:Button ID="ylmz_tjje" runat="server" Text="添加原料"/>&nbsp&nbsp 
                原料
                <asp:DropDownList id="DropDownList1" runat="server" Height="16px" Width ="80px">
                    <asp:ListItem>请选择</asp:ListItem>
                </asp:DropDownList>      
                 原料吨数<asp:TextBox id="ylds" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox>  
                成本单价<asp:TextBox id="cbdj" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox>   
                 配煤费(元/吨)<asp:TextBox id="pmf" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox> 
                 金额(元)<asp:TextBox id="je" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox>
            </p>                
        </div>

        <div>
            <p class="auto-style5">产出煤种</p>
            <p>
                <asp:Button ID="ccmz_tjje" runat="server" Text="添加产品"/>&nbsp&nbsp 
                产品
                <asp:DropDownList id="DropDownList2" runat="server" Height="16px" Width ="80px">
                    <asp:ListItem>请选择</asp:ListItem>
                </asp:DropDownList>
                产出吨数<asp:TextBox id="ccds" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox>
                 金额(元)<asp:TextBox id="je2" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox>
                 成本单价(元/吨)<asp:TextBox id="cbdj2" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox>
            </p>                
        </div>
        
        <p class="auto-style5">
            <asp:Button ID="submit" text="保存" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp     
            <asp:Button ID="Button1" text="重填" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp
        </p> 
        </div>
    </form>
</body>
</html>
