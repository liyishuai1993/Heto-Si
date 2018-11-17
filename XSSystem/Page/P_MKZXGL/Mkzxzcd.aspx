﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mkzxzcd.aspx.cs" Inherits="XSSystem.Page.P_Order.Mkzxzcd" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>煤矿直销装车单</title>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
    <script src="../../js/FormStyle.js"></script>
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
        .Wdate {}
        .auto-style4 {
            height:20px;
            width:1200px;
            text-align:left;
        }
        .auto-style5 {
            height:auto;
            width:auto;
            text-align:left;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div> <p class="auto-style5">煤矿直销装车单</p>
        <div>
            <p>基本信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*单据编号<asp:TextBox ID="djbh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">*装车时间
                        <asp:TextBox ID="zcsj" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">采购合同号<asp:TextBox id="cghth" runat="server" Height="16px" Width ="269px"></asp:TextBox> </td>
                    

                </tr>
                <tr>
                    <td class="auto-style3">*供货方<asp:TextBox id="ghf" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">*收货方<asp:TextBox id="shf" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">煤矿名称<asp:TextBox id="mkmc" runat="server" Height="16px" Width ="269px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">*物料名称<asp:TextBox id="wlmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">承运单位<asp:TextBox id="cydw" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3">运价<asp:TextBox id="yj" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">*采购煤价<asp:TextBox id="cgmj" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox> </td>
                    <td class="auto-style3">销售煤价<asp:TextBox id="xsmj" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox> </td>
                    <td></td>
                </tr>
            </table>            
        </div>

        <div>
            <div class="divcss5">
            <p>车辆信息<asp:Button ID="Button1" runat="server" Text="新增记录" OnClick="AddClxx" /></p>
            <p class="auto-style5">
                
                磅单号<asp:TextBox id="bdh"  runat="server" Height="16px" Width ="150px" ToolTip="磅单号"></asp:TextBox>
                提货单号<asp:TextBox id="thdh" runat="server" Height="16px" Width ="150px"></asp:TextBox>
                车号<asp:TextBox id="ch"  runat="server" Height="16px" Width ="150px"></asp:TextBox>
                装车毛重<asp:TextBox id="zcmz"  runat="server" Height="16px" Width ="150px" OnKeyPress="isnum()"></asp:TextBox>
                </p>
            <p class="auto-style5">
                
                装车皮重<asp:TextBox id="zcpz" runat="server" Height="16px" Width ="150px" OnKeyPress="isnum()"></asp:TextBox>
                装车净重<asp:TextBox id="zcjz" runat="server" Height="16px" Width ="150px" OnKeyPress="isnum()"></asp:TextBox>
                应付运费<asp:TextBox id="yfyf"  runat="server" Height="16px" Width ="150px" OnKeyPress="isnum()"></asp:TextBox>
                采购结算金额<asp:TextBox id="cgjsje" runat="server" Height="16px" Width ="150px" OnKeyPress="isnum()"></asp:TextBox>   
                </p>
            <p class="auto-style5">
                销售结算金额<asp:TextBox id="xsjsje" runat="server" Height="16px" Width ="150px" OnKeyPress="isnum()"></asp:TextBox>
                备注<asp:TextBox id="bz" runat="server" Height="16px" Width ="150px"></asp:TextBox>
                状态<asp:TextBox id="zt" runat="server" Height="16px" Width ="150px"></asp:TextBox>
                
            </p>
                </div>
            <p>
                
                <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="*磅单号" DataField="bdh" HeaderStyle-Width="10%" >
                        <HeaderStyle HorizontalAlign="Left" Width="10%" />
                        <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="提货单号" DataField="thdh" HeaderStyle-Width="10%" >
                        <HeaderStyle HorizontalAlign="Left" Width="10%" />
                        <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="*车号" DataField="ch" HeaderStyle-Width="10%" >
                        <HeaderStyle HorizontalAlign="Left" Width="10%" />
                        <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="装车毛重" DataField="zcmz" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="装车皮重" DataField="zcpz" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="*装车净重" DataField="zcjz" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="应付运费" DataField="yfyf" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="采购结算金额" DataField="cgjsje" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="销售结算金额" DataField="xsjsje" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="备注" DataField="bz" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="状态" DataField="zt" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
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
            </p>                
        </div>

        <p class="auto-style5">
                <asp:Button ID="submit" text="保存" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp
                <asp:Button ID="refresh" text="重填" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp
                </p> 
        </div>
    </form>
</body>
</html>
