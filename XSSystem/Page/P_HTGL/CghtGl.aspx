<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CghtGl.aspx.cs" Inherits="XSSystem.Page.P_HTGL.CghtGl" %>
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
        <span>合同类型</span>
        <asp:Dropdownlist id="ddhtlx" runat="server" autopostback="true" onselectedindexchanged="ddlnewtype_selectedindexchanged">
            <asp:ListItem>预付款</asp:ListItem>
            <asp:ListItem>直供赊销</asp:ListItem>
            <asp:ListItem>超付</asp:ListItem>
        </asp:Dropdownlist>
        <span>名称：</span>
                <asp:TextBox ID="txtNewName" runat="server" CssClass="inputText" Visible="false"></asp:TextBox>
                <asp:Dropdownlist id="ddshzt" runat="server" autopostback="true" onselectedindexchanged="ddlnewtype_selectedindexchanged">
            <asp:ListItem>执行中</asp:ListItem>
            <asp:ListItem>已审核</asp:ListItem>
            <asp:ListItem>未审核</asp:ListItem>
        </asp:Dropdownlist>
                签订范围<asp:TextBox ID="qdfwQ" runat="server" Text="" onClick="WdatePicker()" Width="140px"></asp:TextBox>
                <asp:TextBox ID="qdfwZ" runat="server" Text="" onClick="WdatePicker()" Width="140px"></asp:TextBox>
                <asp:Button ID="btnQuery" runat="server" Text="查询" CssClass="button" OnClick="btnQuery_Click" />
                <asp:Button ID="Button1" runat="server" Text="新增" CssClass="button" OnClick="btnQuery_Click" />
                <asp:Button ID="Button2" runat="server" Text="审核" CssClass="button" OnClick="btnQuery_Click" />
    </p>
        </div>
    <div>
    <asp:Panel ID="Panel1" runat="server" Height="185px" ScrollBars="Auto" Width="1500px">
        <asp:GridView ID="GridOrder" runat="server" CssClass="xs_table" AutoGenerateColumns="False"
            ShowHeaderWhenEmpty="True" EmptyDataText="查无订单" Width="120%" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="htbh" HeaderStyle-Width="5%" HeaderText="合同编号">
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
                <asp:BoundField DataField="gfmc" HeaderStyle-Width="5%" HeaderText="供方名称">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="xfmc" HeaderStyle-Width="5%" HeaderText="需方名称">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="hkjsyj" HeaderStyle-Width="5%" HeaderText="货款结算依据">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="hklhlx" HeaderStyle-Width="5%" HeaderText="货款路耗类型">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="hklhbz" HeaderStyle-Width="5%" HeaderText="货款路耗标准">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="kpxx" HeaderStyle-Width="8%" HeaderText="开票类型">
                <HeaderStyle Width="8%" />
                </asp:BoundField>
                <asp:BoundField DataField="jhsjQ" HeaderStyle-Width="5%" HeaderText="交货时间起">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="jhsjZ" HeaderStyle-Width="5%" HeaderText="交货时间止">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="hkjsfs" HeaderStyle-Width="5%" HeaderText="货款结算方式">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="jhdd" HeaderStyle-Width="5%" HeaderText="交货地点">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="yffkfs" HeaderStyle-Width="5%" HeaderText="运费付款方式">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="mkmc" HeaderStyle-Width="5%" HeaderText="煤矿名称">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="bz" HeaderStyle-Width="5%" HeaderText="备注">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:TemplateField HeaderStyle-Width="10%" HeaderText="操作">
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("htbh") %>' CssClass="buttonCancle" OnClick="btnDelete_Click" OnClientClick="return confirm('是否删除？')" Text="删除" />
                        <asp:Button ID="btnUpdate" runat="server" actionid="03" CommandArgument='<%#Eval("htbh") %>' CssClass="buttonCancle" OnClick="btnDelete_Click" OnClientClick="return confirm('是否修改z？')" Text="修改" />
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
        </asp:Panel>
    <cc1:xsPageControl ID="xsPage" runat="server" OnPageChanged="xsPage_PageChanged">
        </cc1:xsPageControl>
    </div>
    </form>
</body>
</html>