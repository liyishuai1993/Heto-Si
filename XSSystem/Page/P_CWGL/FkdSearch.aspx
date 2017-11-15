<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FkdSearch.aspx.cs" Inherits="XSSystem.Page.P_Order.FkdSearch" %>
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
        <span>请选择</span>
        <asp:Dropdownlist id="ddlnewtype" runat="server" autopostback="true" onselectedindexchanged="ddlnewtype_selectedindexchanged"></asp:Dropdownlist>
        <asp:Dropdownlist id="Dropdownlist1" runat="server" autopostback="true" onselectedindexchanged="ddlnewtype_selectedindexchanged"></asp:Dropdownlist>
        <span>名称：</span>
              <asp:Button ID="btnQuery" runat="server" Text="查询" CssClass="button" OnClick="btnQuery_Click" />
    </p>
        </div>
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
                <asp:BoundField HeaderText="审核" DataField="sh" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="单据编号" DataField="djbh" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="费用类型" DataField="fylx" HeaderStyle-Width="10%" />

                <asp:BoundField HeaderText="付款日期" DataField="fkrq" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="供方名称" DataField="gfmc" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="批次编号" DataField="pcbh" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="付款账号" DataField="fkzh" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="付款开户行" DataField="fkkhh" HeaderStyle-Width="10%" />
                
            </Columns>
        
        </asp:GridView>
        </asp:Panel>
    <cc1:xsPageControl ID="xsPage" runat="server" OnPageChanged="xsPage_PageChanged">
        </cc1:xsPageControl>
    </div>
    </form>
</body>
</html>
