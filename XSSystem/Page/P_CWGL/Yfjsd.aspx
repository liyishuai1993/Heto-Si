<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Yfjsd.aspx.cs" Inherits="XSSystem.Page.P_CWGL.Yfjsd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>运费结算单</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
    text-align: center;
    border-style: none;
        }
        .auto-style3 {
            height: 20px;
            text-align:center;
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
    <div> <p class="auto-style5">运费结算单</p>
        <div>
            <p>结算日期<asp:TextBox ID="jsrq" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                单号：<asp:TextBox ID="dh" runat="server" Height="16px" Width="284px"></asp:TextBox></p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="border-style: solid; width: 1200px" >
                <tr>
                    <td class="auto-style4" colspan="15">承运单位：<asp:TextBox id="gys0" runat="server" Height="16px" Width ="500px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3" rowspan="2">序号</td>
                    <td class="auto-style3" rowspan="2">硫单号</td>
                    <td class="auto-style3" rowspan="2">供应商</td>
                    <td class="auto-style3" rowspan="2">发货地</td>
                    <td class="auto-style3" rowspan="2">装车时间</td>
                    <td class="auto-style3" rowspan="2">收货单位</td>
                    <td class="auto-style3" rowspan="2">货物名称</td>
                    <td class="auto-style3" rowspan="2">车号</td>
                    <td class="auto-style3" rowspan="2">发货数量</td>
                    <td class="auto-style3" rowspan="2">收货数量</td>
                    <td class="auto-style3" rowspan="2">超操数量</td>
                    <td class="auto-style3">运费单价</td>
                    <td class="auto-style3" rowspan="2">应付运费</td>
                    <td class="auto-style3">扣减款项</td>
                    <td class="auto-style3" rowspan="2">实付运费</td>
                </tr>
                <tr>
                    <td class="auto-style3">(元/吨)</td>
                    <td class="auto-style3">超标扣款</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="3">合计：</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">抵扣金额：</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">其他扣款：</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">实付运费：</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">大写：</td>
                    <td class="auto-style3" colspan="3">&nbsp;</td>
                    <td class="auto-style3" colspan="2">付款方式</td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">付款开户行：</td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                    <td class="auto-style3">付款账户：</td>
                    <td class="auto-style3" colspan="3">&nbsp;</td>
                    <td class="auto-style3">付款账号：</td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                    <td class="auto-style3" colspan="2">附件张数：</td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">收款银行：</td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                    <td class="auto-style3">收款账户：</td>
                    <td class="auto-style3" colspan="3">&nbsp;</td>
                    <td class="auto-style3">卡号：</td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                    <td class="auto-style3" colspan="2">电话：</td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">备注：</td>
                    <td class="auto-style3" colspan="13">&nbsp;</td>
                </tr>
                             
            </table>     
            <p class="auto-style4">审批：<asp:TextBox ID="sp" runat="server" Height="16px" Width="150px"></asp:TextBox>
                复核：<asp:TextBox ID="fh" runat="server" Height="16px" Width="150px"></asp:TextBox>
                付款人：<asp:TextBox ID="skr" runat="server" Height="16px" Width="150px"></asp:TextBox>
                收款签名人<asp:TextBox ID="skqmr" runat="server" Height="16px" Width="150px"></asp:TextBox>

            </p>
        </div>
        


        <p class="auto-style5">
                <asp:Button ID="submit" text="保存" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp
                <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>

