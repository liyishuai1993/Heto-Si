﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XshtGl.aspx.cs" Inherits="XSSystem.Page.P_HTGL.XshtGl" %>
<%@ Register Assembly="xsFramework.UserControl" Namespace="xsFramework.UserControl.Pager"
    TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <script src="../../js/FormStyle.js"></script>
    <link href="../../style/sysCss.css" rel="stylesheet" />
    <link href="../../style/FormStyle.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="divcss5" style="margin-bottom:15px;width:1200px">
            <span>
                合同编号<asp:TextBox id="tbhtbh" runat="server" Width="80px"></asp:TextBox>
                签订日期范围<asp:TextBox ID="qdfwQ" runat="server" Text="" onClick="WdatePicker()" Width="90px"></asp:TextBox>
                <asp:TextBox ID="qdfwZ" runat="server" Text="" onClick="WdatePicker()" Width="90px"></asp:TextBox>
                需方名称<asp:TextBox id="tbxfmc" runat="server" Width="90px"></asp:TextBox>
                合同煤价<asp:TextBox id="tbkpmj" runat="server" Width="80px"></asp:TextBox>
                审核状态<asp:TextBox id="tbzt" runat="server" Width="50px"></asp:TextBox>
                <asp:Button ID="btnQuery" runat="server" Text="查询" CssClass="button" OnClick="btnQuery_Click" />
                <asp:Button ID="BtnAdd" runat="server" Text="新增" CssClass="button" OnClick="btnAdd_Click" />
                <asp:Button ID="BtnDel" runat="server" Text="删除" CssClass="button" OnClick="btnDel_Click" />
    </span>
        </div>
    <div>
    <asp:Panel ID="Panel1" runat="server" Height="900px" ScrollBars="Auto" Width="1500px">
        <asp:GridView ID="GridOrder" runat="server" CssClass="xs_table" AutoGenerateColumns="False"
            ShowHeaderWhenEmpty="True" EmptyDataText="查无订单" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None" >
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField  HeaderText="&lt;input type='checkbox' id='chk' name='chk' onclick='checkJs(this.checked);'  /&gt;全选" FooterText="全选">
                <ItemTemplate>
                    <input type="checkbox" id="checkboxname" name="checkboxname" value='<%# DataBinder.Eval(Container.DataItem, "htbh")%>' onclick='SingleCheckJs();' />
                </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Left" Width="5%" />
                <ItemStyle HorizontalAlign="Left" Width="5%" />
                </asp:TemplateField>
                <asp:BoundField DataField="htbh"  HeaderText="合同编号">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="qdrq"  HeaderText="签订日期">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="gfmc"  HeaderText="供方名称">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="xfmc"  HeaderText="需方名称">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="kpxx"  HeaderText="开票类型">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="hkjsfs"  HeaderText="货款结算方式">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="yffkfs"  HeaderText="运费付款方式">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="shzt"  HeaderText="审核状态">              
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="zxzt"  HeaderText="执行状态">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:TemplateField  HeaderText="操作">
                    <ItemTemplate>
                       <%-- <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("htbh") %>' CssClass="buttonCancle" OnClick="btnDelete_Click" OnClientClick="return confirm('是否删除？')" Text="删除" />--%>
                        <asp:Button ID="btnUpdate" runat="server" actionid="04" CommandArgument='<%#Eval("htbh") %>' CssClass="buttonCancle" OnClick="btnUpdate_Click" OnClientClick="return confirm('是否进行修改？')" Text="查看详情" />
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
        <cc1:xsPageControl ID="xsPage" runat="server" OnPageChanged="xsPage_PageChanged">
        </cc1:xsPageControl>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
