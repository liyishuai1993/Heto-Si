﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TyxsckdGl.aspx.cs" Inherits="XSSystem.Page.P_CKGL.TyxsckdGl" %>
<%@ Register Assembly="xsFramework.UserControl" Namespace="xsFramework.UserControl.Pager"
    TagPrefix="cc1" %>

<%@ OutputCache Location="None" VaryByParam="None"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <script src="../../js/FormStyle.js"></script>
    <script type="text/javascript">

    </script>
    <link href="../../style/sysCss.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
        <%--<span>入库磅单号</span>
        <asp:TextBox id="tbrkbdh" runat="server" Width="140px"></asp:TextBox>--%>
<%--        <span>名称：</span>
                <asp:TextBox ID="txtNewName" runat="server" CssClass="inputText" Visible="false"></asp:TextBox>
                <asp:Dropdownlist id="ddshzt" runat="server" autopostback="true" onselectedindexchanged="ddlnewtype_selectedindexchanged">
            <asp:ListItem>已审核</asp:ListItem>
            <asp:ListItem>未审核</asp:ListItem>--%>
        <%--</asp:Dropdownlist>--%>
                发车日期<asp:TextBox ID="qdfwQ" runat="server" Text="" onClick="WdatePicker()" Width="140px"></asp:TextBox>～
                <asp:TextBox ID="qdfwZ" runat="server" Text="" onClick="WdatePicker()" Width="140px"></asp:TextBox>
                受托方<asp:TextBox id="tbstf" runat="server" Width="140px"></asp:TextBox>
                装车站<asp:TextBox id="tbzcz" runat="server" Width="140px"></asp:TextBox>
                终到站<asp:TextBox id="tbzdz" runat="server" Width="140px"></asp:TextBox>
                箱号<asp:TextBox id="tbxh" runat="server" Width="140px"></asp:TextBox>
<%--                状态<asp:TextBox id="tbzt" runat="server" Width="140px"></asp:TextBox>--%>
                <asp:Button ID="btnQuery" runat="server" Text="查询" CssClass="button" OnClick="btnQuery_Click" />
                <asp:Button ID="BtnAdd" runat="server" Text="新增" CssClass="button" OnClick="btnAdd_Click" />
                <asp:Button ID="BtnDel" runat="server" Text="删除" CssClass="button" OnClick="btnDel_Click" />
                <%--<asp:Button ID="BtnUpdate" runat="server" Text="审核" CssClass="button" OnClick="btnQuery_Click" />--%>
    </p>
        </div>
    <div>
    <asp:Panel ID="Panel1" runat="server" Height="900px" ScrollBars="Auto" Width="1500px">
        <asp:GridView ID="GridOrder" runat="server" CssClass="xs_table" AutoGenerateColumns="False"
            ShowHeaderWhenEmpty="True" EmptyDataText="查无订单" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField  HeaderText="&lt;input type='checkbox' id='chk' name='chk' onclick='checkJs(this.checked);'  /&gt;全选" FooterText="全选">
                <ItemTemplate>
                    <input type="checkbox" id="checkboxname" name="checkboxname" value='<%# DataBinder.Eval(Container.DataItem, "bh")%>' onclick='SingleCheckJs();' />
                </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Left" Width="5%" />
                <ItemStyle HorizontalAlign="Left" Width="5%" />
                </asp:TemplateField>
                <asp:BoundField DataField="bh"  HeaderText="编号">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="htbh"  HeaderText="合同编号">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="stf"  HeaderText="受托方">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="zcz"  HeaderText="装车站">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="zdz"  HeaderText="终到站">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>             
                <asp:TemplateField  HeaderText="详情">
                    <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                    <ItemTemplate>                                 
                        <asp:Button ID="btnUpdate" runat="server" actionid="04" CommandArgument='<%#Eval("htbh") %>' CssClass="buttonCancle" OnClick="btnUpdate_Click" OnClientClick="return confirm('是否进行修改？')" Text="查看详情" />
                        <%--<asp:Button ID="btnShenghe" runat="server" actionid="03" CommandArgument='<%#Eval("htbh") %>' CssClass="buttonCancle" OnClick="btnShengHe_Click" OnClientClick="return confirm('是否确定合同通过审核？')" Text="审核" />--%>
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