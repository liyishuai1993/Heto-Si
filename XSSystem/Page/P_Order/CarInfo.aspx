<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarInfo.aspx.cs" Inherits="XSSystem.Page.P_Order.CarInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>车辆信息</title>
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
            height:20px;
            width:1200px;
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
    <div> <p class="auto-style5">车辆信息</p>
        <div>
            <p>基本信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*档案编号<asp:TextBox ID="dabh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">*建档时间
                        <asp:TextBox ID="jdsj" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">*车号<asp:TextBox id="ch" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    

                </tr>
                <tr>
                    <td class="auto-style3">所属车队<asp:TextBox id="sscd" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">车主姓名<asp:TextBox id="czmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">
                        车主手机<asp:TextBox id="czsj" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">车载电话<asp:TextBox id="czdh" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">住址<asp:TextBox id="zz" runat="server" Height="16px" Width ="284px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">
                        身份证号<asp:TextBox id="sfzh" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">车型<asp:DropDownList id="cx" runat="server" Height="25px" Width ="284px" CssClass="auto-style4"></asp:DropDownList> </td>
                    <td class="auto-style3">发动机号<asp:TextBox id="fdjh" runat="server" Height="25px" Width ="284px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">
                        行驶证号<asp:TextBox id="xszh" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">运输许可证号<asp:TextBox id="ysxkzh" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">产权证号<asp:TextBox id="cqzh" runat="server" Height="16px" Width ="284px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">
                        车载终端编号<asp:TextBox id="czzdbh" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">保单号<asp:TextBox id="bdh" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">车辆购置时间<asp:TextBox id="clgzsj" runat="server" Height="16px" Width ="284px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">
                        是否自购车<asp:DropDownList id="sfzgc" runat="server" Height="25px" Width ="284px">
                            <asp:ListItem>是</asp:ListItem>
                            <asp:ListItem>否</asp:ListItem>
                        </asp:DropDownList>  
                   </td> 
                </tr>
            </table>            
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
