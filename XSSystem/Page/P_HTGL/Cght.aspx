﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cght.aspx.cs" Inherits="XSSystem.Page.P_Order.Cght" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>采购合同</title>
    <script  src="../../My97DatePicker/WdatePicker.js" type="text/javascript" ></script>
    <script src="../../My97DatePicker/calendar.js" type="text/javascript"></script>
    <script src="../../My97DatePicker/config.js" type="text/javascript"></script>
    <link href="../../style/sysCss.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
    text-align: center;
    border-style: dotted;
    border-color:#00ffff;
        }
        .auto-style3 {
            height: 30px;
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
    <div> <p class="auto-style5">采购合同</p>
        <div>
            <p>基本信息</p>
            <table border="1" aria-haspopup="False" class="xs_table" style="width: 1200px"  >
                <tr>
                    <td class="auto-style3">*合同编号<asp:TextBox ID="htbh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">*合同类型<asp:DropDownList id="htlx" runat="server" height="25px" Width ="284px">
                        <asp:ListItem>预付款</asp:ListItem>
                        <asp:ListItem>直供赊销</asp:ListItem>
                        <asp:ListItem>超付</asp:ListItem>
                        </asp:DropDownList> </td>
                    <td class="auto-style3">*签订日期
                        <asp:TextBox ID="qdrq" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">对方合同号<asp:TextBox id="dfhth" runat="server" Height="16px" Width ="284px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">*供方名称<asp:TextBox id="gfmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">
                        *需方名称<asp:TextBox id="xfmc" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">货款结算依据<asp:DropDownList id="hkjsyj" runat="server" Height="25px" Width ="284px" CssClass="auto-style4">
                        <asp:ListItem>原发净重</asp:ListItem>
                        <asp:ListItem>收货净重</asp:ListItem>
                        <asp:ListItem>原发净重减扣吨</asp:ListItem>
                        <asp:ListItem>收货净重减扣吨</asp:ListItem>
                        </asp:DropDownList> </td>
                    <td class="auto-style3">货款路耗类型<asp:DropDownList id="hklhlx" runat="server" Height="25px" Width ="284px">
                        <asp:ListItem>不计路耗</asp:ListItem>
                        <asp:ListItem>百分之或千分比</asp:ListItem>
                        <asp:ListItem>吨数</asp:ListItem>
                        </asp:DropDownList> 
                    </td>
                    <td class="auto-style3">
                        货款路耗标准<asp:TextBox id="hklhbz" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">开票类型<asp:DropDownList id="kpxx" runat="server" Height="25px" Width ="284px">
                        <asp:ListItem>无票</asp:ListItem>
                        <asp:ListItem>一票</asp:ListItem>
                        <asp:ListItem>两票</asp:ListItem>
                        <asp:ListItem>原票原转</asp:ListItem>
                        </asp:DropDownList> </td>
                    <td class="auto-style3">交货时间<asp:TextBox ID="jhsjQ" runat="server" Text="" onClick="WdatePicker()" Width="142px"></asp:TextBox>-
                        <asp:TextBox ID="jhsjZ" runat="server" Text="" onClick="WdatePicker()" Width="142px"></asp:TextBox> </td>
                    <td class="auto-style3">货款结算方式<asp:DropDownList id="hkjsfs" runat="server" Height="25px" Width ="284px">
                        <asp:ListItem>现金</asp:ListItem>
                        <asp:ListItem>电汇</asp:ListItem>
                        <asp:ListItem>承兑汇票</asp:ListItem>
                        <asp:ListItem>电汇或承兑</asp:ListItem>
                        <asp:ListItem>电汇加承兑</asp:ListItem>
                        </asp:DropDownList> </td> 
                </tr>
                <tr>
                    <td class="auto-style3">交货地点<asp:TextBox id="jhdd" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">运费付款方式<asp:DropDownList ID="yffkfs" runat="server" height="25px"  Width="284px">
                        <asp:ListItem>我方付款</asp:ListItem>
                        <asp:ListItem>对方付款</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">煤矿名称<asp:TextBox id="mkmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="3">备注<asp:TextBox id="bz" runat="server" Height="16px" Width ="1148px"></asp:TextBox>
                    </td>
                </tr>
            </table>            
        </div>


        <div>
            <p>价格信息</p>
            <p>
                <asp:Button ID="Button2" runat="server" Text="新增记录" OnClick="Button2_Click" />
                <asp:GridView ID="GridView_JGXX" runat="server" CssClass="xs_table" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None"  >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="序号" DataField="xh" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="煤矿名称" DataField="mkmc" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="煤种名称" DataField="mzmc" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发热量" DataField="frl" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="硫份" DataField="lf" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="开票煤价" DataField="kpmj" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="合同煤价" DataField="htmj" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="扣损率" DataField="ksl" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="签订吨数" DataField="qdds" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="签订金额" DataField="qdje" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="状态" DataField="zt" HeaderStyle-Width="5%" >
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



        <div>
            <p>质量标准</p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="新增记录" />
                <asp:GridView ID="GridView_ZLBZ" runat="server" CssClass="xs_table" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="序号" DataField="xh" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="煤种" DataField="mz" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="粒度≥%" DataField="ld" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="灰分≤%" DataField="hf" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="挥发份%-%" DataField="hff" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="固定碳≥%" DataField="gdt" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="粘结指数≥%" DataField="njzs" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="水分≤%" DataField="sf" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="铁≤%" DataField="tie" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="铝≤%" DataField="lv" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="钙≤%" DataField="gai" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="磷≤%" DataField="lin" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="钛≤%" DataField="tai" HeaderStyle-Width="5%" >
<HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="硫≤%" DataField="liu" HeaderStyle-Width="5%" >
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
                <asp:Button ID="refresh" text="充填" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp
                <asp:Button ID="close" text="关闭" runat ="server" width="90px"   BorderStyle="Groove" BackColor="Aqua"></asp:Button>
            </p> 
        </div>
    </form>
</body>
</html>
