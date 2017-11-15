<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fyd.aspx.cs" Inherits="XSSystem.Page.P_Order.Fyd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>费用单</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
    text-align: center;
    border-style: none;
        }
        .auto-style3 {
            height: 20px;
            width:400px;
            text-align:right;
            }
        .auto-style6 {
            height: 20px;
            width:800px;
            text-align:right;
            }
        .Wdate {}
        .auto-style4 {
            text-align:left;
        }
        .auto-style5 {
            height:auto;
            width:auto;
            text-align:center;
        }
        .auto-style7 {
            height:auto;
            width:1200px;
            text-align:right;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div> <p class="auto-style5">费用单</p>
        <p class="auto-style4">录单日期<asp:TextBox id="ldrq" runat="server" Height="16px" Width ="284px" Text="" onClick="WdatePicker()"></asp:TextBox>
            编号<asp:TextBox ID="bh" runat="server" Height="16px" Width="284px"></asp:TextBox></p>
        <div>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">收费单位<asp:TextBox ID="sfdw" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">经手人<asp:TextBox id="jsr" runat="server" Height="16px" Width ="284px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">部门<asp:TextBox id="bm" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="2">摘要<asp:TextBox id="zy" runat="server" Height="16px" Width ="682px"></asp:TextBox> </td>
                    <td class="auto-style3">附加说明<asp:TextBox id="fjsm" runat="server" Height="16px" Width ="284px" Text="" onClick="WdatePicker()"></asp:TextBox> </td>
                </tr>
            </table>            
        </div>

        <div>
                <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" EmptyDataText="无记录" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="序号" DataField="xh" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="费用项目编号" DataField="fyxmbh" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="费用项目名称" DataField="fyxmmc" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="金额" DataField="je" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="备注" DataField="bz" HeaderStyle-Width="20%" >
<HeaderStyle Width="20%"></HeaderStyle>
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
        </div>

        <p class="auto-style7">
            合计金额<asp:TextBox id="hjje" runat="server" Height="16px" Width ="80px"></asp:TextBox>
            付款账户<asp:TextBox id="fkzh" runat="server" Height="16px" Width ="80px"></asp:TextBox>
            实付金额<asp:TextBox id="sfje" runat="server" Height="16px" Width ="80px"></asp:TextBox>

        </p>


        <p class="auto-style7">
                <asp:Button ID="submit" text="配置" runat ="server" width="90px"   BackColor="#cccccc"></asp:Button>&nbsp
                <asp:Button ID="Button1" text="打印" runat ="server" width="90px"   BackColor="#cccccc"></asp:Button>&nbsp
                <asp:Button ID="refresh" text="保存|退出" runat ="server" width="90px"   BackColor="#cccccc"></asp:Button>&nbsp
                </p> 
        </div>
    </form>
</body>
</html>