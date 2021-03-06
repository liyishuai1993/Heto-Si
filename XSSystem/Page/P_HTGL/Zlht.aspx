﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Zlht.aspx.cs" Inherits="XSSystem.Page.P_Order.Zlht" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>租赁合同</title>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <script src="../../js/FormStyle.js"></script>
    <link href="../../style/sysCss.css" rel="stylesheet" />
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
            <p class="auto-style5">租赁合同</p>
            <div>
                <p>基本信息</p>
                <table border="0" aria-haspopup="False" class="auto-style1" style="width: 1200px; font-family: 宋体, Arial, Helvetica, sans-serif; line-height: normal; background-color: #33CCFF;">
                    <%-- <table border="1" aria-haspopup="False" class="xs_table" style="width: 1200px"  >--%>
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
                        <td class="auto-style3"><span>出租方</span><asp:DropDownList ID="czf" valued="must1" runat="server" Height="25px" Width="284px"></asp:DropDownList>
                        </td>
                        <td class="auto-style3">
                            <span>承租方</span><asp:DropDownList ID="czf2" runat="server" valued="must1" Height="25px" Width="284px"></asp:DropDownList>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>

                    <tr>
                        <td class="auto-style3"><span>出租地段</span><asp:DropDownList ID="czdd" name="出租地段" valued="must1" runat="server" Height="25px" Width="284px"></asp:DropDownList>
                        </td>
                        <td class="auto-style3"><span>租赁期限</span>
                            <asp:TextBox ID="zlqxQ" runat="server" Text="" name="租赁期限" valued="must1" onClick="WdatePicker()" Width="141px"></asp:TextBox>-
                        <asp:TextBox ID="zlqxZ" runat="server" Text="" name="租赁期限" valued="must1" onClick="WdatePicker()" Width="141px"></asp:TextBox>
                        </td>
                        <td class="auto-style3"><span>押金</span><asp:TextBox ID="yj" name="押金" valued="must1" runat="server" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td>
                    </tr>

                </table>
            </div>

            <div style="margin-top: 15px">
                <div class="divcss5">
                    <p>租金信息<asp:Button ID="Button1" runat="server" Text="新增记录" OnClick="AddZjxx" /></p>
                    <p>
                        起始日期<asp:TextBox ID="qsrq" valued="must2" name="起始日期" runat="server" Height="16px" Text="" onClick="WdatePicker()" Width="150px"></asp:TextBox>
                        终止日期<asp:TextBox ID="zzrq" valued="must2" name="终止日期" runat="server" Height="16px" Width="150px" Text="" onClick="WdatePicker()"></asp:TextBox>
                        租金<asp:TextBox ID="zj" runat="server" valued="must2" name="租金" Height="16px" Width="150px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                    </p>
                    <p>
                        付款条款<asp:TextBox ID="fktk" runat="server" valued="must2" name="付款条款" Height="16px" Width="150px"></asp:TextBox>
                        执行状态<asp:TextBox ID="zxzt" runat="server" valued="must2" name="执行状态" Height="16px" Width="150px"></asp:TextBox>
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
                            <asp:BoundField HeaderText="起始日期" DataField="qsrq" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="终止日期" DataField="zzrq" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="租金" DataField="zj" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="付款条款" DataField="fktk" HeaderStyle-Width="20%">
                                <HeaderStyle HorizontalAlign="Left" Width="30%" />
                                <ItemStyle HorizontalAlign="Left" Width="30%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="执行状态" DataField="zxzt" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="备注" DataField="bz" HeaderStyle-Width="10%">
                                <HeaderStyle HorizontalAlign="Left" Width="20%" />
                                <ItemStyle HorizontalAlign="Left" Width="20%" />
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
