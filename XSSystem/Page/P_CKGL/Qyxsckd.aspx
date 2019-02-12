﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Qyxsckd.aspx.cs" Inherits="XSSystem.Page.P_Order.Qyxsckd" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>汽运销售出库单</title>
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
    <div> <p class="auto-style5">汽运销售出库单</p>
        <div>
             <telerik:RadScriptManager runat="server" ID="RadScriptManager1"/>
            <p>出库信息(出库单)</p>
            <table border="0" aria-haspopup="False" class="auto-style1"  >
                <tr>
                    <td class="auto-style3">出库磅单号<asp:TextBox ID="ckbdh" runat="server" Height="16px" Width="500px" name="出库磅单号" valued="must1" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td>
                    <td class="auto-style3">合同编号<asp:TextBox id="htbh" runat="server" Height="16px" Width ="500px" valued="must1" name="合同编号"></asp:TextBox> </td>                                    
                </tr>
                <tr>
                    <td class="auto-style3">装车时间<asp:TextBox id="zcsj" runat="server" Text="" onClick="WdatePicker()" Width="500px" valued="must1" name="装车时间"></asp:TextBox> </td>
                    <td class="auto-style3">发煤煤场<telerik:RadComboBox RenderMode="Lightweight" ID="tk_fmmc" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入发煤煤场"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="发煤煤场" valued="must1" 
   HighlightTemplatedItems="true"/></td>
                </tr>
                <tr>
                    <td class="auto-style3">供方<telerik:RadComboBox RenderMode="Lightweight" ID="tk_gf" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入供方名称"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="供方名称" valued="must1" 
   HighlightTemplatedItems="true"/></td>
                    <td class="auto-style3">需方<telerik:RadComboBox RenderMode="Lightweight" ID="tk_xf" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入需方名称"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="需方名称" valued="must1" 
   HighlightTemplatedItems="true"/></td>
                </tr>
                <tr>
                    <td class="auto-style3">车号<asp:TextBox name="车号"  id="ch" runat="server" Height="16px" Width ="500px" CssClass="auto-style4" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">驾驶员<asp:TextBox id="jsy" runat="server" Height="16px" Width ="500px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">联系电话<asp:TextBox id="lxdh" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">物料名称<asp:TextBox id="wlmc" runat="server" Height="16px" Width ="500px" name="物料名称" valued="must1"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">出库毛重<asp:TextBox id="ckmz" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="出库毛重" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">出库皮重<asp:TextBox id="ckpz" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="出库皮重" valued="must1"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">加磅吨数<asp:TextBox id="jbds" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="加磅吨数" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">#出库净重1<asp:TextBox id="ckjz1" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="出库净重1" valued="must1"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">#出库净重2<asp:TextBox id="ckjz2" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="出库净重2" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">煤价<asp:TextBox id="mj" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="煤价" valued="must1"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">#货款估算金额<asp:TextBox id="hkgsje" runat="server" Height="16px" Width ="482px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="货款估算金额" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">已付油卡<asp:TextBox id="yfyk" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="已付油卡" valued="must1"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">运价<asp:TextBox id="yj" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="运价" valued="must1"></asp:TextBox></td>
                    <td class="auto-style3">付卡账户<asp:TextBox id="fkzh" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    
                </tr>

            </table>     
        </div>
        
        <div>
            <p>入库信息(客户回单)</p>
            <table border="0" aria-haspopup="False" class="auto-style1"  >
                <tr>
                    <td class="auto-style3">*入库磅单号<asp:TextBox ID="rkbdh" runat="server" Height="16px" Width="284px" name="入库磅单号" valued="must1"></asp:TextBox></td>
                    <td class="auto-style3">入库时间
                        <asp:TextBox ID="rksj" runat="server" Text="" onClick="WdatePicker()" Width="284px" name="入库时间" valued="must1"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>                
                </tr>
                <tr>
                    <td class="auto-style3">入库毛重<asp:TextBox id="rkmz" name="入库毛重" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">入库皮重<asp:TextBox id="rkpz" name="入库皮重" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">入库净重<asp:TextBox id="rkjz" name="入库净重" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">亏损吨数<asp:TextBox id="ksds" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="亏损吨数"></asp:TextBox> </td>
                    <td class="auto-style3">盈余吨数<asp:TextBox id="yyds" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="盈余吨数"></asp:TextBox></td>
                    <td class="auto-style3">扣吨(扣杂)<asp:TextBox id="kd" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" name="扣吨"></asp:TextBox></td> 
                </tr>
                <tr>
                    <td class="auto-style3">运费合理路耗(吨)<asp:TextBox id="yfhllh" name="运费合理路耗" runat="server" Height="16px" Width ="254px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td> 
                    <td class="auto-style3">运费扣款标准(元/吨)<asp:TextBox id="yflhbz" name="运费扣款标准" runat="server" Height="16px" Width ="233px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">运费扣亏吨数<asp:TextBox id="yfkkds" name="运费扣亏吨数" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">运费扣款金额<asp:TextBox id="yfkkje" runat="server" name="运费扣款金额" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">运费结算吨位<asp:TextBox id="yfjsdw" runat="server" name="运费结算吨位" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">应付运费<asp:TextBox id="yfyf" runat="server" name="应付运费" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox>  </td> 
                </tr>
                <tr>
                    <td class="auto-style3">费用扣款(手续费、卸车费)<asp:TextBox id="fykk" runat="server" Height="16px" Width ="188px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td> 
                    <td class="auto-style3">结算运费<asp:TextBox id="jsyf" name="结算运费" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">货款结算吨位<asp:TextBox id="hkjsdw" name="货款结算吨位" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox></td>
                    
                </tr>

                <tr>
                    <td class="auto-style3">结算货款<asp:TextBox id="jshk" name="结算货款" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox></td> 
                    <td class="auto-style3">提成标准<asp:TextBox id="tcbz" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">提成金额<asp:TextBox id="tcje" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td>
                    
                </tr>

                <tr>
                    <td class="auto-style3">业务员<asp:TextBox id="ywy" runat="server" Height="16px" Width ="284px"></asp:TextBox></td> 
                    <td class="auto-style3">运费结算状态<asp:TextBox id="yfjszt" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">审核状态<asp:TextBox id="shzt" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    
                </tr>

            </table>            
        </div>


        <p class="auto-style5">
            <asp:Button ID="Button1" text="计算表单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="Button1_Click"></asp:Button>&nbsp
                <asp:Button ID="submit" text="保存出库单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp
            <asp:Button ID="submit2" text="保存回单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit2_Click"></asp:Button>&nbsp          
                <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>
