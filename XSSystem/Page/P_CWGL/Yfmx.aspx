<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Yfmx.aspx.cs" Inherits="XSSystem.Page.P_CWGL.Yfmx" %>
<%@ Register Assembly="xsFramework.UserControl" Namespace="xsFramework.UserControl.Pager"
    TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
    <script src="../../My97DatePicker/WdatePicker.js" type="text/javascript"></script>
    <script src="../../My97DatePicker/calendar.js" type="text/javascript"></script>
    <script src="../../My97DatePicker/config.js" type="text/javascript"></script>
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

        .auto-style4 {
            height: 20px;
            width: 1200px;
            text-align: left;
        }

        .auto-style5 {
            height: auto;
            width: auto;
            text-align: center;
        }
    </style>
    <link href="../../My97DatePicker/skin/WdatePicker.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="divcss5" style="margin-bottom: 15px; width: 1200px">
            <span>导出时间<asp:TextBox ID="cxsjQ" runat="server" Text="" valued="must" name="起始日期" onClick="WdatePicker()" Width="204px" />-
                <asp:TextBox ID="cxsjZ" runat="server" Text="" valued="must" name="终止日期" onClick="WdatePicker()" Width="204px" />
                客户<asp:TextBox ID="kh" runat="server" Width="140px"></asp:TextBox>
                <asp:Button Text="生成报表" name="queryBtn" OnClick="Button1_Click" CssClass="button" type="bu" runat="server" ID="Button1" />
                <asp:Button Text="导出报表" CommandName="exportBtn" OnClick="Unnamed_Click" CssClass="button" runat="server" ID="btn1" />
                <asp:Button Text="生成全部" name="allBtn" OnClick="Button2_Click" CssClass="button" type="bu" runat="server" ID="Button2" />
            </span>
        </div>
        <div>
            <asp:Panel ID="Panel1" runat="server" Height="900px" ScrollBars="Auto" Width="1200px">
                <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
                     EmptyDataText="无记录" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                        <asp:BoundField HeaderText="车号" DataField="ch">
                            <HeaderStyle Width="20%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="20%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="装车时间" DataField="zcsj"  DataFormatString="{0:yyyy-MM-dd}">
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发煤煤场" DataField="fmmc" >
                            <HeaderStyle Width="20%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="20%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="物料名称" DataField="wlmc" >
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="出库净重" DataField="ckjz2" >
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="入库时间" DataField="rksj" DataFormatString="{0:yyyy-MM-dd}">
                            <HeaderStyle Width="20%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="20%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="收货单位" DataField="xf" >
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>

                        <asp:BoundField HeaderText="入库净重" DataField="rkjz" >
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="运价" DataField="yj" >
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="运费结算吨位" DataField="yfjsdw" >
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="运费" DataField="yf" >
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="磅差" DataField="ksds" >
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="路损" DataField="yfhllh" >
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="运费扣款标准" DataField="yflhbz" >
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="运费扣款金额" DataField="yfkkje" >
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="已付油卡" DataField="yfyk" >
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="应付运费" DataField="yfyf" >
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="费用扣款" DataField="fykk" >
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="结算运费" DataField="jsyf" >
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="运费结算状态" DataField="yfjszt" >
                            <HeaderStyle Width="10%" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>

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

