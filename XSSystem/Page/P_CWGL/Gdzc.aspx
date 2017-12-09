<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gdzc.aspx.cs" Inherits="XSSystem.Page.P_Order.Gdzc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>固定资产</title>
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
    <div> <p class="auto-style5">固定资产</p>
        <div>
            <p>固定资产购置</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*编号<asp:TextBox ID="zjzj_bh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>  <%--FY+日期+序号--%>
                    <td class="auto-style3">日期<asp:TextBox ID="zjzj_rq" runat="server" Height="25px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">公司名称<asp:TextBox id="zjzj_gsmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">供货商<asp:TextBox id="zjzj_srmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">付款账户<asp:TextBox id="zjzj_je" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3">实付金额<asp:TextBox id="zjzj_zh" runat="server" Height="16px" Width ="284px"></asp:TextBox></td> 
                </tr>    
                <tr>
                    <td class="auto-style3">开票类型<asp:DropDownList ID="kplx" runat="server" Height="16px" Width="284px">
                        <asp:ListItem>无票</asp:ListItem>
                        <asp:ListItem>一票</asp:ListItem>
                        <asp:ListItem>两票</asp:ListItem>
                        <asp:ListItem>原票原转</asp:ListItem>
                                                </asp:DropDownList></td>
                    <td></td>
                    <td></td>
                </tr>             
            </table> 
            
            <div>
            <p>
                <asp:Button ID="Button6" runat="server" Text="添加明细" />
                <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true">
                    <Columns>
                        <asp:BoundField HeaderText="序号" DataField="xh" HeaderStyle-Width="10%" />
                        <asp:BoundField HeaderText="固定资产名称" DataField="mkmc" HeaderStyle-Width="10%" />
                        <asp:BoundField HeaderText="金额" DataField="mzmc" HeaderStyle-Width="10%" />
                        <asp:BoundField HeaderText="备注" DataField="frl" HeaderStyle-Width="10%" />
                    </Columns>
                </asp:GridView>
            </p>
                 
        </div>           
            <p class="auto-style5">
                <asp:Button ID="submit" text="提交" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p>        
        </div>

        <div>
            <p>固定资产变卖</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*编号<asp:TextBox ID="zjjs_bh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>  <%--FY+日期+序号--%>
                    <td class="auto-style3">日期<asp:TextBox ID="zjjs_rq" runat="server" Height="25px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">公司名称<asp:TextBox id="zjjs_gsmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">收款单位<asp:TextBox id="zjjs_fymc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">收购账户<asp:TextBox id="zjjs_je" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3">实收金额<asp:TextBox id="zjjs_zh" runat="server" Height="16px" Width ="284px"></asp:TextBox></td> 
                </tr>
            </table>     

            <div>
            <p>
                <asp:Button ID="Button7" runat="server" Text="添加明细" />
                <asp:GridView ID="GridView2" runat="server" CssClass="xs_table" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true">
                    <Columns>
                        <asp:BoundField HeaderText="序号" DataField="xh" HeaderStyle-Width="10%" />
                        <asp:BoundField HeaderText="固定资产名称" DataField="mkmc" HeaderStyle-Width="10%" />
                        <asp:BoundField HeaderText="金额" DataField="mzmc" HeaderStyle-Width="10%" />
                        <asp:BoundField HeaderText="备注" DataField="frl" HeaderStyle-Width="10%" />
                    </Columns>
                </asp:GridView>
            </p>
                 
        </div>   
            <p class="auto-style5">
                <asp:Button ID="Button1" text="提交" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p>        
        </div>

        <div>
            <p>固定资产折旧</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*编号<asp:TextBox ID="yskzj_bh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>  <%--FY+日期+序号--%>
                    <td class="auto-style3">日期<asp:TextBox ID="yskzj_rq" runat="server" Height="25px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">公司名称<asp:TextBox id="yskzj_gsmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                </tr>
            </table>     
            <div>
            <p>
                <asp:Button ID="Button8" runat="server" Text="添加明细" />
                <asp:GridView ID="GridView3" runat="server" CssClass="xs_table" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true">
                    <Columns>
                        <asp:BoundField HeaderText="序号" DataField="xh" HeaderStyle-Width="10%" />
                        <asp:BoundField HeaderText="固定资产名称" DataField="mkmc" HeaderStyle-Width="10%" />
                        <asp:BoundField HeaderText="折旧金额" DataField="mzmc" HeaderStyle-Width="10%" />
                        <asp:BoundField HeaderText="备注" DataField="frl" HeaderStyle-Width="10%" />
                    </Columns>
                </asp:GridView>
            </p>


            <p class="auto-style5">
                <asp:Button ID="Button2" text="提交" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p>        
        </div>          
        </div>
    </div>
    </form>
</body>
</html>
