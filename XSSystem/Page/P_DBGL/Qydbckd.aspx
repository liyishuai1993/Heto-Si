<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Qydbckd.aspx.cs" Inherits="XSSystem.Page.P_Order.Qydbckd" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>汽运调拨出库单</title>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <script src="../../js/FormStyle.js"></script>
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
    text-align: center;
    border-style: none;
    width: 1200px; font-family: 宋体, Arial, Helvetica, sans-serif; line-height: normal; background-color: #33CCFF;
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
    <script type="text/javascript">
        function FormCkdCheck() {
            document.getElementById("ckjz").value = (document.getElementById("ckmz").value - document.getElementById("ckpz").value).toFixed(3);
            document.getElementById("dbje").value = (document.getElementById("ckjz").value * document.getElementById("dcmj").value).toFixed(2);
        }

        function FormHdCheck() {
            document.getElementById("yfkkbz").value = document.getElementById("dcmj").value;
            document.getElementById("rkjz").value = (document.getElementById("rkmz").value - document.getElementById("rkpz").value).toFixed(3);
            if (document.getElementById("IsCal").value == true)
            {
                document.getElementById("yslhbz").value = (document.getElementById("ckjz").value * document.getElementById("percent").value).toFixed(3);
            }
            document.getElementById("ksds").value = Math.abs(document.getElementById("ckjz").value - document.getElementById("rkjz").value);
            document.getElementById("yyds").value = document.getElementById("rkjz").value - document.getElementById("ckjz2").value;
            document.getElementById("yfkkds").value = document.getElementById("ksds").value - document.getElementById("yslhbz").value;
            document.getElementById("yfkkje").value = (document.getElementById("yfkkbz").value * document.getElementById("yfkkds").value).toFixed(2);
            var temp = document.getElementById("ckjz").value - document.getElementById("rkjz");
            document.getElementById("yfjsdw").value = temp > 0 ? document.getElementById("rkjz"): document.getElementById("ckjz").value;

            document.getElementById("yfyf").value = (document.getElementById("yfjsdw").value * document.getElementById("yj").value - document.getElementById("yfkkje").value).toFixed(2);
            document.getElementById("jsyf").value = (document.getElementById("yfyf").value - document.getElementById("yfyk").value - document.getElementById("fykk").value).toFixed(2);
            document.getElementById("drje").value = (document.getElementById("ckjz").value * document.getElementById("dcmj").value+document.getElementById("yfyf").value).toFixed(2);
            document.getElementById("drmj").value = (document.getElementById("drje").value / document.getElementById("rkjz").value).toFixed(2);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div> <p class="auto-style5">汽运调拨出库单</p>
        <div>
            <telerik:RadScriptManager runat="server" ID="RadScriptManager1"/>
            <p>出库信息</p>
            <table border="0" aria-haspopup="False" class="auto-style1">
                <tr>
                    <td class="auto-style3"><span>编号</span><asp:TextBox ID="bh" runat="server" Height="16px" Width="500px" valued="must1" name="编号"></asp:TextBox></td>
                    <td class="auto-style3"><span>出库磅单号</span><asp:TextBox id="ckbdh" runat="server" name="出库磅单号" Height="16px" Width ="500px" valued="must1"></asp:TextBox> </td>                                    
                </tr>
                <tr>
                    <td class="auto-style3"><span>装车时间</span><asp:TextBox ID="zcsj" runat="server" name="装车时间" Text="" onClick="WdatePicker()" Width="500px" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">公司名称<telerik:RadComboBox RenderMode="Lightweight" ID="tk_gsmc"  runat="server" Width="500px" Height="200px"
  EmptyMessage="请输入供方名称"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="供方名称" valued="must1" 
   HighlightTemplatedItems="true"/></td>
                </tr>
                <tr>
                    <td class="auto-style3">发煤煤场<telerik:RadComboBox RenderMode="Lightweight" ID="tk_fmmc"  runat="server" Width="500px" Height="200px"
  EmptyMessage="请输入发煤煤场"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="发煤煤场" valued="must1" 
   HighlightTemplatedItems="true"/></td>
                    <td class="auto-style3"><span>车号</span><asp:TextBox id="ch" runat="server" name="车号" Height="16px" Width ="500px" CssClass="auto-style4" valued="must1"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">驾驶员<asp:TextBox id="jsy" runat="server" Height="16px" Width ="500px" CssClass="auto-style4" ></asp:TextBox> </td>
                    <td class="auto-style3">联系电话<asp:TextBox id="lxdh" runat="server" Height="16px" Width ="500px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">物料名称<telerik:RadComboBox RenderMode="Lightweight" ID="tk_wlmc"  runat="server" Width="500px" Height="200px"
  EmptyMessage="请输入物料名称"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="物料名称" valued="must1" 
   HighlightTemplatedItems="true"/></td>
                    
                    <td class="auto-style3"><span>出库皮重</span><asp:TextBox id="ckpz" cal="must2" name="出库皮重" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>

                </tr>
                <tr>
                    <td class="auto-style3"><span>出库毛重</span><asp:TextBox id="ckmz" cal="must2" name="出库毛重" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">#出库净重<asp:TextBox id="ckjz" name="出库净重" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"><span>调出煤价</span><asp:TextBox id="dcmj" valued="must1" cal="must2" name="调出煤价" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">#调拨金额<asp:TextBox id="dbje" OnFocus="FormCkdCheck()" name="调拨金额" valued="must1" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3"><span>运价</span><asp:TextBox id="yj" OnBlur="FormCkdCheck()" runat="server" cal="must1" name="运价" Height="16px" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3"><span>已付油卡</span><asp:TextBox id="yfyk" cal="must1" runat="server" name="已付油卡" Height="16px" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">付卡账户<telerik:RadComboBox RenderMode="Lightweight" ID="tk_fkzh"  runat="server" Width="500px" Height="200px" EmptyMessage="请输入支付账户" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains"
                        HighlightTemplatedItems="true" />
                    </td>
                    <td class="auto-style3"></td>
                </tr>

            </table>
        </div>

        <div>
            <p>回单信息</p>
            <table border="0" aria-haspopup="False" class="auto-style1">
                <tr>
                    <td class="auto-style3"><span>入库磅单号</span><asp:TextBox ID="rkbdh" runat="server" name="入库磅单号" Height="16px" Width="500px" valued="must2" ></asp:TextBox></td>
                    <td class="auto-style3"><span>入库时间</span><asp:TextBox id="rksj" runat="server" name="入库时间"  onClick="WdatePicker()" Width="500px" valued="must2"></asp:TextBox> </td>                                    
                </tr>
                <tr>
                    <td class="auto-style3"><span>收煤煤场</span><telerik:RadComboBox RenderMode="Lightweight" ID="tk_smmc"  runat="server" Width="500px" Height="200px"
  EmptyMessage="请输入收煤煤场"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="收煤煤场" valued="must2" 
   HighlightTemplatedItems="true"/></td>
                    <td class="auto-style3"><span>入库皮重</span><asp:TextBox id="rkpz" cal="must1" runat="server" name="入库皮重" Height="16px" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> </td>

                </tr>
                <tr>
                    <td class="auto-style3"><span>入库毛重</span><asp:TextBox id="rkmz" cal="must1" runat="server" name="入库毛重" Height="16px" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox></td>

                    <td class="auto-style3">#入库净重<asp:TextBox id="rkjz" runat="server" name="入库净重" Height="16px" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">#亏损吨数<asp:TextBox id="ksds" name="亏损吨数" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> </td>
                    <td class="auto-style3">#盈余吨数<asp:TextBox id="yyds" name="盈余吨数" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"><span>运输路耗标准(吨)</span><asp:TextBox id="yslhbz"  name="运输路耗标准" runat="server" Height="16px" Width ="355px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> 
                        *<asp:TextBox id="percent" ToolTip="百分比,请按小数输入" runat="server" Height="16px" Width ="60px" OnKeyPress="isnum()"   OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        <asp:CheckBox runat="server" ToolTip="勾选按入库净重百分比计算" id="IsCal" Height="20px" width="20px"/>
                    </td>
                    <td class="auto-style3">#运费扣款标准(元/吨)<asp:TextBox id="yfkkbz"  name="运费扣款标准" runat="server" Height="16px" Width ="430px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">#运费扣亏吨数<asp:TextBox id="yfkkds" name="运费扣亏吨数" runat="server" Height="16px" Width ="485px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> </td>
                    <td class="auto-style3">#运费扣款金额<asp:TextBox id="yfkkje" name="运费扣款金额" valued="must2" runat="server" Height="16px" Width ="485px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"><span>运费结算吨位</span><asp:TextBox id="yfjsdw" runat="server" name="运费结算吨位" Height="16px" Width ="483px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> </td>
                    <td class="auto-style3">#应付运费<asp:TextBox id="yfyf" runat="server" name="应付运费" Height="16px" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3"><span>费用扣款(手续费、卸车费)</span><asp:TextBox id="fykk" OnBlur="FormHdCheck()"  name="应付运费" valued="must2" cal="must1" runat="server" Height="16px" Width ="370px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td> 
                    <td class="auto-style3">#结算运费<asp:TextBox id="jsyf" runat="server" name="结算运费" valued="must2" Height="16px" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" ></asp:TextBox> </td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">#调入金额<asp:TextBox id="drje" nanme="调入金额" runat="server" Height="16px" valued="must2" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td>
                    <td class="auto-style3">#调入煤价<asp:TextBox id="drmj" OnFocus="FormHdCheck()"  name="调入煤价" runat="server" Height="16px" valued="must2" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">审核状态<asp:TextBox id="shzt" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">运费结算状态<asp:TextBox id="yfjszt" runat="server" Height="16px" Width ="487px" CssClass="auto-style4"></asp:TextBox></td>
                </tr>

            </table>     
        </div>
        


        <p class="auto-style5">
            <asp:Button ID="Button2" text="计算出库单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="Button2_Click"></asp:Button>&nbsp
            <asp:Button ID="Button1" text="计算回单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="Button1_Click"></asp:Button>&nbsp
                <asp:Button ID="add" text="保存出库单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp
                <asp:Button ID="updateCkd" text="修改出库单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="updateCkd_Click"></asp:Button>&nbsp
             <asp:Button ID="Button4" text="保存回单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click2"></asp:Button>&nbsp
             <asp:Button ID="updateHd" text="修改回单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="updateHd_Click"></asp:Button>&nbsp
                <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="close_Click"></asp:Button>
            
                </p> 
        </div>
    </form>
</body>
</html>
