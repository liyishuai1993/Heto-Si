<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fkd.aspx.cs" Inherits="XSSystem.Page.P_Order.Fkd" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>付款单</title>
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
            width: 800px;
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
            <p class="auto-style5">付款单</p>
            <telerik:RadScriptManager runat="server" ID="RadScriptManager1"></telerik:RadScriptManager>
            <p class="auto-style4">
                <span>录单日期</span><asp:TextBox ID="ldrq" runat="server" Height="16px" Width="184px" Text="" onClick="WdatePicker()"></asp:TextBox>
                编号<asp:TextBox ID="bh" runat="server" Enabled="false" Height="16px" Width="184px"></asp:TextBox>
            </p>
            <div>
                <table border="0" aria-haspopup="False" class="auto-style1" style="width: 1200px">
                    <tr>
                        <td class="auto-style3">收款单位<telerik:RadComboBox RenderMode="Lightweight" ID="tk_skdw" runat="server" Width="184px" Height="200px"
                            EmptyMessage="请输入收款单位" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="收款单位" valued="must1"
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
                        <td class="auto-style3">合同编号<telerik:RadComboBox RenderMode="Lightweight" ID="tk_htbh" runat="server" Width="184px" Height="200px"
                            EmptyMessage="请选择合同编号" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="合同编号" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                        <td class="auto-style3">摘要<asp:DropDownList ID="dp_zy" runat="server" Height="24px" Width="184px">
                            <asp:ListItem>借款</asp:ListItem>
                            <asp:ListItem>采购款</asp:ListItem>
                            <asp:ListItem>往来</asp:ListItem>
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
                        <td class="auto-style3"></td>
                        <td></td>
                    </tr>
                </table>
            </div>

            <div style="width: 1200px; margin-top: 20px;">
                <div style="margin-bottom: 20px">
                    <asp:Button runat="server" Text="新增" ID="InsertBtn" OnClick="InsertBtn_Click" Width="60px" />
                    收款账户<telerik:RadComboBox RenderMode="Lightweight" ID="tk_skzhbh" AutoPostBack="True" runat="server" Height="200px"
                        EmptyMessage="请输入收款账户" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="收款账户" valued="must2"
                        HighlightTemplatedItems="true" OnSelectedIndexChanged="tk_skzhbh_SelectedIndexChanged" Width="150px" />
                    收款账户名称<asp:TextBox runat="server" ID="zhm" valued="must2" name="收款账户名称" Width="150px" />
                    开户行<asp:TextBox runat="server" ID="khh" valued="must2" name="开户行" Width="150px"></asp:TextBox>
                    金额<asp:TextBox runat="server" ID="je" valued="must2" name="金额" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" Width="100px" />
                    <p>
                        备注<asp:TextBox runat="server" ID="bz" Width="600px" />
                    </p>
                </div>
                <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" EmptyDataText="无记录" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="序号" DataField="xh" HeaderStyle-Width="10%" Visible="false">
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
                        <asp:BoundField HeaderText="付款账户编号" DataField="fkzhbh">
                            <HeaderStyle HorizontalAlign="Left" Width="20%" />
                            <ItemStyle HorizontalAlign="Left" Width="20%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="付款账户名称" DataField="fkzhmc">
                            <HeaderStyle HorizontalAlign="Left" Width="20%" />
                            <ItemStyle HorizontalAlign="Left" Width="20%" />
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
                优惠金额<asp:TextBox ID="yhje" runat="server" OnTextChanged="yhje_TextChanged" Height="16px" AutoPostBack="true" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')">

                </asp:TextBox>合计金额<asp:TextBox ID="hjje" ReadOnly="true" runat="server" Height="16px" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
            </p>


            <p class="auto-style7">
                <asp:Button ID="print" Text="打印" runat="server" Width="90px" BackColor="#cccccc"></asp:Button>&nbsp
                <asp:Button ID="save" Text="保存" runat="server" Width="90px" BackColor="#cccccc" OnClick="save_Click"></asp:Button>&nbsp
                <asp:Button ID="update" Text="修改" runat="server" Width="90px" BackColor="#cccccc" OnClick="update_Click"></asp:Button>&nbsp
            <asp:Button ID="close" Text="关闭" runat="server" Width="90px" BackColor="#cccccc" OnClick="close_Click"></asp:Button>&nbsp

            </p>
        </div>
    </form>
</body>
</html>
