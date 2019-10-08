<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mkzxzcd.aspx.cs" Inherits="XSSystem.Page.P_Order.Mkzxzcd" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>煤矿直销装车单</title>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
    <script src="../../js/FormStyle.js"></script>
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
            width: 400px;
            text-align: right;
        }

        .Wdate {
        }

        .auto-style4 {
            height: 20px;
            width: 1200px;
            text-align: left;
        }

        .auto-style5 {
            height: auto;
            width: auto;
            text-align: left;
        }
    </style>
    <script type="text/javascript">
        function FormCheck() {
            document.getElementById("zcjz").value = document.getElementById("zcmz").value - document.getElementById("zcpz").value;
            document.getElementById("yfyf").value = document.getElementById("zcjz").value * document.getElementById("yj").value;
            document.getElementById("cgjsje").value = document.getElementById("zcjz").value * document.getElementById("cgmj").value;
            document.getElementById("xsjsje").value = (document.getElementById("yj").value + document.getElementById("xsmj").value) * document.getElementById("zcjz").value;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p class="auto-style5" style="text-align: center">煤矿直销装车单</p>
            <div>
                <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />
                <p>基本信息</p>
                <table border="0" aria-haspopup="False" class="auto-style1">
                    <tr>
                        <td class="auto-style3"><span>单据编号</span><asp:TextBox ID="djbh" runat="server" valued="must1" name="单据编号" Height="16px" Width="284px"></asp:TextBox></td>
                        <td class="auto-style3"><span>装车时间</span>
                            <asp:TextBox ID="zcsj" runat="server" Text="" name="装车时间" onClick="WdatePicker()" Width="284px" valued="must1"></asp:TextBox>
                        </td>
                        <td class="auto-style3"><span>采购合同号</span><asp:TextBox ID="cghth" name="采购合同号" runat="server" Height="16px" Width="269px" valued="must1"></asp:TextBox>
                        </td>


                    </tr>
                    <tr>
                        <td class="auto-style3">*供货方<telerik:RadComboBox RenderMode="Lightweight" ID="tk_ghf" runat="server" Width="284px" Height="200px"
                            EmptyMessage="请输入供货方" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="供货方" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                        <td class="auto-style3">*收货方<telerik:RadComboBox RenderMode="Lightweight" ID="tk_shf" runat="server" Width="284px" Height="200px"
                            EmptyMessage="请输入收货方" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="收货方" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                        <td class="auto-style3">煤矿名称<asp:TextBox ID="mkmc" runat="server" Height="16px" Width="269px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>物料名称</span><asp:TextBox ID="wlmc" runat="server" name="物料名称" Height="16px" Width="284px" valued="must1"></asp:TextBox>
                        </td>
                        <td class="auto-style3">承运单位<asp:TextBox ID="cydw" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                        <td class="auto-style3"><span>运价</span><asp:TextBox ID="yj" cal="must1" valued="must1" name="运价" runat="server" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>采购煤价</span><asp:TextBox ID="cgmj" cal="must1" runat="server" name="采购煤价" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox>
                        </td>
                        <td class="auto-style3"><span>销售煤价</span><asp:TextBox ID="xsmj" runat="server" cal="must1" name="销售煤价" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox>
                        </td>
                        <td></td>
                    </tr>
                </table>
            </div>

            <div style="margin-top: 15px; width: 1200px">
                <div class="divcss5">
                    <p>车辆信息<asp:Button ID="Button1" runat="server" Text="新增记录" OnClick="AddClxx" /></p>
                    <p class="auto-style5">
                        磅单号<asp:TextBox ID="bdh" runat="server" name="磅单号" Height="16px" Width="100px" ToolTip="磅单号" valued="must2"></asp:TextBox>
                        提货单号<asp:TextBox ID="thdh" runat="server" name="提货单号" Height="16px" Width="100px" valued="must2"></asp:TextBox>
                        车号<asp:TextBox ID="ch" runat="server" name="车号" Height="16px" Width="100px" valued="must2"></asp:TextBox>
                        装车皮重<asp:TextBox ID="zcpz" cal="must1" name="装车皮重" runat="server" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                        装车毛重<asp:TextBox ID="zcmz" cal="must1" OnBlur="FormCheck()" name="装车毛重" runat="server" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                        #装车净重<asp:TextBox ID="zcjz" runat="server" name="装车净重" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>

                    </p>
                    <p class="auto-style5">
                        #应付运费<asp:TextBox ID="yfyf" runat="server" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                        #采购结算金额<asp:TextBox ID="cgjsje" runat="server" name="采购结算金额" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                        #销售结算金额<asp:TextBox ID="xsjsje" OnFocus="FormCheck()" runat="server" name="销售结算金额" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                        备注<asp:TextBox ID="bz" runat="server" Height="16px" Width="100px"></asp:TextBox>
                        状态<asp:TextBox ID="zt" runat="server" Height="16px" Width="100px"></asp:TextBox>

                    </p>
                </div>
                <p>

                    <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                                <HeaderTemplate>
                                    序号
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="*磅单号" DataField="bdh" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="提货单号" DataField="thdh" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="*车号" DataField="ch" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="装车皮重" DataField="zcpz" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="装车毛重" DataField="zcmz" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="*装车净重" DataField="zcjz" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="应付运费" DataField="yfyf" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="采购结算金额" DataField="cgjsje" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="销售结算金额" DataField="xsjsje" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="备注" DataField="bz" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="状态" DataField="zt" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
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
            </div>

            <p class="auto-style5" style="text-align: center">
                <asp:Button ID="refresh" Text="计算表单" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="refresh_Click"></asp:Button>&nbsp
                <asp:Button ID="add" Text="保存" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp
                <asp:Button ID="update" Text="修改" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="update_Click"></asp:Button>&nbsp
            <asp:Button ID="close" Text="关闭" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="close_Click"></asp:Button>&nbsp

                
            </p>
        </div>
    </form>
</body>
</html>
