<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Qydbckd.aspx.cs" Inherits="XSSystem.Page.P_Order.Qydbckd" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>汽运调拨出库单</title>
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
</head>
<body>
    <form id="form1" runat="server">
    <div> <p class="auto-style5">汽运调拨出库单</p>
        <div>
            <telerik:RadScriptManager runat="server" ID="RadScriptManager1"/>
            <p>出库信息</p>
            <table border="0" aria-haspopup="False" class="auto-style1">
                <tr>
                    <td class="auto-style3">*编号<asp:TextBox ID="bh" runat="server" Height="16px" Width="500px"></asp:TextBox></td>
                    <td class="auto-style3">出库磅单号<asp:TextBox id="ckbdh" runat="server" name="出库磅单号" Height="16px" Width ="500px" valued="must1"></asp:TextBox> </td>                                    
                </tr>
                <tr>
                    <td class="auto-style3">*装车时间<asp:TextBox ID="zcsj" runat="server" name="装车时间" Text="" onClick="WdatePicker()" Width="500px" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">公司名称<telerik:RadComboBox RenderMode="Lightweight" ID="tk_gsmc" AutoPostBack="True" runat="server" Width="500px" Height="200px"
  EmptyMessage="请输入供方名称"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="供方名称" valued="must1" 
   HighlightTemplatedItems="true"/></td>
                </tr>
                <tr>
                    <td class="auto-style3">*发煤煤场<telerik:RadComboBox RenderMode="Lightweight" ID="tk_fmmc" AutoPostBack="True" runat="server" Width="500px" Height="200px"
  EmptyMessage="请输入发煤煤场"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="发煤煤场" valued="must1" 
   HighlightTemplatedItems="true"/></td>
                    <td class="auto-style3">*车号<asp:TextBox id="ch" runat="server" name="车号" Height="16px" Width ="500px" CssClass="auto-style4" valued="must1"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">驾驶员<asp:TextBox id="jsy" runat="server" Height="16px" Width ="500px" CssClass="auto-style4" ></asp:TextBox> </td>
                    <td class="auto-style3">联系电话<asp:TextBox id="lxdh" runat="server" Height="16px" Width ="500px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">*物料名称<asp:TextBox id="wlmc" name="物料名称" runat="server" Height="16px" Width ="500px" CssClass="auto-style4" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">出库毛重<asp:TextBox id="ckmz" cal="must2" name="出库毛重" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">出库皮重<asp:TextBox id="ckpz" cal="must2" name="出库皮重" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">#出库净重<asp:TextBox id="ckjz" name="出库净重" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">*调出煤价<asp:TextBox id="dcmj" cal="must2" name="调出煤价" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">#调拨金额<asp:TextBox id="dbje" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">*运价<asp:TextBox id="yj" runat="server" cal="must1" name="运价" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">已付油卡<asp:TextBox id="yfyk" cal="must1" runat="server" name="已付油卡" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">付卡账户<asp:TextBox id="fkzh" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3"></td>
                </tr>

            </table>
        </div>

        <div>
            <p>回单信息</p>
            <table border="0" aria-haspopup="False" class="auto-style1">
                <tr>
                    <td class="auto-style3">入库磅单号<asp:TextBox ID="rkbdh" runat="server" name="入库磅单号" Height="16px" Width="500px" valued="must1"></asp:TextBox></td>
                    <td class="auto-style3">入库时间<asp:TextBox id="rksj" runat="server" name="入库时间" Text="" onClick="WdatePicker()" Width="500px" valued="must1"></asp:TextBox> </td>                                    
                </tr>
                <tr>
                    <td class="auto-style3">*收煤煤场<telerik:RadComboBox RenderMode="Lightweight" ID="tk_smmc" AutoPostBack="True" runat="server" Width="500px" Height="200px"
  EmptyMessage="请输入收煤煤场"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="收煤煤场" valued="must1" 
   HighlightTemplatedItems="true"/></td>
                    <td class="auto-style3">入库毛重<asp:TextBox id="rkmz" cal="must1" runat="server" name="入库毛重" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">入库皮重<asp:TextBox id="rkpz" cal="must1" runat="server" name="入库皮重" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">#入库净重<asp:TextBox id="rkjz" runat="server" name="入库净重" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">#亏损吨数<asp:TextBox id="ksds" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">#盈余吨数<asp:TextBox id="yyds" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">运输路耗标准(吨)<asp:TextBox id="yslhbz" cal="must1" name="运输路耗标准" runat="server" Height="16px" Width ="455px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">运费扣款标准(元/吨)<asp:TextBox id="yfkkbz" cal="must1" name="运费扣款标准" runat="server" Height="16px" Width ="430px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">#运费扣亏吨数<asp:TextBox id="yfkkds" runat="server" Height="16px" Width ="485px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">#运费扣款金额<asp:TextBox id="yfkkje" runat="server" Height="16px" Width ="485px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">运费结算吨位<asp:TextBox id="yfjsdw" runat="server" name="运费结算吨位" Height="16px" Width ="483px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">#应付运费<asp:TextBox id="yfyf" runat="server" name="应付运费" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">费用扣款(手续费、卸车费)<asp:TextBox id="fykk" runat="server" Height="16px" Width ="370px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td> 
                    <td class="auto-style3">#结算运费<asp:TextBox id="jsyf" runat="server" name="结算运费" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">#调入金额<asp:TextBox id="drje" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td>
                    <td class="auto-style3">#调入煤价<asp:TextBox id="drmj" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    
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
                <asp:Button ID="submit" text="保存" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp
             <asp:Button ID="submit2" text="保存回单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click2"></asp:Button>&nbsp
            
                <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>
