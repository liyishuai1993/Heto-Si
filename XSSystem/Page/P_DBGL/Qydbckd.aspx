﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Qydbckd.aspx.cs" Inherits="XSSystem.Page.P_Order.Qydbckd" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>汽运调拨出库单</title>
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
    <div> <p class="auto-style5">汽运调拨出库单</p>
        <div>
            <p>出库信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*编号<asp:TextBox ID="bh" runat="server" Height="16px" Width="500px"></asp:TextBox></td>
                    <td class="auto-style3">出库磅单号<asp:TextBox id="ckbdh" runat="server" Height="16px" Width ="500px"></asp:TextBox> </td>                                    
                </tr>
                <tr>
                    <td class="auto-style3">*装车时间<asp:TextBox ID="zcsj" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox> </td>
                    <td class="auto-style3">公司名称<asp:TextBox id="gsmc" runat="server" Height="16px" Width ="500px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">*发煤煤场<asp:TextBox id="fmmc" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">*车号<asp:TextBox id="ch" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">驾驶员<asp:TextBox id="jsy" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">联系电话<asp:TextBox id="lxdh" runat="server" Height="16px" Width ="500px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">*物料名称<asp:TextBox id="wlmc" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">出库毛重<asp:TextBox id="ckmz" runat="server" Height="16px" Width ="500px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">出库皮重<asp:TextBox id="ckpz" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">*出库净重<asp:TextBox id="ckjz" runat="server" Height="16px" Width ="500px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">*调出煤价<asp:TextBox id="dcmj" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">调拨金额<asp:TextBox id="dbje" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">*运价<asp:TextBox id="yj" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">已付油卡<asp:TextBox id="yfyk" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">付卡账户<asp:TextBox id="fkzh" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3"></td>
                </tr>

            </table>
        </div>

        <div>
            <p>回单信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">入库磅单号<asp:TextBox ID="rkbdh" runat="server" Height="16px" Width="500px"></asp:TextBox></td>
                    <td class="auto-style3">入库时间<asp:TextBox id="rksj" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox> </td>                                    
                </tr>
                <tr>
                    <td class="auto-style3">*收煤煤场<asp:TextBox id="smmc" runat="server" Height="16px" Width ="500px"></asp:TextBox> </td>
                    <td class="auto-style3">入库毛重<asp:TextBox id="rkmz" runat="server" Height="16px" Width ="500px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">入库皮重<asp:TextBox id="rkpz" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">*入库净重<asp:TextBox id="rkjz" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">亏损吨数<asp:TextBox id="ksds" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">盈余吨数<asp:TextBox id="yyds" runat="server" Height="16px" Width ="500px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">运输路耗标准(吨)<asp:TextBox id="yslhbz" runat="server" Height="16px" Width ="455px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">运费扣款标准(元/吨)<asp:TextBox id="yfkkbz" runat="server" Height="16px" Width ="430px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">运费扣亏吨数<asp:TextBox id="yfkkds" runat="server" Height="16px" Width ="485px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">运费扣款金额<asp:TextBox id="yfkkje" runat="server" Height="16px" Width ="485px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">运费结算吨位<asp:TextBox id="yfjsdw" runat="server" Height="16px" Width ="483px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">应付运费<asp:TextBox id="yfyf" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">费用扣款(手续费、卸车费)<asp:TextBox id="fykk" runat="server" Height="16px" Width ="370px"></asp:TextBox></td> 
                    <td class="auto-style3">结算运费<asp:TextBox id="jsyf" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">调入金额<asp:TextBox id="drje" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox></td>
                    <td class="auto-style3">调入煤价<asp:TextBox id="drmj" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">审核状态<asp:TextBox id="shzt" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">运费结算状态<asp:TextBox id="yfjszt" runat="server" Height="16px" Width ="487px" CssClass="auto-style4"></asp:TextBox></td>
                </tr>

            </table>     
        </div>
        


        <p class="auto-style5">
                <asp:Button ID="submit" text="保存" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp
             <asp:Button ID="submit2" text="保存回单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click2"></asp:Button>&nbsp
            <asp:Button ID="Button1" text="重填" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp
                <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>
