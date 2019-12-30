<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InfomationGl.aspx.cs" Inherits="XSSystem.Page.P_System.InfomationGl" %>
<%@ Register Assembly="xsFramework.UserControl" Namespace="xsFramework.UserControl.Pager"
    TagPrefix="cc1" %>

<%@ OutputCache Location="None" VaryByParam="None"%>
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
        <div class="divcss5" style="width:1200px;margin-bottom:15px">
            <span>
<%--                合同编号<asp:TextBox id="tbhtbh" runat="server" Width="80px"></asp:TextBox>--%>
<%--                <asp:Button ID="allQuery" runat="server" Text="查看全部" CssClass="button" OnClick="allQuery_Click" />
                签订日期范围<asp:TextBox ID="qdfwQ" runat="server" Text="" onClick="WdatePicker()" Width="90px"></asp:TextBox>
                -<asp:TextBox ID="qdfwZ" runat="server" Text="" onClick="WdatePicker()" Width="90px"></asp:TextBox>
<%--                供方名称<asp:TextBox id="tbgfmc" runat="server" Width="90px"></asp:TextBox>              
                合同煤价<asp:TextBox id="tbkpmj" runat="server" Width="80px"></asp:TextBox>
                审核状态<asp:TextBox id="tbzt" runat="server" Width="50px"></asp:TextBox>--%>
<%--                <asp:DropDownList id="con" runat="server" height="25px" Width ="80px">
                        <asp:ListItem Value="and">关联</asp:ListItem>
                        <asp:ListItem Value="or">不关联</asp:ListItem>
                        </asp:DropDownList>--%> 
                筛选条件<asp:DropDownList id="sxtj" runat="server" height="25px" Width ="80px">
                        <asp:ListItem Value="xs_MeiZhongTable">物料名称</asp:ListItem>
                        <asp:ListItem Value="xs_WangLaiDanWei">往来单位</asp:ListItem>
                        <asp:ListItem Value="xs_YuanLiaoTable">煤场</asp:ListItem>
                        <asp:ListItem Value="xs_ZhangHu">账户</asp:ListItem>
                        <asp:ListItem Value="xs_YuanGong">人员</asp:ListItem>
                        </asp:DropDownList>
                <%--<asp:TextBox id="tjz" runat="server" Width="284px"></asp:TextBox>--%>
                <asp:Button ID="btnQuery" runat="server" Text="查询" CssClass="button" OnClick="btnQuery_Click" />
                <asp:Button ID="BtnDel" runat="server" Text="删除" CssClass="button" OnClick="btnDelete_Click" />
    </span>
        </div>
    <div style="overflow-y: scroll; height: 900px;width:1200px">
        <asp:GridView ID="GridOrder" runat="server" CssClass="xs_table" AutoGenerateColumns="False" AllowSorting="true"
            ShowHeaderWhenEmpty="True" EmptyDataText="查无信息" Width="85%" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField  ItemStyle-HorizontalAlign="Center">
                    <HeaderTemplate>
                        序号
                    </HeaderTemplate>
                    <ItemTemplate>
                        <%#Container.DataItemIndex+1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField  HeaderText="&lt;input type='checkbox' id='chk' name='chk' onclick='checkJs(this.checked);'  /&gt;全选" FooterText="全选">
                <ItemTemplate>
                    <input type="checkbox" id="checkboxname" name="checkboxname" value='<%# DataBinder.Eval(Container.DataItem, "id")%>' onclick='SingleCheckJs();' />
                </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Left" Width="5%" />
                <ItemStyle HorizontalAlign="Left" Width="5%" />
                </asp:TemplateField>
                <asp:BoundField DataField="nr"  HeaderText="内容">
                <HeaderStyle HorizontalAlign="Left" Width="95%" />
                <ItemStyle HorizontalAlign="Left" Width="95%" />
                </asp:BoundField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"  CssClass="Freezing"/>
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
    
    </div>
    </form>
</body>
</html>
