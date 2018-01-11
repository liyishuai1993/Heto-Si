<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QyhtGl.aspx.cs" Inherits="XSSystem.Page.P_HTGL.QyhtGl" %>
<%@ Register Assembly="xsFramework.UserControl" Namespace="xsFramework.UserControl.Pager"
    TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../style/sysCss.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
        <span>类别</span>
        <asp:Dropdownlist id="ddlnewtype" runat="server" autopostback="true" onselectedindexchanged="ddlnewtype_selectedindexchanged"></asp:Dropdownlist>
        <span>名称：</span><asp:TextBox ID="txtNewName" runat="server" CssClass="inputText"></asp:TextBox><asp:Button
            ID="btnQuery" runat="server" Text="查询" CssClass="button"
            OnClick="btnQuery_Click" />
    </p>
        </div>
    <div>
    <asp:Panel ID="Panel1" runat="server" Height="185px" ScrollBars="Auto" Width="1500px">
        <asp:GridView ID="GridOrder" runat="server" CssClass="xs_table" AutoGenerateColumns="False"
            ShowHeaderWhenEmpty="True" EmptyDataText="查无订单" Width="120%" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="htbh" HeaderStyle-Width="10%" HeaderText="合同编号">
                <HeaderStyle Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="htlx" HeaderStyle-Width="5%" HeaderText="合同类型">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="qdrq" HeaderStyle-Width="5%" HeaderText="签订日期">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="dfhth" HeaderStyle-Width="5%" HeaderText="对方合同号">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="wtf" HeaderStyle-Width="5%" HeaderText="委托方">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="stf" HeaderStyle-Width="5%" HeaderText="受托方">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="kplx" HeaderStyle-Width="5%" HeaderText="开票类型">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="zxqxQ" HeaderStyle-Width="5%" HeaderText="执行期限起">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="zxqxZ" HeaderStyle-Width="5%" HeaderText="执行期限止">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:TemplateField HeaderStyle-Width="5%" HeaderText="操作">
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("htbh") %>' CssClass="buttonCancle" OnClick="btnDelete_Click" OnClientClick="return confirm('是否删除？')" Text="删除" />
                    </ItemTemplate>
                    <HeaderStyle Width="5%"/>
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
        </asp:Panel>
    <cc1:xsPageControl ID="xsPage" runat="server" OnPageChanged="xsPage_PageChanged">
        </cc1:xsPageControl>
    </div>
    </form>
</body>
</html>

