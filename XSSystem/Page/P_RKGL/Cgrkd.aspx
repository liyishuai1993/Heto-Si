<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cgrkd.aspx.cs" Inherits="XSSystem.Page.P_Order.Cgrkd" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>采购入库单(合并页)</title>
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
        .auto-style5 {
            height:auto;
            width:auto;
            text-align:center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div> <p class="auto-style5">采购入库单(合并页)</p>
        <div>
            <p>基本信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1600px">
                <tr>
                    <td class="auto-style3">*合同号<asp:TextBox ID="hth" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">煤矿名称
                        <asp:TextBox ID="mkmc" runat="server"  Height="16px" Width="284px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">供方<asp:TextBox id="gf" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">需方<asp:TextBox id="xf" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">物料名称<asp:TextBox id="wlmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">煤价<asp:TextBox id="mj" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">运输合同编号<asp:TextBox id="yshtbh" runat="server" Height="16px" Width ="284px"></asp:TextBox>  </td> 
                    <td class="auto-style3">承运车队<asp:TextBox id="cycd" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                </tr>
            </table>            
        </div>

         <div>
            <p>装车信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1600px" >
                <tr>
                    <td class="auto-style3">装车磅单号<asp:TextBox ID="zcbdh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">提煤单号<asp:TextBox ID="tmdh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">装车日期<asp:TextBox ID="zcrq" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">车号<asp:TextBox id="ch" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>                   
                </tr>
                <tr>
                    <td class="auto-style3">装车毛重<asp:TextBox id="zcmz" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">装车皮重<asp:TextBox id="zcpz" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">装车净重<asp:TextBox id="zcjz" runat="server" Height="16px" Width ="284px"></asp:TextBox></td> 
                    <td class="auto-style3">结算煤款<asp:TextBox id="jsmk" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                </tr>
            </table>            
        </div>

        <div>
            <p>入场信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1600px" >
                <tr class="auto-style3"><td class="auto-style3">装车日期<asp:TextBox ID="TextBox1" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox></td></tr>
                <tr>
                    <td class="auto-style3">入库磅单号<asp:TextBox ID="rkbdh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">入库煤场<asp:TextBox ID="rkmc" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">入库毛重<asp:TextBox ID="rkmz" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">入库皮重<asp:TextBox id="rkpz" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>                   
                </tr>
                <tr>
                    <td class="auto-style3">入库净重<asp:TextBox id="rkjz" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">亏损吨数<asp:TextBox id="ksds" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">盈余吨数<asp:TextBox id="yyds" runat="server" Height="16px" Width ="284px"></asp:TextBox></td> 
                    <td class="auto-style3">运输路耗标准(吨)<asp:TextBox id="yslhbz" runat="server" Height="16px" Width ="253px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">扣款标准（元/吨）<asp:TextBox id="kkbz" runat="server" Height="16px" Width ="248px"></asp:TextBox> </td>
                    <td class="auto-style3">扣亏吨数<asp:TextBox id="kkdz" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">扣亏金额<asp:TextBox id="kkje" runat="server" Height="16px" Width ="284px"></asp:TextBox></td> 
                    <td class="auto-style3">运费结算吨位<asp:TextBox id="yfjsdw" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">运价<asp:TextBox id="yj" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">应付运费<asp:TextBox id="yfyf" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">已付油卡<asp:TextBox id="yfyk" runat="server" Height="16px" Width ="284px"></asp:TextBox></td> 
                    <td class="auto-style3">付卡账户<asp:TextBox id="fkzh" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">结算运费<asp:TextBox id="jsyf" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">支付账户<asp:TextBox id="zfzh" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">审核状态<asp:TextBox id="shzt" runat="server" Height="16px" Width ="284px"></asp:TextBox></td> 
                    <td class="auto-style3">运费结算状态<asp:TextBox id="yfjszt" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                </tr>
            </table>            
        </div>


        <p class="auto-style5">
                <asp:Button ID="submit" text="保存并关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp
                &nbsp
            <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>