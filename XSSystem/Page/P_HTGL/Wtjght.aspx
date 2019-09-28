<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wtjght.aspx.cs" Inherits="XSSystem.Page.P_Order.Wtjght" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>委托加工合同</title>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <link href="../../style/sysCss.css" rel="stylesheet" />
    <script src="../../js/FormStyle.js"></script>
    <style type="text/css">
        .auto-style3 {
            height: auto;
            width: 400px;
            text-align: right;
        }

        .Wdate {
        }

        .auto-style5 {
            height: auto;
            width: auto;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p class="auto-style5">委托加工合同</p>
            <telerik:RadScriptManager runat="server" ID="RadScriptManager1"></telerik:RadScriptManager>
            <div>
                <p>基本信息</p>
                <table border="0" aria-haspopup="False" class="auto-style1" style="width: 1200px; font-family: 宋体, Arial, Helvetica, sans-serif; line-height: normal; background-color: #33CCFF;">
                    <%--<table border="1" aria-haspopup="False" class="xs_table" style="width: 1200px"  >--%>
                    <tr>
                        <td class="auto-style3">合同编号<asp:TextBox ID="htbh" runat="server" Height="16px" Width="284px" Enabled="false"></asp:TextBox></td>
                        <td class="auto-style3">合同类型<asp:DropDownList ID="htlx" runat="server" Height="25px" Width="284px">
                            <asp:ListItem>预付款</asp:ListItem>
                            <asp:ListItem>直供赊销</asp:ListItem>
                            <asp:ListItem>超付</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                        <td class="auto-style3"><span>签订日期</span>
                            <asp:TextBox ID="qdrq" runat="server" Text="" name="签订日期" valued="must1" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">委托方<telerik:RadComboBox RenderMode="Lightweight" ID="tk_wtf" runat="server" Width="284px" Height="200px"
                            EmptyMessage="请输入委托方" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="委托方" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                        <td class="auto-style3">受托方<telerik:RadComboBox RenderMode="Lightweight" ID="tk_stf" runat="server" Width="284px" Height="200px"
                            EmptyMessage="请输入受托方" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="受托方" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                        <td class="auto-style3"></td>
                    </tr>

                    <tr>
                        <td class="auto-style3">开票类型<asp:DropDownList ID="kplx" runat="server" Height="25px" Width="284px">
                            <asp:ListItem>无票</asp:ListItem>
                            <asp:ListItem>一票</asp:ListItem>
                            <asp:ListItem>两票</asp:ListItem>
                            <asp:ListItem>原票原转</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                        <td class="auto-style3"><span>执行期限</span><asp:TextBox ID="zxqxQ" name="执行期限起" valued="must1" runat="server" Text="" onClick="WdatePicker()" Width="140px"></asp:TextBox>
                            -<asp:TextBox ID="zxqxZ" name="执行期限止" valued="must1" runat="server" Text="" onClick="WdatePicker()" Width="140px"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>

                </table>
            </div>

            <div style="margin-top: 15px">
                <div class="divcss5">
                    <p>价格信息<asp:Button ID="Button1" runat="server" Text="新增记录" OnClick="AddJgxx" />
                    </p>
                    <p>
                        物料名称<asp:TextBox ID="wlmc" valued="must2" name="物料名称" runat="server" Height="16px" Width="150px"></asp:TextBox>
                        加工费(元/吨)<asp:TextBox ID="jgf" valued="must2" name="加工费" runat="server" Height="16px" Width="150px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        出煤指标<asp:TextBox ID="cmzb" valued="must2" name="出煤指标" runat="server" Height="16px" Width="150px"></asp:TextBox>
                        备注<asp:TextBox ID="bz" runat="server" Height="16px" Width="150px"></asp:TextBox>

                    </p>
                </div>
                <p>
                    <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" EmptyDataText="无记录" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField HeaderText="序号" Visible="false" DataField="bh" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                                <HeaderTemplate>
                                    序号
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="物料名称" DataField="wlmc" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="加工费(元/吨)" DataField="jgf" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="出煤指标" DataField="cmzb" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="30%" />
                                <ItemStyle HorizontalAlign="Left" Width="30%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="备注" DataField="bz" HeaderStyle-Width="20%">
                                <HeaderStyle HorizontalAlign="Left" Width="40%" />
                                <ItemStyle HorizontalAlign="Left" Width="40%" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderStyle-Width="10%" HeaderText="操作">
                                <ItemTemplate>
                                    <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("bh") %>' CssClass="buttonCancle" OnClick="DelJgxx" OnClientClick="return confirm('是否删除？')" Text="删除" />
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
                </p>
            </div>

            <p class="auto-style5">
                <asp:Button ID="add" Text="保存" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp
                <asp:Button ID="update" Text="修改" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="update_Click"></asp:Button>&nbsp
                <asp:Button ID="refresh" Text="审核" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="btnShengHe_Click"></asp:Button>&nbsp
                 <asp:Button ID="done" Text="执行" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="btnZhiXing_Click"></asp:Button>&nbsp
                <asp:Button ID="close" Text="关闭" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="close_Click"></asp:Button>
            </p>
        </div>
    </form>
</body>
</html>
