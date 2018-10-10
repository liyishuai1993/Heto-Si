<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rsclr.aspx.cs" Inherits="XSSystem.Page.P_Order.Rsclr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>日生产录入</title>
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
    <div> <p class="auto-style5">日生产录入</p>
        <div>
            <p>基本信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1271px" >
                <tr>
                    <td class="auto-style3">所属煤场<asp:TextBox ID="ssmc" runat="server" Height="16px" Width="500px"></asp:TextBox></td>
                    <td class="auto-style3">日期<asp:TextBox ID="rq" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox> </td>                                    
                </tr>
                <tr>
                    <td class="auto-style3">开机时间<asp:TextBox ID="kjsj" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">关机时间<asp:TextBox ID="gjsj" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">班次<asp:DropDownList id="bc" runat="server" Height="16px" Width ="500px" CssClass="auto-style4">
                        <asp:ListItem>白班</asp:ListItem>
                        <asp:ListItem>中班</asp:ListItem>
                        <asp:ListItem>夜班</asp:ListItem>
                      </asp:DropDownList> </td>
                    <td class="auto-style3">用电总数(度)<asp:TextBox id="ydzs" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">用电吨耗(吨/度)<asp:TextBox id="yddh" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">用煤总数(吨)<asp:TextBox id="ymzs" runat="server" Height="16px" Width ="500px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">公司名称<asp:TextBox id="gsmc" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>            
                    <td class="auto-style4" colspan="2"><asp:Button id="tjfy" Text="添加费用" runat="server" Width="60px" BorderStyle="Groove"/>&nbsp
                        加工费金额 <asp:TextBox id="jgfje" runat="server" Height="16px" Width ="150px"></asp:TextBox>&nbsp
                        每吨费用(元/吨)<asp:TextBox id="mdfy" runat="server" Height="16px" Width ="150px"></asp:TextBox>               
                    </td>
                </tr>                       
            </table>     
        </div>


        <div>
            <p class="auto-style5">生产信息</p>
            <p>
                <asp:Button ID="scxx_tjmz" runat="server" Text="添加煤种"/>&nbsp&nbsp
                <asp:DropDownList id="DropDownList1" runat="server" Height="16px" Width ="80px">
                    <asp:ListItem>请选择</asp:ListItem>
                </asp:DropDownList>
                数量(t):<asp:TextBox id="scxx_sl" runat="server" Height="16px" Width ="150px" CssClass="auto-style4"></asp:TextBox>&nbsp
                <asp:Button ID="scxx_jeBtn" runat="server" Text="金额(元)"/><asp:TextBox id="scxx_je" runat="server" Height="16px" Width ="200px" CssClass="auto-style4"></asp:TextBox>
                 颗粒产率%<asp:TextBox id="jmcl" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox>
                混合煤产率%<asp:TextBox id="zmcl" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox>
                沫煤产率%<asp:TextBox id="kscl" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox>
                中煤产率%<asp:TextBox id="TextBox1" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox>
                煤泥产率%<asp:TextBox id="TextBox2" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox>
                矸石产率%<asp:TextBox id="TextBox3" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox>
                损耗率%<asp:TextBox id="TextBox4" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox>
            </p>                
        </div>

        <div>
            <p class="auto-style5">产出信息</p>
            <p>
                <asp:Button ID="ccxx_tjmz" runat="server" Text="添加煤种"/>&nbsp&nbsp
                <asp:DropDownList id="DropDownList2" runat="server" Height="16px" Width ="80px">
                    <asp:ListItem>请选择</asp:ListItem>
                </asp:DropDownList>
                数量(t):<asp:TextBox id="ccxx_sl" runat="server" Height="16px" Width ="150px" CssClass="auto-style4"></asp:TextBox>&nbsp
                <asp:Button ID="ccxx_jeBtn" runat="server" Text="金额(元)"/><asp:TextBox id="ccxx_je" runat="server" Height="16px" Width ="200px" CssClass="auto-style4"></asp:TextBox>
                 产率%<asp:TextBox id="ccxx_cl" runat="server" Height="16px" Width ="80px" CssClass="auto-style4"></asp:TextBox>
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
