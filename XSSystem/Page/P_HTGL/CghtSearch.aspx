<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CghtSearch.aspx.cs" Inherits="XSSystem.Page.P_Order.CghtSearch" %>

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
        <span>类别</span>
        <asp:Dropdownlist id="ddlnewtype" runat="server" autopostback="true" onselectedindexchanged="ddlnewtype_selectedindexchanged"></asp:Dropdownlist>
        <span>名称：</span><asp:TextBox ID="txtNewName" runat="server" CssClass="inputText"></asp:TextBox><asp:Button
            ID="btnQuery" runat="server" Text="查询" CssClass="button"
            OnClick="btnQuery_Click" />
    </p>
        </div>
    <div>
    <asp:Panel ID="Panel1" runat="server" Height="185px" ScrollBars="Auto" Width="1500px">
        <asp:GridView ID="GridOrder" runat="server" CssClass="xs_table" AutoGenerateColumns="false"
            ShowHeaderWhenEmpty="true" EmptyDataText="查无订单" Width="120%">
            <Columns>

                <asp:BoundField HeaderText="订单号" DataField="ddh" HeaderStyle-Width="10%" />
                <asp:BoundField HeaderText="用户" DataField="yh" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="车号" DataField="ch" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="发库仓库" DataField="fkck" HeaderStyle-Width="5%" />

                <asp:BoundField HeaderText="品名" DataField="pm" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="出库毛重" DataField="ckmz" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="是否加榜" DataField="jb" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="出库单净重" DataField="ckdjz" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="出库净重2" DataField="ckjz2" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="到货日期" DataField="dhrq" HeaderStyle-Width="8%" />
                <asp:BoundField HeaderText="收货单位" DataField="shdw" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="到货吨位" DataField="dhdw" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="结算吨数" DataField="jsds" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="单价" DataField="dj" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="估算金额" DataField="gsje" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="对账单金额" DataField="dzdje" HeaderStyle-Width="5%" />

                 <asp:BoundField HeaderText="收款金额" DataField="skje" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="开票金额" DataField="kpje" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="估算结余" DataField="gsjy" HeaderStyle-Width="5%" />
                <asp:BoundField HeaderText="货票或收款时间" DataField="kphsksj" HeaderStyle-Width="8%" />
                <asp:TemplateField HeaderText="操作" HeaderStyle-Width="5%">
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" Text="删除" CssClass="buttonCancle" CommandArgument='<%#Eval("oid") %>'
                            OnClientClick="return confirm('是否删除？')" actionid="04" OnClick="btnDelete_Click" />

                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        
        </asp:GridView>
        </asp:Panel>
    <cc1:xsPageControl ID="xsPage" runat="server" OnPageChanged="xsPage_PageChanged">
        </cc1:xsPageControl>
    </div>
    </form>
</body>
</html>

