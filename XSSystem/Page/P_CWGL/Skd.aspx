<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Skd.aspx.cs" Inherits="XSSystem.Page.P_Order.Skd" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>收款单</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
        <script src="../../js/FormStyle.js"></script>
    <style type="text/css">
        .auto-style1 {
    text-align: center;
    border-style: none;
    width: 1600px; font-family: 宋体, Arial, Helvetica, sans-serif; line-height: normal; background-color: #33CCFF;
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
            width:auto;
            text-align:right;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div> <p class="auto-style5">收款单</p>
                <telerik:RadScriptManager runat="server" ID="RadScriptManager1"></telerik:RadScriptManager>
        <p class="auto-style4">录单日期<asp:TextBox id="ldrq" runat="server" Height="16px" Width ="284px" Text="" onClick="WdatePicker()"></asp:TextBox>
            编号<asp:TextBox ID="bh" runat="server" Height="16px" Width="284px" Enabled="false"></asp:TextBox></p>
        <div>
            <table border="0" aria-haspopup="False" class="auto-style1" style="width:1200px" >
                <tr>
                    <td class="auto-style3">付款单位<telerik:RadComboBox RenderMode="Lightweight" ID="tk_fkdw" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入付款单位"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="付款单位" valued="must1" 
   HighlightTemplatedItems="true"/></td>
                    <td class="auto-style3">经手人<telerik:RadComboBox RenderMode="Lightweight" ID="tk_jsr" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入经手人"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="经手人" valued="must1" 
   HighlightTemplatedItems="true"/>
                    </td>
                    <td class="auto-style3"><span>部门</span><asp:TextBox id="bm" runat="server" Height="16px" Width ="284px" name="部门" valued="must1" ></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">合同编号<telerik:RadComboBox RenderMode="Lightweight" ID="tk_htbh" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请选择合同编号"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="合同编号" valued="must1" 
   HighlightTemplatedItems="true"/></td>
                    <td class="auto-style3">摘要<asp:DropDownList id="dp_zy" runat="server" Height="24px" Width ="284px">
                        <asp:ListItem>借款</asp:ListItem>
                        <asp:ListItem>货款收入</asp:ListItem>
                        <asp:ListItem>往来</asp:ListItem>
                                              </asp:DropDownList> </td>
                    <td class="auto-style3">附加说明<asp:TextBox id="fjsm" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                </tr>
                <tr>
                     <td class="auto-style3">结算方式<asp:DropDownList id="jsfs" runat="server" Height="25px" Width ="284px">
                        <asp:ListItem>现金</asp:ListItem>
                        <asp:ListItem>电汇</asp:ListItem>
                        <asp:ListItem>承兑汇票</asp:ListItem>
                        <asp:ListItem>电汇或承兑</asp:ListItem>
                        <asp:ListItem>电汇加承兑</asp:ListItem>
                        </asp:DropDownList> </td> 
                </tr>
            </table>            
        </div>

        <div>
            <p><asp:Button  runat="server" Text="新增" ID="InsertBtn" OnClick="InsertBtn_Click"/>
                收款账户<telerik:RadComboBox RenderMode="Lightweight" ID="tk_skzhbh" AutoPostBack="True" runat="server"  Height="200px"
  EmptyMessage="请输入收款账户"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="收款账户" valued="must2" 
   HighlightTemplatedItems="true"  OnSelectedIndexChanged="tk_skzhbh_SelectedIndexChanged"/>
                收款账户名称<asp:TextBox runat="server" id="zhm" valued="must2" name="收款账户名称"/>
                开户行<asp:TextBox runat="server" id="khh" valued="must2" name="开户行"/>
                金额<asp:TextBox runat="server" ID="je" valued="must2" name="金额" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"/>
                备注<asp:TextBox runat="server" ID="bz"/>
            </p>
                <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" EmptyDataText="无记录" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="序号" DataField="xh" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="收款账户编号" DataField="skzhbh" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="收款账户名称" DataField="skzhmc" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="金额" DataField="je" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="备注" DataField="bz" HeaderStyle-Width="20%" >
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
        </div>

        <p class="auto-style7">
            优惠金额<asp:TextBox id="yhje" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
            合计金额<asp:TextBox id="hjje" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></p>


        <p class="auto-style7">
                <asp:Button ID="print" text="打印" runat ="server" width="90px"   BackColor="#cccccc"></asp:Button>&nbsp
                <asp:Button ID="save" text="保存" runat ="server" width="90px"   BackColor="#cccccc" OnClick="save_Click"></asp:Button>&nbsp
            <asp:Button ID="close" text="关闭" runat ="server" width="90px"   BackColor="#cccccc"  OnClick="close_Click"></asp:Button>&nbsp

                </p> 
        </div>
    </form>
</body>
</html>
