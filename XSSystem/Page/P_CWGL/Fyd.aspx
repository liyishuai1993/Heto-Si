<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fyd.aspx.cs" Inherits="XSSystem.Page.P_Order.Fyd" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>费用单</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
    <script src="../../js/FormStyle.js"></script>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            border-style: none;
            width: 900px;
            font-family: 宋体, Arial, Helvetica, sans-serif;
            line-height: normal;
            background-color: #33CCFF;
        }

        .auto-style3 {
            height: 20px;
            width: 300px;
            text-align: right;
        }

        .auto-style6 {
            height: 20px;
            width: 900px;
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

        .auto-style7 {
            height: auto;
            width: 900px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p class="auto-style5">费用单</p>
            <telerik:RadScriptManager runat="server" ID="RadScriptManager1"></telerik:RadScriptManager>
            <p class="auto-style4">
                <span>录单日期</span><asp:TextBox ID="ldrq" runat="server" Height="16px" Width="184px" Text="" onClick="WdatePicker()" valued="must1"></asp:TextBox>
                <span>编号</span><asp:TextBox ID="bh" runat="server" Height="16px" Width="184px" Enabled="false"></asp:TextBox>
            </p>
            <div>
                <table border="0" aria-haspopup="False" class="auto-style1">
                    <tr>
                        <td class="auto-style3">收费单位<telerik:RadComboBox RenderMode="Lightweight" ID="tk_sfdw" runat="server" Width="184px" Height="200px"
                            EmptyMessage="请输入收费单位" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="收费单位" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                        <td class="auto-style3">经手人<telerik:RadComboBox RenderMode="Lightweight" ID="tk_jsr" runat="server" Width="184px" Height="200px"
                            EmptyMessage="请输入经手人" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="经手人" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                        <td class="auto-style3"><span>部门</span><asp:TextBox ID="bm" runat="server" Height="16px" Width="184px" name="部门" valued="must1"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">摘要<asp:DropDownList ID="dp_zy" runat="server" Height="24px" Width="184px">
                            <asp:ListItem>报销</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                        <td class="auto-style3">附加说明<asp:TextBox ID="fjsm" runat="server" Height="16px" Width="184px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">结算方式<asp:DropDownList ID="jsfs" runat="server" Height="25px" Width="184px">
                            <asp:ListItem>现金</asp:ListItem>
                            <asp:ListItem>电汇</asp:ListItem>
                            <asp:ListItem>承兑汇票</asp:ListItem>
                            <asp:ListItem>电汇或承兑</asp:ListItem>
                            <asp:ListItem>电汇加承兑</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </div>

            <div style="width: 900px; margin-top: 20px;">
                <p>
                    <asp:Button runat="server" Text="新增" ID="InsertBtn" OnClick="InsertBtn_Click" />
                    费用项目编号<asp:TextBox runat="server" ID="fyxmbh" valued="must2" name="费用项目编号" />
                    费用项目名称<asp:TextBox runat="server" ID="fyxmmc" valued="must2" name="费用项目名称" />
                    金额<asp:TextBox runat="server" ID="je" OnKeyPress="isnum()" valued="must2" name="金额" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" />
                    备注<asp:TextBox runat="server" ID="bz" />
                </p>
                <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" EmptyDataText="无记录" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="序号" DataField="xh" Visible="false" HeaderStyle-Width="10%">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                            <HeaderTemplate>
                                序号
                            </HeaderTemplate>
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="费用项目编号" DataField="fyxmbh">
                            <HeaderStyle HorizontalAlign="Left" Width="15%" />
                            <ItemStyle HorizontalAlign="Left" Width="15%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="费用项目名称" DataField="fyxmmc">
                            <HeaderStyle HorizontalAlign="Left" Width="25%" />
                            <ItemStyle HorizontalAlign="Left" Width="25%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="金额" DataField="je">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="备注" DataField="bz">
                            <HeaderStyle HorizontalAlign="Left" Width="45%" />
                            <ItemStyle HorizontalAlign="Left" Width="45%" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="操作">
                            <ItemTemplate>
                                <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("xh") %>' CssClass="buttonCancle" OnClick="DelJgxx" OnClientClick="return confirm('是否删除？')" Text="删除" />
                                <%--<asp:Button ID="btnShenghe" runat="server" actionid="03" CommandArgument='<%#Eval("htbh") %>' CssClass="buttonCancle" OnClick="btnShengHe_Click" OnClientClick="return confirm('是否确定合同通过审核？')" Text="审核" />--%>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
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
            </div>

            <p class="auto-style7">

                <asp:CheckBox ID="CheckBox1" runat="server" Text="付款状态" TextAlign="Left" />

                合计金额<asp:TextBox ID="hjje" runat="server" Height="16px" Width="80px" OnKeyPress="isnum()" ReadOnly="true" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                付款账户<asp:TextBox ID="fkzh" runat="server" Height="16px" Width="80px"></asp:TextBox>
                实付金额<asp:TextBox ID="sfje" runat="server" Height="16px" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>

            </p>


            <p class="auto-style7">
                <%--<asp:Button ID="print" Text="打印" runat="server" Width="90px" BackColor="#cccccc"></asp:Button>&nbsp--%>
                <asp:Button ID="save" Text="保存" runat="server" Width="90px" BackColor="#cccccc" OnClick="save_Click"></asp:Button>&nbsp
                <asp:Button ID="update" Text="修改" runat="server" Width="90px" BackColor="#cccccc" OnClick="update_Click"></asp:Button>&nbsp
            <asp:Button ID="close" Text="关闭" runat="server" Width="90px" BackColor="#cccccc" OnClick="close_Click"></asp:Button>&nbsp

            </p>
        </div>
    </form>
</body>
</html>
