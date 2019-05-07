﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cgrkd.aspx.cs" Inherits="XSSystem.Page.P_Order.Cgrkd" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>采购入库单(合并页)</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <script src="../../js/FormStyle.js"></script>
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
    text-align: center;
    border-style: none;
    width: 1290px; font-family: 宋体, Arial, Helvetica, sans-serif; line-height: normal; background-color: #33CCFF;
        }
        .auto-style3 {
            height: 20px;
            width:330px;
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
            <telerik:RadScriptManager runat="server" ID="RadScriptManager1"/>
            <p>基本信息</p>
            <table border="0" aria-haspopup="False" class="auto-style1">
                <tr>
                    <td class="auto-style3">*合同号<asp:TextBox ID="hth" valued="must1" name="合同号" runat="server" Height="16px" Width="200px"></asp:TextBox></td>
                    <td class="auto-style3">煤矿名称
                        <asp:TextBox ID="mkmc" runat="server"  name="煤矿名称" Height="16px" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">供方<telerik:RadComboBox RenderMode="Lightweight" ID="tk_gf" AutoPostBack="True" runat="server" Width="200px" Height="200px"
  EmptyMessage="请输入供方名称"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="供方名称" valued="must1" 
   HighlightTemplatedItems="true"/></td>
                    <td class="auto-style3">需方<telerik:RadComboBox RenderMode="Lightweight" ID="tk_xf" AutoPostBack="True" runat="server" Width="200px" Height="200px"
  EmptyMessage="请输入需方名称"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="需方名称" valued="must1" 
   HighlightTemplatedItems="true"/> </td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">物料名称
                 <telerik:RadComboBox RenderMode="Lightweight" ID="tk_wlmc" AutoPostBack="True" runat="server" Width="200px" Height="400px"
                    EmptyMessage="选择" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="物料名称" valued="must2"
                    HighlightTemplatedItems="true">
                </telerik:RadComboBox>
                        </td>
                    <td class="auto-style3">煤价<asp:TextBox id="mj" runat="server" Height="16px" cal="must1" name="煤价" Width ="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">运输合同编号<asp:TextBox id="yshtbh" runat="server" Height="16px" Width ="200px"></asp:TextBox>  </td> 
                    <td class="auto-style3">承运车队<asp:TextBox id="cycd" runat="server" Height="16px" Width ="200px"></asp:TextBox> </td>
                </tr>
            </table>            
        </div>

         <div>
            <p>装车信息</p>
            <table border="0" aria-haspopup="False" class="auto-style1"  >
                <tr>
                    <td class="auto-style3">装车磅单号<asp:TextBox ID="zcbdh" runat="server" Height="16px" Width="200px" valued="must1" name="装车磅单号"></asp:TextBox></td>
                    <td class="auto-style3">提煤单号<asp:TextBox ID="tmdh" runat="server" Height="16px" Width="200px" name="提煤单号"></asp:TextBox></td>
                    <td class="auto-style3">装车日期<asp:TextBox ID="zcrq" runat="server" Text="" onClick="WdatePicker()" Width="200px" valued="must1" name="装车日期"></asp:TextBox></td>
                    <td class="auto-style3">车号<asp:TextBox id="ch" runat="server" Height="16px" Width ="200px" valued="must1" name="车号"></asp:TextBox> </td>                   
                </tr>
                <tr>
                    <td class="auto-style3">装车皮重<asp:TextBox id="zcpz" runat="server" cal="must1" name="装车皮重" Height="16px" Width ="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">装车毛重<asp:TextBox id="zcmz" runat="server" cal="must1" name="装车毛重" Height="16px" Width ="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">#装车净重<asp:TextBox id="zcjz" runat="server"  Height="16px" Width ="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox></td> 
                    <td class="auto-style3">#结算煤款<asp:TextBox id="jsmk" runat="server"  Height="16px" Width ="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox></td>
                </tr>
            </table>            
        </div>

        <div>
            <p>入场信息</p>
            <table border="0" aria-haspopup="False" class="auto-style1" >
                <tr class="auto-style3"><td class="auto-style3">入库日期<asp:TextBox ID="rkrq" runat="server" name="入库日期" Text="" onClick="WdatePicker()" Width="200px" valued="must1"></asp:TextBox></td></tr>
                <tr>
                    <td class="auto-style3">入库磅单号<asp:TextBox ID="rkbdh" runat="server" Height="16px" Width="200px"  name="入库磅单号"  valued="must1"></asp:TextBox></td>
                    <td class="auto-style3">入库煤场<asp:TextBox ID="rkmc" runat="server" Height="16px" Width="200px"  name="入库煤场"  valued="must1"></asp:TextBox></td>
                    <td class="auto-style3">入库皮重<asp:TextBox id="rkpz" runat="server" cal="must1" name="入库皮重" Height="16px" Width ="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>                   
                    <td class="auto-style3">入库毛重<asp:TextBox ID="rkmz" runat="server" cal="must1" name="入库毛重"  Width="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">#入库净重<asp:TextBox id="rkjz" runat="server" Height="16px" Width ="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">#亏损吨数<asp:TextBox id="ksds" runat="server" Height="16px" Width ="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">#盈余吨数<asp:TextBox id="yyds" runat="server" Height="16px" Width ="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td> 
                    <td class="auto-style3">运输路耗标准(吨)<asp:TextBox id="yslhbz" name="运输路耗标准" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"/>
                        *<asp:TextBox id="percent" ToolTip="百分比,请按小数输入" runat="server" Height="16px" Width ="40px" OnKeyPress="isnum()"   OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        <asp:CheckBox runat="server" ToolTip="勾选按入库净重百分比计算" id="IsCal" Height="20px" width="20px"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">#扣款标准（元/吨）<asp:TextBox id="kkbz"  name="扣款标准" runat="server" Height="16px" Width ="160px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">#扣亏吨数<asp:TextBox id="kkds" runat="server" Height="16px" Width ="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">#扣亏金额<asp:TextBox id="kkje" runat="server" Height="16px" Width ="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td> 
                    <td class="auto-style3">#运费结算吨位<asp:TextBox id="yfjsdw"  name="运费结算吨位" runat="server" Height="16px" Width ="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">运价<asp:TextBox id="yj" runat="server" Height="16px" cal="must1" name="运价" Width ="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">#应付运费<asp:TextBox id="yfyf" runat="server" Height="16px" Width ="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">已付油卡<asp:TextBox id="yfyk" runat="server" cal="must1" name="已付油卡" Height="16px" Width ="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox></td> 
                    <td class="auto-style3">付卡账户<telerik:RadComboBox RenderMode="Lightweight" ID="tk_fkzh" AutoPostBack="True" runat="server" Width="200px" Height="200px" EmptyMessage="请输入支付账户"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" 
   HighlightTemplatedItems="true"/></td>
                </tr>
                <tr>
                    <td class="auto-style3">#结算运费<asp:TextBox id="jsyf" runat="server" Height="16px" Width ="200px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">支付账户<telerik:RadComboBox RenderMode="Lightweight" ID="tk_zfzh" AutoPostBack="True" runat="server" Width="200px" Height="200px" EmptyMessage="请输入支付账户"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" 
   HighlightTemplatedItems="true"/></td>
                    <td class="auto-style3">审核状态<asp:DropDownList id="shzt" runat="server" Height="20px" Width ="200px">
                        <asp:ListItem>已审核</asp:ListItem>
                        <asp:ListItem>未审核</asp:ListItem>
                        </asp:DropDownList>
                    </td> 
                    <td class="auto-style3">运费结算状态<asp:DropDownList id="yfjszt" runat="server" Height="20px" Width ="200px">
                        <asp:ListItem>已结算</asp:ListItem>
                        <asp:ListItem>未结算</asp:ListItem>
                                                  </asp:DropDownList></td>
                </tr>
            </table>            
        </div>


        <p class="auto-style5">
            <asp:Button ID="Button1" text="计算表单" runat ="server" width="90px"  BorderStyle="Groove" OnClick="Button1_Click" BackColor="Aqua"/>&nbsp
                &nbsp
                <asp:Button ID="submit" text="保存并关闭" runat ="server" width="90px"  BorderStyle="Groove" OnClick="submit_Click" BackColor="Aqua"/>&nbsp
                &nbsp
            <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>