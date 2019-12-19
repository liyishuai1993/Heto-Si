<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pmdlr.aspx.cs" Inherits="XSSystem.Page.P_Order.Pmdlr" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>配煤单录入</title>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <script src="../../js/FormStyle.js"></script>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            border-style: none;
            font-family: 宋体, Arial, Helvetica, sans-serif;
            line-height: normal;
            background-color: #33CCFF;
        }

        .auto-style3 {
            height: 20px;
            width: 640px;
            text-align: right;
        }

        .Wdate {
        }

        .auto-style4 {
            text-align: left;
        }

        .auto-style5 {
            height: auto;
            width: auto;
            text-align: center;
        }
    </style>
</head>
<body style="height: auto; width: auto">
    <form id="form1" runat="server">
        <div>
            <p class="auto-style5">配煤单录入</p>
            <div>
                <telerik:RadScriptManager runat="server" ID="RadScriptManager1"></telerik:RadScriptManager>
                <p>基本信息</p>
                <table border="0" aria-haspopup="False" class="auto-style1" style="width: 800px">
                    <tr>
                        <td class="auto-style3"><span>配煤编号</span><asp:TextBox ID="bh" valued="must1" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                        <td class="auto-style3"><span>配煤日期</span><asp:TextBox ID="pmrq" valued="must1" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td class="auto-style3">生产煤场<telerik:RadComboBox RenderMode="Lightweight" ID="tk_scmc" runat="server" Width="284px" Height="200px"
                            EmptyMessage="请输入生产煤场" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="生产煤场" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                        <td class="auto-style3">公司名称<telerik:RadComboBox RenderMode="Lightweight" ID="tk_gsmc" runat="server" Width="284px" Height="200px"
                            EmptyMessage="请输入公司名称" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="公司名称" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                    </tr>
                </table>
            </div>


            <div>
                <p class="auto-style5">原料煤种</p>
                <p>
                    <asp:Button ID="ylmz_tjje" runat="server" Text="添加原料" OnClick="ylmz_tjje_Click" />&nbsp&nbsp 
                原料
                <asp:DropDownList ID="YLDropDownList" runat="server" Height="25px" Width="80px">
                    <asp:ListItem>请选择</asp:ListItem>
                </asp:DropDownList>
                    原料吨数<asp:TextBox ID="ylds" runat="server" Height="16px" Width="50px" CssClass="auto-style4" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                    成本单价<asp:TextBox ID="cbdj" runat="server" Height="16px" Width="50px" CssClass="auto-style4" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                    配煤费(元/吨)<asp:TextBox ID="pmf" runat="server" Height="16px" Width="50px" CssClass="auto-style4" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                    金额(元)<asp:TextBox ID="je" runat="server" Height="16px" Width="50px" CssClass="auto-style4" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                </p>

                <asp:GridView ID="GridView_YLMZ" runat="server" CssClass="xs_table" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                            <HeaderTemplate>
                                序号
                            </HeaderTemplate>
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="原料" DataField="yl">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="原料吨数" DataField="ylds">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="成本单价" DataField="cbdj">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="配煤费(元/吨)" DataField="pmf">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="金额(元)" DataField="je">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderStyle-Width="5%" HeaderText="删除">
                                <ItemTemplate>
                                    <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument=' <%#Container.DataItemIndex%>' CssClass="buttonCancle" OnClick="DelJgxx" OnClientClick="return confirm('是否删除？')" Text="删除" />
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

            </div>

            <div>
                <p class="auto-style5">产出煤种</p>
                <p>
                    <asp:Button ID="ccmz_tjje" runat="server" Text="添加产品" OnClick="ccmz_tjje_Click" />&nbsp&nbsp 
                产品
                <asp:DropDownList ID="CPDropDownList" runat="server" Height="25px" Width="80px">
                    <asp:ListItem>请选择</asp:ListItem>
                </asp:DropDownList>
                    产出吨数<asp:TextBox ID="ccds" runat="server" Height="16px" Width="50px" CssClass="auto-style4"></asp:TextBox>
                    金额(元)<asp:TextBox ID="je2" runat="server" Height="16px" Width="50px" CssClass="auto-style4"></asp:TextBox>
                    成本单价(元/吨)<asp:TextBox ID="cbdj2" runat="server" Height="16px" Width="50px" CssClass="auto-style4"></asp:TextBox>
                </p>

                <asp:GridView ID="CPGridView" runat="server" CssClass="xs_table" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                            <HeaderTemplate>
                                序号
                            </HeaderTemplate>
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="产品" DataField="cp">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="产出吨数" DataField="ccds">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="金额(元)" DataField="je">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="成本单价(元/吨)" DataField="cbdj2">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="操作">
                            <ItemTemplate>
                                <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument=' <%#Container.DataItemIndex %>' CssClass="buttonCancle" OnClick="btnDelete_Click" OnClientClick="return confirm('是否删除？')" Text="删除" />
                                <%--<asp:Button ID="btnShenghe" runat="server" actionid="03" CommandArgument='<%#Eval("htbh") %>' CssClass="buttonCancle" OnClick="btnShengHe_Click" OnClientClick="return confirm('是否确定合同通过审核？')" Text="审核" />--%>
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

            </div>

            <p class="auto-style5">
                <asp:Button ID="add" Text="保存" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp 
            <asp:Button ID="update" Text="修改" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="update_Click"></asp:Button>&nbsp     
            <asp:Button ID="close" Text="关闭" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="close_Click"></asp:Button>&nbsp
            </p>
        </div>
    </form>
</body>
</html>
