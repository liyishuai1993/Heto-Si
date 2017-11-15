<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cdyffkd.aspx.cs" Inherits="XSSystem.Page.P_Order.Cdyffkd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>车队运费付款单</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
    text-align: center;
    border-style: none;
        }
        .auto-style3 {
            height: 20px;
            width:400px;
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
    <div> <p class="auto-style5">车队运费付款单</p>
        <div>
            <p>基本信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*编号<asp:TextBox ID="bh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">*付款日期
                        <asp:TextBox ID="fkrq" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">*付款类型<asp:DropDownList id="fklx" runat="server" Height="25px" Width ="284px">
                        <asp:ListItem>车队挂账付款</asp:ListItem>
                        <asp:ListItem>个人挂账付款</asp:ListItem>
                        </asp:DropDownList> </td>
                    

                </tr>
                <tr>
                    <td class="auto-style3">车队名称<asp:TextBox id="cdmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">收款人<asp:TextBox id="skr" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">
                        经办人<asp:TextBox id="jbr" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">已付及油卡<asp:TextBox id="yfjyk" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">已结算金额<asp:TextBox id="yjsje" runat="server" Height="16px" Width ="284px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">
                        未结算金额<asp:TextBox id="wjsje" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">付款账号<asp:TextBox id="fkzh" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">付款开户行<asp:TextBox id="fkkhh" runat="server" Height="16px" Width ="284px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">
                        付款账户<asp:TextBox id="fkzh2" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">收款账号<asp:TextBox id="skzh" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">收款开户行<asp:TextBox id="skkhh" runat="server" Height="16px" Width ="284px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">
                        收款账户<asp:TextBox id="skzh2" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">付款金额(小写)<asp:TextBox id="fkjexx" runat="server" Height="16px" Width ="268px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">付款金额(大写)<asp:TextBox id="fkjedx" runat="server" Height="16px" Width ="268px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">
                        结算方式<asp:TextBox id="jsfs" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style5" colspan="3">备注<asp:TextBox id="bz" runat="server" Height="16px" Width ="1100px"></asp:TextBox> 
                    </td>
                </tr>
            </table>            
        </div>


        <p class="auto-style5">
                <asp:Button ID="submit" text="保存" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp
                <asp:Button ID="refresh" text="重填" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp
            <%--<asp:Button ID="close" text="关闭" runat ="server" width="90px" OnClick="submit_Click" BorderStyle="Groove" BackColor="Aqua"></asp:Button>--%>
                </p> 
        </div>
    </form>
</body>
</html>
