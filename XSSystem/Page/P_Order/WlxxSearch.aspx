<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WlxxSearch.aspx.cs" Inherits="XSSystem.Page.P_Order.WlxxSearch" %>

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
    <asp:Panel ID="Panel1" runat="server" Height="185px" ScrollBars="Auto" Width="1500px">
        <asp:GridView ID="GridOrder" runat="server" CssClass="xs_table" AutoGenerateColumns="false"
            ShowHeaderWhenEmpty="true" EmptyDataText="无数据" Width="100%">
            <Columns>
                <asp:BoundField HeaderText="序号" DataField="xh" HeaderStyle-Width="5%" />
                <asp:TemplateField HeaderText="操作" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" Text="删除" CssClass="buttonCancle" CommandArgument='<%#Eval("oid") %>'
                            OnClientClick="return confirm('是否删除？')" actionid="04" OnClick="btnDelete_Click" />

                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="物料名称" DataField="wlmc" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="物料编码" DataField="wlbm" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="禁用状态" DataField="jyzt" HeaderStyle-Width="10%" />

                <asp:BoundField HeaderText="排序" DataField="px" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="描述" DataField="ms" HeaderStyle-Width="40%" />
                
            </Columns>
        
        </asp:GridView>
        </asp:Panel>
    <cc1:xsPageControl ID="xsPage" runat="server" OnPageChanged="xsPage_PageChanged">
        </cc1:xsPageControl>
    </div>
    </form>
</body>
</html>
