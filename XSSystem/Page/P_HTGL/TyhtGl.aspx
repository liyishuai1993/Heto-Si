<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TyhtGl.aspx.cs" Inherits="XSSystem.Page.P_HTGL.TyhtGl" %>
<%@ Register Assembly="xsFramework.UserControl" Namespace="xsFramework.UserControl.Pager"
    TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../style/sysCss.css" rel="stylesheet" />
    <script src="../../js/FormStyle.js"></script>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
        
                合同编号<asp:TextBox id="tbhtbh" runat="server" Width="100px"></asp:TextBox>
                签订日期范围<asp:TextBox ID="qdfwQ" runat="server" Text="" onClick="WdatePicker()" Width="100px"></asp:TextBox>-<asp:TextBox ID="qdfwZ" runat="server" Text="" onClick="WdatePicker()" Width="100px"></asp:TextBox>
                <%--委托方<asp:TextBox id="tbwtf" runat="server" Width="140px"></asp:TextBox>--%>
                受托方<asp:TextBox id="tbstf" runat="server" Width="100px"></asp:TextBox>
                装车站<asp:TextBox id="tbzcz" runat="server" Width="140px"></asp:TextBox>
                终到站<asp:TextBox id="tbzdz" runat="server" Width="140px"></asp:TextBox>
                箱类型<asp:TextBox id="tbxlx" runat="server" Width="60px"></asp:TextBox>
                审核状态<asp:TextBox id="tbzt" runat="server" Width="60px"></asp:TextBox>
                <%--铁路运费<asp:TextBox id="tbtlyf" runat="server" Width="140px"></asp:TextBox>--%>
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
                    <input type="checkbox" id="checkboxname" name="checkboxname" value='<%# DataBinder.Eval(Container.DataItem, "htbh")%>' onclick='SingleCheckJs();' />
                </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Left" Width="5%" />
                <ItemStyle HorizontalAlign="Left" Width="5%" />
                </asp:TemplateField>
                <asp:BoundField DataField="htbh"  HeaderText="合同编号">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="htlx"  HeaderText="合同类型">
                    <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="qdrq"  HeaderText="签订日期">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="wtf"  HeaderText="委托方">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="stf"  HeaderText="受托方">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
               <%-- <asp:BoundField DataField="fmmc" HeaderStyle-Width="5%" HeaderText="发煤煤场">
                <HeaderStyle Width="5%" />
                </asp:BoundField>--%>
                <%--<asp:BoundField DataField="wlmc" HeaderStyle-Width="5%" HeaderText="物料名称">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="zxqxQ" HeaderStyle-Width="5%" HeaderText="执行期限起">
                <HeaderStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="zxqxZ" HeaderStyle-Width="5%" HeaderText="执行期限止">
                <HeaderStyle Width="5%" />
                </asp:BoundField>--%>
                <asp:BoundField DataField="zcz"  HeaderText="装车站">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="zdz"  HeaderText="终到站">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="xlx" HeaderText="箱类型">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
               <%-- <asp:BoundField DataField="sl" HeaderStyle-Width="5%" HeaderText="数量">
                <HeaderStyle Width="5%" />
                </asp:BoundField>--%>
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
                      <%--  <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("htbh") %>' CssClass="buttonCancle" OnClick="btnDelete_Click" OnClientClick="return confirm('是否删除？')" Text="删除" />--%>
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
        </asp:Panel>
    <cc1:xsPageControl ID="xsPage" runat="server" OnPageChanged="xsPage_PageChanged">
        </cc1:xsPageControl>
    </div>
    </form>
</body>
</html>

