<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormExport.aspx.cs" Inherits="XSSystem.Page.P_CWGL.FormExport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
    <script  src="../../My97DatePicker/WdatePicker.js" type="text/javascript" ></script>
    <script src="../../My97DatePicker/calendar.js" type="text/javascript"></script>
    <script src="../../My97DatePicker/config.js" type="text/javascript"></script>
    <script src="../../js/FormStyle.js"></script>
    <link href="../../style/sysCss.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style3 {
            height: auto;
            width:400px;
            text-align:right;
            }
        .Wdate {}
        .auto-style4 {
            height:20px;
            width:1200px;
            text-align:left;
        }
        .auto-style5 {
            height:auto;
            width:auto;
            text-align:center;
        }
        </style>
    <link href="../../My97DatePicker/skin/WdatePicker.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>导出时间
                <asp:TextBox ID="cxsjQ" runat="server"  Text="" valued="must" name="起始日期" onClick="WdatePicker()" Width="204px"/>-
                <asp:TextBox ID="cxsjZ" runat="server"  Text="" valued="must" name="终止日期" onClick="WdatePicker()" Width="204px"/></p>
            <p>
                客户<asp:TextBox id="tbzt" runat="server" Width="140px"></asp:TextBox>
                <asp:Button Text="生成表格" OnClick="Unnamed_Click" runat="server" ID="Button1" />
                <asp:Button Text="导出表格" OnClick="Unnamed_Click" runat="server" ID="btn1" />
            </p>
            <p>
                 <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" EmptyDataText="无记录" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="客户" DataField="kh" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发货单位" DataField="fhdw" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="应收款结余" DataField="yskjy" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                         <asp:BoundField HeaderText="累计欠票" DataField="ljqp" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="当日收款" DataField="drsk" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="当日开票" DataField="drkp" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发货吨位" DataField="fhdw2" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发货单价" DataField="fhdj" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="金额" DataField="je" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
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
            </p>
        </div>
    </form>

</body>
</html>
