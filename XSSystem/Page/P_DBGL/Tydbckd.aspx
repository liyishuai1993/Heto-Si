<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tydbckd.aspx.cs" Inherits="XSSystem.Page.P_Order.Tydbckd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>铁运调拨出库单</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
    text-align: center;
    border-style: none;
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
    <div> <p class="auto-style5">铁运调拨出库单</p>
        
        <div>
            <p>基本信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*编号<asp:TextBox ID="bh" runat="server" Height="16px" Width="500px"></asp:TextBox></td>
                    <td class="auto-style3">合同编号<asp:TextBox id="htbh" runat="server" Height="16px" Width ="500px"></asp:TextBox> </td>                                    
                </tr>
                <tr>
                    <td class="auto-style3">公司名称<asp:TextBox id="gsmc" runat="server" Height="16px" Width ="500px"></asp:TextBox> </td>
                    <td class="auto-style3">*发煤煤场<asp:TextBox id="fmmc" runat="server" Height="16px" Width ="500px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">*物料名称<asp:TextBox id="wlmc" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">装车站<asp:TextBox id="zcz" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">终到站<asp:TextBox id="zdz" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">箱类型<asp:TextBox id="xlx" runat="server" Height="16px" Width ="500px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">卸货吨位<asp:TextBox id="xhdw" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">
                    </td>
                </tr>
                
            </table>     
        </div>


        <div>
            <p>集装箱信息</p>
            <p>
                <asp:Button ID="Button2" runat="server" Text="新增记录" OnClick="AddJgxx" />
                箱号<asp:TextBox id="xh" runat="server" Height="16px" Width ="150px"></asp:TextBox>
                上箱吨数<asp:TextBox id="sxds" runat="server" Height="16px" Width ="150px"></asp:TextBox>
                装箱日期<asp:TextBox id="zxrq" Text="" onClick="WdatePicker()" runat="server" Height="16px" Width ="150px"></asp:TextBox>
                发车日期<asp:TextBox id="fcrq" Text="" onClick="WdatePicker()" runat="server" Height="16px" Width ="150px"></asp:TextBox>
                调出煤价<asp:TextBox id="dcmj" runat="server" Height="16px" Width ="150px"></asp:TextBox>
                卸货吨数<asp:TextBox id="xhds" runat="server" Height="16px" Width ="150px"></asp:TextBox>
                到站日期<asp:TextBox id="dzrq" Text="" onClick="WdatePicker()" runat="server" Height="16px" Width ="150px"></asp:TextBox>
                卸货仓库<asp:TextBox id="xhck" runat="server" Height="16px" Width ="150px"></asp:TextBox>     
                自备箱使费(元/组)<asp:TextBox id="zbxsf" runat="server" Height="16px" Width ="150px"></asp:TextBox>
                发站代理费(元/组)<asp:TextBox id="fzdlf" runat="server" Height="16px" Width ="150px"></asp:TextBox>
                发站装箱费(元/吨)<asp:TextBox id="fzzxf" runat="server" Height="16px" Width ="150px"></asp:TextBox>
                发站倒短(元/吨)<asp:TextBox id="fzddf" runat="server" Height="16px" Width ="150px"></asp:TextBox> 
                铁路运费(元/组)<asp:TextBox id="tlyf" runat="server" Height="16px" Width ="150px"></asp:TextBox> 
                到站装卸费(元/组)<asp:TextBox id="dzzxf" runat="server" Height="16px" Width ="150px"></asp:TextBox> 
                到站-煤场倒短费(元/组)<asp:TextBox id="dzmcddf" runat="server" Height="16px" Width ="150px"></asp:TextBox> 
                到站代理费(元/吨)<asp:TextBox id="dzdlf" runat="server" Height="16px" Width ="150px"></asp:TextBox> 
                调入煤价<asp:TextBox id="drmj" runat="server" Height="16px" Width ="150px"></asp:TextBox> 
            
        </p>
            <p>
                
                <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="箱号" DataField="xh" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="上箱吨数" DataField="sxds" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="装箱日期" DataField="zxrq" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发车日期" DataField="fcrq" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="调出煤价" DataField="dcmj" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="卸货吨数" DataField="xhds" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="到站日期" DataField="dzrq" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="卸货仓库" DataField="xhck" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="自备箱使费(元/组)" DataField="zbxsf" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发站代理费(元/组)" DataField="fzdlf" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发站装箱费(元/吨)" DataField="fzzxf" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发站倒短(元/吨)" DataField="fzddf" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="铁路运费(元/组)" DataField="tlyf" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="到站装卸费(元/组)" DataField="dzzxf" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="到站-煤场倒短费(元/组)" DataField="dzmcddf" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle></asp:BoundField>
                        <asp:BoundField HeaderText="到站代理费(元/组)" DataField="dzdlf" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle></asp:BoundField>
                        <asp:BoundField HeaderText="调入煤价" DataField="drmj" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle></asp:BoundField>
                        
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
               <%-- <asp:Button ID="refresh" text="保存并关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp--%>
            <asp:Button ID="Button1" text="重填" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp
                <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>
