<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QyzxhdSearch.aspx.cs" Inherits="XSSystem.Page.P_Order.QyzxhdSearch" %>

<%@ Register Assembly="xsFramework.UserControl" Namespace="xsFramework.UserControl.Pager"
    TagPrefix="cc1" %>
<%@ OutputCache Location="None" VaryByParam="None"%>
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
        <span>应用状态</span>
        <asp:Dropdownlist id="ddlnewtype" runat="server" autopostback="true" onselectedindexchanged="ddlnewtype_selectedindexchanged"></asp:Dropdownlist>
        <asp:TextBox ID="txtNewName" runat="server" CssClass="inputText"></asp:TextBox><asp:Button
            ID="btnQuery" runat="server" Text="查询" CssClass="button"
            OnClick="btnQuery_Click" />
    </p>
        </div>
    <div>
    <asp:Panel ID="Panel1" runat="server" Height="185px" ScrollBars="Auto" Width="1400px">
        <asp:GridView ID="GridOrder" runat="server" CssClass="xs_table" AutoGenerateColumns="false"
            ShowHeaderWhenEmpty="true" EmptyDataText="无数据" Width="110%">
            <Columns>
                <asp:BoundField HeaderText="序号" DataField="xh" HeaderStyle-Width="5%" />
                <asp:TemplateField HeaderText="操作" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" Text="客户回单录入" CssClass="buttonCancle" CommandArgument='<%#Eval("oid") %>'
                            OnClientClick="return confirm('是否删除？')" actionid="04" OnClick="btnDelete_Click" />

                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="单据编号" DataField="djbh" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="装车时间" DataField="zcsj" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="批次号" DataField="pch" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="供货方名称" DataField="ghfmc" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="收货方名称" DataField="shfmc" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="采购合同编号" DataField="cghtbh" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="销售合同编号" DataField="xshtbh" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="物料名称" DataField="wlmc" HeaderStyle-Width="10%" />
            </Columns>
        
        </asp:GridView>
        </asp:Panel>
    <cc1:xsPageControl ID="xsPage" runat="server" OnPageChanged="xsPage_PageChanged">
        </cc1:xsPageControl>
    </div>
    </form>
</body>
</html>
