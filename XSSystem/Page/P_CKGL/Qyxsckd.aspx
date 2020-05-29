<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Qyxsckd.aspx.cs" Inherits="XSSystem.Page.P_Order.Qyxsckd" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>汽运销售单</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
    <script src="../../js/FormStyle.js"></script>
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
            text-align: center;
            border-style: none;
            width: 1200px;
            font-family: 宋体, Arial, Helvetica, sans-serif;
            line-height: normal;
            background-color: #33CCFF;
        }

        .auto-style3 {
            height: 20px;
            width: 600px;
            text-align: right;
        }

        .Wdate {
        }

        .auto-style4 {
            text-align: left;
        }

        .auto-style5 {
            height: auto;
            width: auto;
            text-align: center;
        }
    </style>

    <script type="text/javascript">
        function FormCkdCheck() {
            document.getElementById("ckjz1").value = (document.getElementById("ckmz").value - document.getElementById("ckpz").value).toFixed(3);
            document.getElementById("ckjz2").value = (document.getElementById("ckjz1").value - document.getElementById("jbds").value).toFixed(3);
            document.getElementById("hkgsje").value = (document.getElementById("ckjz2").value * document.getElementById("mj").value).toFixed(2);
        }

        function FormHdCheck() {
            document.getElementById("rkjz").value = (document.getElementById("rkmz").value - document.getElementById("rkpz").value).toFixed(3);
            if (document.getElementById("IsCal").value == true) {
                document.getElementById("yfhllh").value = (document.getElementById("ckjz2").value * document.getElementById("percent").value).toFixed(3);
            }
            document.getElementById("ksds").value = Math.abs(document.getElementById("ckjz2").value - document.getElementById("rkjz").value).toFixed(3);
            var yyds = (document.getElementById("rkjz").value - document.getElementById("ckjz2").value).toFixed(3);
            document.getElementById("yyds").value = yyds;
            if (yyds >= 0) {
                document.getElementById("yfkkds").value = 0;
                document.getElementById("yfkkje").value = 0;
            } else {
                document.getElementById("yfkkds").value = document.getElementById("ksds").value - document.getElementById("yfhllh").value;
                document.getElementById("yfkkje").value = (document.getElementById("yflhbz").value * document.getElementById("yfkkds").value).toFixed(2);
            }

            var temp = document.getElementById("ckjz2").value - document.getElementById("rkjz").value;
            document.getElementById("yfjsdw").value = temp > 0 ? document.getElementById("rkjz").value : document.getElementById("ckjz2").value;

            document.getElementById("yfyf").value = (document.getElementById("yfjsdw").value * document.getElementById("yj").value - document.getElementById("yfkkje").value).toFixed(2);
            document.getElementById("jsyf").value = (document.getElementById("yfyf").value - document.getElementById("yfyk").value - document.getElementById("fykk").value).toFixed(2);
            document.getElementById("hkjsdw").value = document.getElementById("rkjz").value - document.getElementById("kd").value;
            document.getElementById("jshk").value = (document.getElementById("hkjsdw").value * document.getElementById("mj").value).toFixed(2);
            document.getElementById("tcje").value = (document.getElementById("hkjsdw").value * document.getElementById("tcbz").value).toFixed(2);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p class="auto-style5">汽运销售出库单</p>
            <div>
                <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />
                <p>出库信息(出库单)</p>
                <table border="0" aria-haspopup="False" class="auto-style1">
                    <tr>
                        <td class="auto-style3"><span>出库磅单号</span><asp:TextBox ID="ckbdh" runat="server" Height="16px" Width="500px" name="出库磅单号" valued="must1"></asp:TextBox></td>
                        <td class="auto-style3"><span>合同编号</span><asp:TextBox ID="htbh" runat="server" Height="16px" Width="500px" valued="must1" name="合同编号"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>装车时间</span><asp:TextBox ID="zcsj" runat="server" Text="" onClick="WdatePicker()" Width="500px" valued="must1" name="装车时间"></asp:TextBox>
                        </td>
                        <td class="auto-style3">发煤煤场<telerik:RadComboBox RenderMode="Lightweight" ID="tk_fmmc" runat="server" Width="500px" Height="200px"
                            EmptyMessage="请输入发煤煤场" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="发煤煤场" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">供方<telerik:RadComboBox RenderMode="Lightweight" ID="tk_gf" runat="server" Width="500px" Height="200px"
                            EmptyMessage="请输入供方名称" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="供方名称" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                        <td class="auto-style3">需方<telerik:RadComboBox RenderMode="Lightweight" ID="tk_xf" runat="server" Width="500px" Height="200px"
                            EmptyMessage="请输入需方名称" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="需方名称" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>车号</span><asp:TextBox name="车号" ID="ch" runat="server" Height="16px" Width="500px" CssClass="auto-style4" valued="must1"></asp:TextBox>
                        </td>
                        <td class="auto-style3">驾驶员<asp:TextBox ID="jsy" runat="server" Height="16px" Width="500px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">联系电话<asp:TextBox ID="lxdh" runat="server" Height="16px" Width="500px" CssClass="auto-style4"></asp:TextBox>
                        </td>
                        <td class="auto-style3">物料名称<telerik:RadComboBox RenderMode="Lightweight" ID="tk_wlmc" runat="server" Width="500px" Height="200px"
                            EmptyMessage="请输入物料名称" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="物料名称" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>出库皮重</span><asp:TextBox ID="ckpz" cal="must1" runat="server" Height="16px" Width="500px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="出库皮重" valued="must1"></asp:TextBox>
                        </td>
                        <td class="auto-style3"><span>出库毛重</span><asp:TextBox ID="ckmz" cal="must1" runat="server" Height="16px" Width="500px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="出库毛重" valued="must1"></asp:TextBox>
                        </td>

                    </tr>
                    <tr>
                        <td class="auto-style3"><span>加磅吨数</span><asp:TextBox ID="jbds" runat="server" cal="must1" Height="16px" Width="500px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="加磅吨数" valued="must1"></asp:TextBox>
                        </td>
                        <td class="auto-style3">#出库净重1<asp:TextBox ID="ckjz1" runat="server" Height="16px" Width="500px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="出库净重1" valued="must1"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">#出库净重2<asp:TextBox ID="ckjz2" runat="server" Height="16px" Width="500px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="出库净重2" valued="must1"></asp:TextBox>
                        </td>
                        <td class="auto-style3"><span>煤价</span><asp:TextBox ID="mj" cal="must1" runat="server" Height="16px" Width="500px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="煤价" valued="must1"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">#货款估算金额<asp:TextBox ID="hkgsje" OnFocus="FormCkdCheck()" runat="server" Height="16px" Width="440px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="货款估算金额" valued="must1"></asp:TextBox>
                            <asp:CheckBox runat="server" ToolTip="以出库单数据填充客户回单" AutoPostBack="true" ID="CheckBox_hd" Height="20px" Width="20px" OnCheckedChanged="CheckBox1_CheckedChanged" />
                        </td>
                        <td class="auto-style3"><span>已付油卡</span><asp:TextBox ID="yfyk" OnBlur="FormCkdCheck()" cal="must1" runat="server" Height="16px" Width="500px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="已付油卡" valued="must1"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>运价</span><asp:TextBox ID="yj" cal="must1" OnBlur="FormCkdCheck()" runat="server" Height="16px" Width="500px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="运价" valued="must1"></asp:TextBox></td>
                        <td class="auto-style3">付卡账户<telerik:RadComboBox RenderMode="Lightweight" ID="tk_fkzh" runat="server" Width="500px" Height="200px" EmptyMessage="请输入支付账户" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains"
                            HighlightTemplatedItems="true" />
                        </td>

                    </tr>

                </table>
            </div>

            <div>
                <p>入库信息(客户回单)</p>
                <table border="0" aria-haspopup="False" class="auto-style1">
                    <tr>
                        <td class="auto-style3"><span>入库磅单号</span><asp:TextBox ID="rkbdh" runat="server" Height="16px" Width="284px" name="入库磅单号" valued="must2"></asp:TextBox></td>
                        <td class="auto-style3"><span>入库时间</span>
                            <asp:TextBox ID="rksj" runat="server" Text="" onClick="WdatePicker()" Width="284px" name="入库时间" valued="must2"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>入库皮重</span><asp:TextBox ID="rkpz" cal="must2" name="入库皮重" runat="server" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                        </td>
                        <td class="auto-style3"><span>入库毛重</span><asp:TextBox ID="rkmz" cal="must2" name="入库毛重" runat="server" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                        </td>
                        <td class="auto-style3">#入库净重<asp:TextBox ID="rkjz" name="入库净重" runat="server" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">#亏损吨数<asp:TextBox ID="ksds" runat="server" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="亏损吨数" valued="must2"></asp:TextBox>
                        </td>
                        <td class="auto-style3">#盈余吨数<asp:TextBox ID="yyds" runat="server" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="盈余吨数" valued="must2"></asp:TextBox></td>
                        <td class="auto-style3"><span>扣吨(扣杂)</span><asp:TextBox ID="kd" cal="must2" name="扣吨" runat="server" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>运费合理路耗(吨)</span><asp:TextBox ID="yfhllh" name="运费合理路耗" runat="server" Height="16px" Width="150px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                            *<asp:TextBox ID="percent" runat="server" Height="16px" Width="60px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                            <asp:CheckBox runat="server" ToolTip="勾选按入库净重百分比计算" ID="IsCal" Height="20px" Width="20px" />
                        </td>
                        <td class="auto-style3"><span>运费扣款标准(元/吨)</span><asp:TextBox ID="yflhbz" cal="must2" valued="must2" name="运费扣款标准" runat="server" Height="16px" Width="233px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        </td>
                        <td class="auto-style3">#运费扣亏吨数<asp:TextBox ID="yfkkds" name="运费扣亏吨数" valued="must2" runat="server" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td>

                    </tr>
                    <tr>
                        <td class="auto-style3">#运费扣款金额<asp:TextBox ID="yfkkje" runat="server" valued="must2" name="运费扣款金额" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        </td>
                        <td class="auto-style3">#运费结算吨位<asp:TextBox ID="yfjsdw" runat="server" name="运费结算吨位" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                        </td>
                        <td class="auto-style3">#应付运费<asp:TextBox ID="yfyf" runat="server" name="应付运费" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">费用扣款(手续费、卸车费)<asp:TextBox ID="fykk" runat="server" Height="16px" valued="must2" cal="must2" name="费用扣款" Width="188px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td>
                        <td class="auto-style3">#结算运费<asp:TextBox ID="jsyf" name="结算运费" runat="server" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                        </td>
                        <td class="auto-style3">#货款结算吨位<asp:TextBox ID="hkjsdw" name="货款结算吨位" runat="server" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox></td>

                    </tr>

                    <tr>
                        <td class="auto-style3">#结算货款<asp:TextBox ID="jshk" name="结算货款" runat="server" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox></td>
                        <td class="auto-style3"><span>提成标准</span><asp:TextBox ID="tcbz" valued="must2" OnBlur="FormHdCheck()" cal="must2" name="提成标准" runat="server" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        </td>
                        <td class="auto-style3">#提成金额<asp:TextBox ID="tcje" OnFocus="FormHdCheck()" runat="server" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox></td>

                    </tr>

                    <tr>
                        <td class="auto-style3">业务员<asp:TextBox ID="ywy" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                        <td class="auto-style3">运费结算状态<asp:DropDownList ID="yfjszt_droplist" runat="server" Height="25px" Width="284px" CssClass="auto-style4">
                            <asp:ListItem>已结算</asp:ListItem>
                            <asp:ListItem>未结算</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                        <td class="auto-style3">审核状态<asp:DropDownList ID="shzt_droplist" runat="server" Height="25px" Width="284px">
                            <asp:ListItem>已审核</asp:ListItem>
                            <asp:ListItem>未审核</asp:ListItem>
                        </asp:DropDownList></td>

                    </tr>

                </table>
            </div>


            <p class="auto-style5">
                <%--<asp:Button ID="Button1" text="计算出库单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="Button1_Click"></asp:Button>--%>&nbsp
            <%--<asp:Button ID="Button2" text="计算回单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="Button2_Click"></asp:Button>--%>&nbsp
                <asp:Button ID="add" Text="保存出库单" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp
            <asp:Button ID="updateCkd" Text="修改出库单" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="updateCkd_Click"></asp:Button>&nbsp
            <asp:Button ID="add2" Text="保存回单" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="submit2_Click"></asp:Button>&nbsp         
            <asp:Button ID="updateHd" Text="修改回单" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="updateHd_Click"></asp:Button>&nbsp 
                <asp:Button ID="close" Text="关闭" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="close_Click"></asp:Button>
            </p>
        </div>
    </form>
</body>
</html>
