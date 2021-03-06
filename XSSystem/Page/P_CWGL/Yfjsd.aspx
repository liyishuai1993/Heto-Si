﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Yfjsd.aspx.cs" Inherits="XSSystem.Page.P_CWGL.Yfjsd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>运费结算单</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
    text-align: center;
    border-style: none;
        }
        .auto-style3 {
            height: 20px;
            text-align:center;
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
        .auto-style6 {
            height: 20px;
            text-align: center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div> <p class="auto-style5">运费结算单</p>
        <div>
            <p>新增单据</p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="新增记录" />
                <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" EmptyDataText="无记录" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="结算单类型" DataField="jsdlx" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="磅单号" DataField="bdh" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="装车日期" DataField="zcrq" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                         <asp:BoundField HeaderText="入库日期" DataField="rkrq" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="车号" DataField="ch" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="装车地" DataField="zcd" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="收货地" DataField="shd" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="物料名称" DataField="wlmc" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="装车净重" DataField="zcjz" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="入库净重" DataField="rkjz" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="运费单价" DataField="yfdj" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="应付运费" DataField="yfyf" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="已付油卡" DataField="yfyk" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="扣减款项" DataField="kjkx" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="实付运费" DataField="sfyf" HeaderStyle-Width="10%" >
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





        <div>
            <p>结算日期<asp:TextBox ID="jsrq" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                单号：<asp:TextBox ID="dh" runat="server" Height="16px" Width="284px"></asp:TextBox></p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="border-style: solid; width: 1200px" >
                <tr>
                    <td class="auto-style4" colspan="16">承运单位：<asp:TextBox id="gys0" runat="server" Height="16px" Width ="500px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3" rowspan="2">序号</td>
                    <td class="auto-style6" rowspan="2" colspan="2">磅单号</td>
                    <td class="auto-style3" rowspan="2">装车日期</td>
                    <td class="auto-style3" rowspan="2">入库日期</td>
                    <td class="auto-style3" rowspan="2">车号</td>
                    <td class="auto-style3" rowspan="2">装车地</td>
                    <td class="auto-style3" rowspan="2">收货地</td>
                    <td class="auto-style3" rowspan="2">货物名称</td>
                    <td class="auto-style3" rowspan="2">装车净重</td>
                    <td class="auto-style3" rowspan="2">入库净重</td>
                    <td class="auto-style3">运费单价</td>
                    <td class="auto-style3" rowspan="2">应付运费</td>
                    <td class="auto-style3" rowspan="2">已付油卡</td>
                    <td class="auto-style3">扣减款项</td>
                    <td class="auto-style3" rowspan="2">实付运费</td>
                </tr>
                <tr>
                    <td class="auto-style3">(元/吨)</td>
                    <td class="auto-style3">超标扣款</td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="3">合计：</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3" colspan="3">&nbsp;</td>
                    <td class="auto-style3" colspan="3">付款方式</td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                    <td class="auto-style3">付款账户编号：</td>
                    <td class="auto-style3" colspan="3">&nbsp;</td>
                    <td class="auto-style3">付款账户名称：</td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                    <td class="auto-style3" colspan="3">附件张数：</td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">备注：</td>
                    <td class="auto-style3" colspan="14">&nbsp;</td>
                </tr>
                             
            </table>     
            <p class="auto-style4">审批：<asp:TextBox ID="sp" runat="server" Height="16px" Width="150px"></asp:TextBox>
                复核：<asp:TextBox ID="fh" runat="server" Height="16px" Width="150px"></asp:TextBox>
                付款人：<asp:TextBox ID="skr" runat="server" Height="16px" Width="150px"></asp:TextBox>
                收款签名人<asp:TextBox ID="skqmr" runat="server" Height="16px" Width="150px"></asp:TextBox>

            </p>
        </div>
        


        <p class="auto-style5">
                <asp:Button ID="submit" text="保存" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp
                <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>

