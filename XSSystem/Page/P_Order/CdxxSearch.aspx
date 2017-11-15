<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="CdxxSearch.aspx.cs" Inherits="XSSystem.Page.P_Order.CdxxSearch" %>

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
        <%--<p><input type="button" id="btnAdd" class="button" value="新增" actionid="02" onclick="seturl('/Page/P_Order/Cdxx.aspx')" /></p>--%>
    <div>
    <asp:Panel ID="Panel1" runat="server" Height="185px" ScrollBars="Auto" Width="1500px">
        <asp:GridView ID="GridOrder" runat="server" CssClass="xs_table" AutoGenerateColumns="false"
            ShowHeaderWhenEmpty="true" EmptyDataText="无数据" Width="100%">
            <Columns>
                <asp:BoundField HeaderText="序号" DataField="xh" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="车队名称" DataField="cdmc" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="车队编码" DataField="cdbh" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="账号名称" DataField="zhmc" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="开户银行" DataField="khyh" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="银行账号" DataField="yhzh" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="联系账号" DataField="lxzh" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="路耗" DataField="lh" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="运价更新通知" DataField="yjgxtz" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="禁用" DataField="jy" HeaderStyle-Width="10%" />
            </Columns>
        
        </asp:GridView>
        </asp:Panel>
    <cc1:xsPageControl ID="xsPage" runat="server" OnPageChanged="xsPage_PageChanged">
        </cc1:xsPageControl>
    </div>
    </form>
</body>
</html>
