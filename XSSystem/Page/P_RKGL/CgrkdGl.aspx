﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CgrkdGl.aspx.cs" Inherits="XSSystem.Page.P_RKGL.CgrkdGl" %>
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
                <%--供方名称<asp:TextBox id="tbgfmc" runat="server" Width="80px"></asp:TextBox>--%>
                <asp:Button ID="allQuery" runat="server" Text="查看全部" CssClass="button" OnClick="allQuery_Click" />
                装车日期<asp:TextBox ID="qdfwQ" runat="server" Text="" onClick="WdatePicker()" Width="70px"></asp:TextBox>
                -<asp:TextBox ID="qdfwZ" runat="server" Text="" onClick="WdatePicker()" Width="70px"></asp:TextBox>
                <%--物料名称<asp:TextBox id="tbwlmc" runat="server" Width="80px"></asp:TextBox>
                煤价<asp:TextBox id="tbmj" runat="server" Width="50px"></asp:TextBox>
                车号<asp:TextBox id="tbch" runat="server" Width="80px"></asp:TextBox>
                装车净重<asp:TextBox id="tbzcjz" runat="server" Width="60px"></asp:TextBox>
                入库磅单号<asp:TextBox id="tbrkbdh" runat="server" Width="80px"></asp:TextBox>
                入库煤场<asp:TextBox id="tbrkmc" runat="server" Width="80px"></asp:TextBox>
                入库净重<asp:TextBox id="tbrkjz" runat="server" Width="50px"></asp:TextBox>--%>
                <asp:DropDownList id="con" runat="server" height="25px" Width ="80px">
                        <asp:ListItem Value="and">关联</asp:ListItem>
                        <asp:ListItem Value="or">不关联</asp:ListItem>
                        </asp:DropDownList>
                筛选条件<asp:DropDownList id="sxtj" runat="server" height="25px" Width ="80px">
                        <asp:ListItem Value="hth">合同号</asp:ListItem>
                        <asp:ListItem Value="gf">供方</asp:ListItem>
                        <asp:ListItem Value="wlmc">物料名称</asp:ListItem>
                        <asp:ListItem Value="ch">车号</asp:ListItem>
                        <asp:ListItem Value="rkbdh">入库磅单号</asp:ListItem>
                        <asp:ListItem Value="shzt">审核状态</asp:ListItem>
                        </asp:DropDownList>
                <asp:TextBox id="tjz" runat="server" Width="284px"></asp:TextBox>
                <asp:Button ID="btnQuery" runat="server" Text="查询" CssClass="button" OnClick="btnQuery_Click" />
                <asp:Button ID="BtnAdd" runat="server" Text="新增" CssClass="button" OnClick="btnAdd_Click" />
                <asp:Button ID="BtnDel" runat="server" Text="删除" CssClass="button" OnClick="btnDel_Click" />
                <asp:TextBox id="tj" runat="server" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                <asp:Button ID="Tj_Btn" runat="server" Text="调价" CssClass="button" OnClick="Tj_Btn_Click" OnClientClick="return confirm('是否确定对选中项进行改价？')"/>
    </span>
        </div>
    <div>
    <asp:Panel ID="Panel1" runat="server" Height="900px" ScrollBars="Auto" Width="1500px">
        <asp:GridView ID="GridOrder" runat="server" CssClass="xs_table" AutoGenerateColumns="False"
            ShowHeaderWhenEmpty="True" EmptyDataText="查无订单" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                    <input type="checkbox" id="checkboxname" name="checkboxname" value='<%# DataBinder.Eval(Container.DataItem, "hth")%>' onclick='SingleCheckJs();' />
                </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Left" Width="5%" />
                <ItemStyle HorizontalAlign="Left" Width="5%" />
                </asp:TemplateField>
                <asp:BoundField DataField="hth"  HeaderText="合同号">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="gf"  HeaderText="供方">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="xf"  HeaderText="需方">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="wlmc"  HeaderText="物料名称">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="mj"  HeaderText="煤价">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="zcrq"  HeaderText="装车日期" DataFormatString="{0:yyyy-MM-dd}">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="ch"  HeaderText="车号">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="zcjz"  HeaderText="装车净重">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="jsmk"  HeaderText="结算煤款">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="rkrq"  HeaderText="入库日期" DataFormatString="{0:yyyy-MM-dd}">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="rkbdh"  HeaderText="入库磅单号">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="rkmc"  HeaderText="入库煤场">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="rkjz"  HeaderText="入库净重">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="yj"  HeaderText="运价">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="jsyf"  HeaderText="结算运费">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="shzt"  HeaderText="审核状态">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="yfjszt"  HeaderText="运费结算状态">
                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:BoundField>
                <asp:TemplateField  HeaderText="详情">
                    <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                    <ItemTemplate>                                 
                        <asp:Button ID="btnUpdate" runat="server" actionid="04" CommandArgument='<%#Eval("hth") %>' CssClass="buttonCancle" OnClick="btnUpdate_Click" OnClientClick="return confirm('是否进行修改？')" Text="查看详情" />
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
