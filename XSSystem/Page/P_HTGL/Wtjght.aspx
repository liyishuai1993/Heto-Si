<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wtjght.aspx.cs" Inherits="XSSystem.Page.P_Order.Wtjght" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>委托加工合同</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
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
</head>
<body>
    <form id="form1" runat="server">
    <div> <p class="auto-style5">委托加工合同</p>
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
                    <td class="auto-style3">*委托方<asp:TextBox id="wtf" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">
                        *受托方<asp:TextBox id="stf" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                    <td class="auto-style3">
                    </td>
                </tr>

                <tr>
                    <td class="auto-style3">开票类型<asp:DropDownList id="kpxx" runat="server" Height="25px" Width ="284px">
                        <asp:ListItem>无票</asp:ListItem>
                        <asp:ListItem>一票</asp:ListItem>
                        <asp:ListItem>两票</asp:ListItem>
                        <asp:ListItem>原票原转</asp:ListItem>
                        </asp:DropDownList> </td>
                    <td class="auto-style3">执行期限<asp:TextBox ID="zxqxQ" runat="server" Text="" onClick="WdatePicker()" Width="140px"></asp:TextBox>-<asp:TextBox ID="zxqxZ" runat="server" Text="" onClick="WdatePicker()" Width="140px"></asp:TextBox> </td>
                    <td class="auto-style3"> </td> 
                </tr>
       
            </table>            
        </div>

        <div>
            <p>价格信息</p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="新增记录" />
                <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" EmptyDataText="无记录" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="序号" DataField="xh" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="物料名称" DataField="wlmc" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="加工费(元/吨)" DataField="jgf" HeaderStyle-Width="10%" >
<HeaderStyle Width="10%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="出煤指标" DataField="cmzb" HeaderStyle-Width="10%" >
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
