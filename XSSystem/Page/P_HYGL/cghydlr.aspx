<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cghydlr.aspx.cs" Inherits="XSSystem.Page.P_Order.cghydlr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>采购化验单录入</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <style type="text/css">
        .auto-style1 {
    text-align: center;
    border-style: none;
    width: 1600px; font-family: 宋体, Arial, Helvetica, sans-serif; line-height: normal; background-color: #33CCFF;
        }
        .auto-style3 {
            height: 20px;
            width:600px;
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
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div> <p class="auto-style5">采购化验单录入</p>
        <div>
            <p>基本信息</p>
            <table border="0" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*化验单编号<asp:TextBox ID="hydbh" runat="server" Height="16px" Width="500px"></asp:TextBox></td>
                    <td class="auto-style3">*化验日期<asp:TextBox ID="hyrq" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox></td>                                    
                </tr>
                <tr>
                    <td class="auto-style3">供应商<asp:TextBox id="gys" runat="server" Height="16px" Width ="500px"></asp:TextBox> </td>
                    <td class="auto-style3">煤场名称<asp:TextBox id="mcmc" runat="server" Height="16px" Width ="500px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">物料名称<asp:TextBox id="wlmc" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">采样人<asp:TextBox id="cyr" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">化验人<asp:TextBox id="hyr" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3"></td>
                    
                </tr>
             
            </table>     
        </div>

        <div>
            <p> 详细指标</p>
            <p>选择磅单：<asp:Button ID="Button2" runat="server" Text="选择汽运信息" /></p>
            <p>查看磅单：<asp:Button ID="Button3" runat="server" Text="已选汽运信息" /></p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="新增记录" />
                <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="序号" DataField="xh" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="煤种" DataField="mz" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="水分" DataField="sf" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="灰分" DataField="hf" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="挥发分" DataField="hff" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="固定碳" DataField="gdt" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="粘结指数" DataField="njzs" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="粒度" DataField="ld" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="硫" DataField="liu" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="铁" DataField="tie" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="铝" DataField="lv" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="钙" DataField="gai" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="磷" DataField="lin" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="钛" DataField="tai" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="低位发热量" DataField="dwfrl" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="高位发热量" DataField="gwfrl" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="焦渣特征" DataField="jztz" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="备注" DataField="bz" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="操作" DataField="cz" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
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
        


        <p class="auto-style5">
                <asp:Button ID="submit" text="保存" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp
                <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="close_Click"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>
