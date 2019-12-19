<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tyxsckd.aspx.cs" Inherits="XSSystem.Page.P_Order.Tyxsckd" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>铁运销售出库单</title>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
    <script src="../../My97DatePicker/WdatePicker.js"></script>
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

        .auto-style6 {
            height: 20px;
            width: 200px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p class="auto-style5">铁运销售出库单</p>
            <div>
                <telerik:RadScriptManager runat="server" ID="RadScriptManager1"></telerik:RadScriptManager>
                <p>基本信息</p>
                <table border="0" aria-haspopup="False" class="auto-style1">
                    <tr>
                        <td class="auto-style3"><span>编号</span><asp:TextBox ID="bh" name="合同编号" valued="must1" runat="server" Height="16px" Width="500px"></asp:TextBox></td>
                        <td class="auto-style3"><span>合同编号</span><asp:TextBox ID="htbh" name="合同编号" runat="server" Height="16px" Width="500px" valued="must1"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">委托方<telerik:RadComboBox RenderMode="Lightweight" ID="tk_wtf" runat="server" Width="500px" Height="200px"
                            EmptyMessage="请输入委托方" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="委托方" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                        <td class="auto-style3">受托方<telerik:RadComboBox RenderMode="Lightweight" ID="tk_stf" runat="server" Width="500px" Height="200px"
                            EmptyMessage="请输入受托方" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="受托方" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">发煤煤场<telerik:RadComboBox RenderMode="Lightweight" ID="tk_fmmc" runat="server" Width="500px" Height="200px"
                            EmptyMessage="请输入发煤煤场" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="发煤煤场" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                        <td class="auto-style3"><span>物料名称</span><asp:TextBox ID="wlmc" name="物料名称" runat="server" Height="16px" Width="500px" CssClass="auto-style4" valued="must1"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>煤价</span><asp:TextBox ID="mj" name="煤价" cal="must1" runat="server" Height="16px" Width="500px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox>
                        </td>
                        <td class="auto-style3">装车站<telerik:RadComboBox RenderMode="Lightweight" ID="tk_zcz" runat="server" Width="500px" Height="200px"
                            EmptyMessage="请输入装车站" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="装车站" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">终到站<telerik:RadComboBox RenderMode="Lightweight" ID="tk_zdz" runat="server" Width="500px" Height="200px"
                            EmptyMessage="请输入终到站" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="终到站" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                        <td class="auto-style3">箱类型<asp:TextBox ID="xlx" runat="server" Height="16px" Width="500px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>提成标准</span><asp:TextBox ID="tcbz" cal="must1" name="提成标准" runat="server" Height="16px" Width="500px" CssClass="auto-style4" valued="must1"></asp:TextBox>
                        </td>
                        <td class="auto-style3">#提成金额<asp:TextBox ID="tcje" runat="server" valued="must1" name="提成金额" Height="16px" Width="500px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">业务员<asp:TextBox ID="ywy" runat="server" Height="16px" Width="500px" CssClass="auto-style4"></asp:TextBox>
                        </td>
                        <td class="auto-style3" hidden="hidden"><span>卸货吨位</span><asp:TextBox ID="xhdw" name="卸货吨位" runat="server" Height="16px" Width="500px" CssClass="auto-style4"></asp:TextBox>
                        </td>
                    </tr>

                </table>
            </div>

            <div style="margin-top: 15px; width: 1300px">
                <div class="divcss5">
                    <p>集装箱信息<asp:Button ID="Button2" runat="server" Text="新增记录" OnClick="AddJgxx" /></p>
                    <p>
                        箱号<asp:TextBox ID="xh" runat="server" name="箱号" Height="16px" Width="100px" valued="must2"></asp:TextBox>
                        上箱吨数<asp:TextBox ID="sxds" runat="server" cal="must1" name="上箱吨数" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                        装箱日期<asp:TextBox ID="zxrq" Text="" onClick="WdatePicker()" cal="must1" name="装箱日期" runat="server" Height="16px" Width="100px" valued="must2"></asp:TextBox>
                        发车日期<asp:TextBox ID="fcrq" Text="" onClick="WdatePicker()" runat="server" Height="16px" Width="100px" valued="must2" name="起始日期"></asp:TextBox>
                        卸货吨数<asp:TextBox ID="xhds" runat="server" Height="16px" cal="must1" name="卸货吨数" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                        到站日期<asp:TextBox ID="dzrq" Text="" onClick="WdatePicker()" runat="server" Height="16px" Width="100px" valued="must2" name="起始日期"></asp:TextBox>
                    </p>
                    <table border="0" aria-haspopup="False" class="auto-style1">
                        <tr>
                            <td class="auto-style6">#结算货款<asp:TextBox ID="jshk" runat="server" Height="16px" name="结算货款" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                                <telerik:RadComboBox RenderMode="Lightweight" ID="jshk_qkr" runat="server" Width="100px" Height="200px"
                                    EmptyMessage="欠款人" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="委托方" valued="must1"
                                    HighlightTemplatedItems="true" />
                            </td>
                            <td class="auto-style6">自备箱使费(元/组)<asp:TextBox ID="zbxsf" runat="server" cal="must1" name="自备箱使费" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                                <telerik:RadComboBox RenderMode="Lightweight" ID="zbxsf_qkr" runat="server" Width="100px" Height="200px"
                                    EmptyMessage="欠款人" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="委托方" valued="must1"
                                    HighlightTemplatedItems="true" />
                            </td>
                            <td class="auto-style6">发站代理费(元/组)<asp:TextBox ID="fzdlf" runat="server" cal="must1" name="发站代理费" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                                <telerik:RadComboBox RenderMode="Lightweight" ID="fzdlf_qkr" runat="server" Width="100px" Height="200px"
                                    EmptyMessage="欠款人" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="委托方" valued="must1"
                                    HighlightTemplatedItems="true" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">发站装箱费(元/吨)<asp:TextBox ID="fzzxf" runat="server" cal="must1" name="发站装箱费" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                                <telerik:RadComboBox RenderMode="Lightweight" ID="fzzxf_qkr" runat="server" Width="100px" Height="200px"
                                    EmptyMessage="欠款人" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="委托方" valued="must1"
                                    HighlightTemplatedItems="true" />
                            </td>
                            <td class="auto-style6">发站倒短(元/吨)<asp:TextBox ID="fzddf" runat="server" cal="must1" name="发站倒短" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                                <telerik:RadComboBox RenderMode="Lightweight" ID="fzddf_qkr" runat="server" Width="100px" Height="200px"
                                    EmptyMessage="欠款人" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="委托方" valued="must1"
                                    HighlightTemplatedItems="true" />
                            </td>
                            <td class="auto-style6">铁路运费(元/组)<asp:TextBox ID="tlyf" runat="server" cal="must1" name="铁路运费" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                                <telerik:RadComboBox RenderMode="Lightweight" ID="tlyf_qkr" runat="server" Width="100px" Height="200px"
                                    EmptyMessage="欠款人" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="委托方" valued="must1"
                                    HighlightTemplatedItems="true" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">到站装卸费(元/组)<asp:TextBox ID="dzzxf" runat="server" cal="must1" name="到站装卸费" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                                <telerik:RadComboBox RenderMode="Lightweight" ID="dzzxf_qkr" runat="server" Width="100px" Height="200px"
                                    EmptyMessage="欠款人" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="委托方" valued="must1"
                                    HighlightTemplatedItems="true" />
                            </td>
                            <td class="auto-style6">到站-煤场倒短费(元/组)<asp:TextBox ID="dzmcddf" runat="server" cal="must1" name="到站-煤场倒短费" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                                <telerik:RadComboBox RenderMode="Lightweight" ID="dzmcddf_qkr" runat="server" Width="100px" Height="200px"
                                    EmptyMessage="欠款人" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="委托方" valued="must1"
                                    HighlightTemplatedItems="true" />
                            </td>
                            <td class="auto-style6">到站代理费(元/吨)<asp:TextBox ID="dzdlf" runat="server" cal="must1" name="到站代理费" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                                <telerik:RadComboBox RenderMode="Lightweight" ID="dzdlf_qkr" runat="server" Width="100px" Height="200px"
                                    EmptyMessage="欠款人" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="委托方" valued="must1"
                                    HighlightTemplatedItems="true" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">#铁路运费小计<asp:TextBox ID="tlyfxj" runat="server" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                                <%--<telerik:RadComboBox RenderMode="Lightweight" ID="tlyfxj_qkr"  runat="server" Width="100px" Height="200px"
  EmptyMessage="欠款人"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="委托方" valued="must1" 
   HighlightTemplatedItems="true"/>--%>
                            </td>
                        </tr>
                    </table>
                </div>
                <p>
                    <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" ShowHeaderWhenEmpty="true" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None"
                        OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" DataKeyNames="id">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField HeaderText="id" Visible="false" DataField="id" HeaderStyle-Width="5%" SortExpression="id">
                                <HeaderStyle HorizontalAlign="Left" Width="5%" />
                                <ItemStyle HorizontalAlign="Left" Width="5%" />
                            </asp:BoundField>
                            <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                                <HeaderTemplate>
                                    序号
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="箱号" DataField="xh" HeaderStyle-Width="5%">
                                <HeaderStyle HorizontalAlign="Left" Width="5%" />
                                <ItemStyle HorizontalAlign="Left" Width="5%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="上箱吨数" DataField="sxds" HeaderStyle-Width="5%">
                                <HeaderStyle HorizontalAlign="Left" Width="5%" />
                                <ItemStyle HorizontalAlign="Left" Width="5%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="装箱日期" DataField="zxrq" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="发车日期" DataField="fcrq" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="卸货吨数" DataField="xhds" HeaderStyle-Width="5%">
                                <HeaderStyle HorizontalAlign="Left" Width="5%" />
                                <ItemStyle HorizontalAlign="Left" Width="5%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="到站日期" DataField="dzrq" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="结算货款" DataField="jshk" HeaderStyle-Width="5%">
                                <HeaderStyle HorizontalAlign="Left" Width="5%" />
                                <ItemStyle HorizontalAlign="Left" Width="5%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="自备箱使费(元/组)" DataField="zbxsf" HeaderStyle-Width="5%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="发站代理费(元/组)" DataField="fzdlf" HeaderStyle-Width="5%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="发站装箱费(元/吨)" DataField="fzzxf" HeaderStyle-Width="5%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="发站倒短(元/吨)" DataField="fzddf" HeaderStyle-Width="5%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="铁路运费(元/组)" DataField="tlyf" HeaderStyle-Width="5%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="到站装卸费(元/组)" DataField="dzzxf" HeaderStyle-Width="5%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="到站-煤场倒短费(元/组)" DataField="dzmcddf" HeaderStyle-Width="5%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="到站代理费(元/吨)" DataField="dzdlf" HeaderStyle-Width="5%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="铁路运费小计" DataField="tlyfxj" HeaderStyle-Width="5%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:CommandField HeaderText="编辑" ShowEditButton="True" />
                            <asp:TemplateField HeaderStyle-Width="5%" HeaderText="删除">
                                <ItemTemplate>
                                    <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument=' <%#Container.DataItemIndex%>' CssClass="buttonCancle" OnClick="DelJgxx" OnClientClick="return confirm('是否删除？')" Text="删除" />
                                    <%--<asp:Button ID="btnShenghe" runat="server" actionid="03" CommandArgument='<%#Eval("htbh") %>' CssClass="buttonCancle" OnClick="btnShengHe_Click" OnClientClick="return confirm('是否确定合同通过审核？')" Text="审核" />--%>
                                </ItemTemplate>
                                <HeaderStyle Width="5%" />
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>

                </p>

            </div>

            <%--                <div style="margin-top:15px;width:1200px">
            <div class="divcss5">
            <p>欠款人信息<asp:Button ID="Btn_Qkr" runat="server" Text="新增记录"  OnClick="Btn_Qkr_Click"/></p>
            <p>
                
                欠款人<asp:TextBox id="name" runat="server"  Height="16px" Width ="100px" ></asp:TextBox>
                总欠款金额<asp:TextBox id="zqkje" runat="server"   Height="16px" Width ="100px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" ></asp:TextBox>
                已还款金额<asp:TextBox id="yhkje" Text=""  cal="must1" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" runat="server" Height="16px" Width ="100px" ></asp:TextBox>
                剩余还款金额<asp:TextBox id="syqkje" Text=""  runat="server" Height="16px" Width ="100px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                </p>
                <p>
                欠款项目<asp:TextBox id="qkxm" runat="server" Height="16px"   Width ="400px"  ></asp:TextBox>
                手机号<asp:TextBox id="phone" Text=""  runat="server" Height="16px" Width ="100px"></asp:TextBox>
                备注<asp:TextBox id="bz" runat="server" Height="16px"  Width ="100px"  ></asp:TextBox>     
            </p>
                </div>
            <p>
                
                <asp:GridView ID="GridView2" runat="server" CssClass="xs_table" ShowHeaderWhenEmpty="true"  AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="序号" DataField="bh" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="5%" />
                <ItemStyle HorizontalAlign="Left" Width="5%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="欠款人" DataField="name" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="5%" />
                <ItemStyle HorizontalAlign="Left" Width="5%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="总欠款金额" DataField="zqkje" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="5%" />
                <ItemStyle HorizontalAlign="Left" Width="5%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="已还款金额" DataField="yhkje" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="剩余还款金额" DataField="syqkje" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="欠款项目" DataField="qkxm" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="5%" />
                <ItemStyle HorizontalAlign="Left" Width="5%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="手机号" DataField="phone" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="备注" DataField="bz" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="5%" />
                <ItemStyle HorizontalAlign="Left" Width="5%" />
                        </asp:BoundField>
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </p>
            

                   
        </div>--%>



            <p class="auto-style5">
                <asp:Button ID="Button1" Text="计算表单" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="Button1_Click"></asp:Button>&nbsp
                <asp:Button ID="add" Text="保存" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp    
            <asp:Button ID="update" Text="修改" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="update_Click"></asp:Button>&nbsp    
                <asp:Button ID="close" Text="关闭" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="close_Click"></asp:Button>

            </p>
        </div>
    </form>
</body>
</html>
