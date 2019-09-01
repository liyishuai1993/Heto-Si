<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TydbckdGl.aspx.cs" Inherits="XSSystem.Page.P_DBGL.TydbckdGl" %>
<%@ Register Assembly="xsFramework.UserControl" Namespace="xsFramework.UserControl.Pager"
    TagPrefix="cc1" %>

<%@ OutputCache Location="None" VaryByParam="None"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <script src="../../js/FormStyle.js"></script>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
    <link href="../../style/sysCss.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="divcss5" style="margin-bottom:15px;width:1500px">
            <span>
                <asp:Button ID="allQuery" runat="server" Text="查看全部" CssClass="button" OnClick="allQuery_Click" />
                <%--发煤煤场<asp:TextBox id="tbfmmc" runat="server" Width="100px"></asp:TextBox>--%>
                <%--发车时间<asp:TextBox ID="qdfwQ" runat="server" Text="" onClick="WdatePicker()" Width="90px"></asp:TextBox>--%>
                <%--物料名称<asp:TextBox id="tbwlmc" runat="server" Width="80px"></asp:TextBox>
                装车站<asp:TextBox id="tbzcz" runat="server" Width="100px"></asp:TextBox>
                终到站<asp:TextBox id="tbzdz" runat="server" Width="100px"></asp:TextBox>
                箱类型 <asp:TextBox id="tbxlx" runat="server" Width="80px"></asp:TextBox>
                箱号<asp:TextBox id="tbxh" runat="server" Width="60px"></asp:TextBox>
                卸货仓库<asp:TextBox id="tbxhck" runat="server" Width="100px"></asp:TextBox>--%>
                <asp:DropDownList id="con" runat="server" height="25px" Width ="80px">
                        <asp:ListItem Value="and">关联</asp:ListItem>
                        <asp:ListItem Value="or">不关联</asp:ListItem>
                        </asp:DropDownList>
                筛选条件<asp:DropDownList id="sxtj" runat="server" height="25px" Width ="80px">
                        <asp:ListItem Value="bh">编号</asp:ListItem>
                        <asp:ListItem Value="gsmc">公司名称</asp:ListItem>
                        <asp:ListItem Value="wlmc">物料名称</asp:ListItem>
                        <asp:ListItem Value="htbh">合同编号</asp:ListItem>
                        </asp:DropDownList>
                <asp:TextBox id="tjz" runat="server" Width="284px"></asp:TextBox><asp:Button ID="btnQuery" runat="server" Text="查询" CssClass="button" OnClick="btnQuery_Click" />
                <asp:Button ID="BtnAdd" runat="server" Text="新增" CssClass="button" OnClick="btnAdd_Click" />
                <asp:Button ID="BtnDel" runat="server" Text="删除" CssClass="button" OnClick="btnDel_Click" />
    </span>
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
                <asp:BoundField DataField="fmmc"  HeaderText="发煤煤场">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                 <asp:BoundField DataField="wlmc"  HeaderText="物料名称">
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
                 <asp:BoundField DataField="xlx"  HeaderText="箱类型">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:TemplateField  HeaderText="详情">
                    <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                    <ItemTemplate>                                 
                        <asp:Button ID="btnUpdate" runat="server" actionid="04" CommandArgument='<%#Eval("bh") %>' CssClass="buttonCancle" OnClick="btnUpdate_Click" OnClientClick="return confirm('是否进行修改？')" Text="查看详情" />
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