<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rsclr.aspx.cs" Inherits="XSSystem.Page.P_Order.Rsclr" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>日生产录入</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <script src="../../js/FormStyle.js"></script>
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
    text-align: center;
    border-style: none;
        }
        .auto-style3 {
            height: 20px;
            width:640px;
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
<body style="height: auto; width: auto">
    <form id="form1" runat="server" defaultbutton="Button1" >
    <div>
        <telerik:RadScriptManager runat="server" ID="RadScriptManager1"></telerik:RadScriptManager>
        <p class="auto-style5">日生产录入</p>
        <div>
            <p>基本信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1271px" >
                <tr hidden="hidden">
                    <td><asp:TextBox ID="bh" runat="server" Visible="false"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">所属煤场<asp:TextBox ID="ssmc" valued="must1" name="所属煤场"  runat="server" Height="16px" Width="500px"></asp:TextBox></td>
                    <td class="auto-style3">日期<asp:TextBox ID="rq" runat="server" name="日期" valued="must" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox> </td>                                    
                </tr>
                <tr>
                    <td class="auto-style3">开机时间<asp:TextBox ID="kjsj" name="开机时间" runat="server" valued="must1" Text="" onClick="WdatePicker({dateFmt:'HH:mm:ss'})" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">关机时间<asp:TextBox ID="gjsj" name="关机时间" runat="server" valued="must1" Text="" onClick="WdatePicker({dateFmt:'HH:mm:ss'})" Width="284px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">班次<asp:DropDownList id="bc" runat="server" Height="20px" Width ="500px" CssClass="auto-style4">
                        <asp:ListItem>白班</asp:ListItem>
                        <asp:ListItem>中班</asp:ListItem>
                        <asp:ListItem>夜班</asp:ListItem>
                      </asp:DropDownList> </td>
                    <td class="auto-style3">用电总数(度)<asp:TextBox id="ydzs" name="用电总数"  runat="server" valued="must1" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">用电吨耗(吨/度)<asp:TextBox id="yddh" name="用电吨耗" runat="server" valued="must1" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">用煤总数(吨)<asp:TextBox id="ymzs" name="用煤总数" runat="server" valued="must1" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">公司名称 <telerik:RadComboBox RenderMode="Lightweight" ID="DropDownList_gsmc" AutoPostBack="True" runat="server" Width="500px" Height="400px"
  EmptyMessage="请输入公司名称"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="公司名称" valued="must1" 
   HighlightTemplatedItems="true">
    </telerik:RadComboBox> </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>            
                    <td class="auto-style3">
                        加工费金额 <asp:TextBox id="jgfje" name="加工费金额" runat="server" Height="16px" valued="must1" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td>
                    <td class="auto-style3">
                        每吨费用(元/吨)<asp:TextBox id="mdfy" name="每吨费用" runat="server" Height="16px" valued="must1" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>               
                    </td>
                </tr>      
                <tr>
                    <td class="auto-style3">
                       </td>
                </tr>
            </table>     
        </div>


        <div>
            <p class="auto-style5">生产信息</p>
            <p>
                <asp:Button ID="scxx_tjmz" runat="server" Text="添加煤种" OnClick="scxx_tjmz_Click" />&nbsp&nbsp
                <telerik:RadComboBox RenderMode="Lightweight" ID="DropDownListMZ" AutoPostBack="True" runat="server" Width="80px" Height="400px"
  EmptyMessage="选择"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="公司名称" valued="must2" 
   HighlightTemplatedItems="true">
    </telerik:RadComboBox>
                数量(t):<asp:TextBox id="scxx_sl" valued="must2" name="数量" runat="server" Height="16px" Width ="150px" CssClass="auto-style4" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>&nbsp
                金额<asp:TextBox id="scxx_je" runat="server" name="金额" valued="must2" Height="16px" Width ="200px" CssClass="auto-style4" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'.')"></asp:TextBox>
                 颗粒产率%<asp:TextBox id="klcl" runat="server" name="颗粒产率" valued="must2" Height="16px" Width ="50px" CssClass="auto-style4" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'.')"></asp:TextBox>
                混合煤产率%<asp:TextBox id="hhmcl" runat="server" name="混合煤产率" valued="must2" Height="16px" Width ="50px" CssClass="auto-style4" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'.')"></asp:TextBox>
                沫煤产率%<asp:TextBox id="mmcl" runat="server" name="沫煤产率" valued="must2" Height="16px" Width ="50px" CssClass="auto-style4" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'.')"></asp:TextBox>
                中煤产率%<asp:TextBox id="zmcl" runat="server" name="中煤产率" valued="must2" Height="16px" Width ="50px" CssClass="auto-style4" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'.')"></asp:TextBox>
                煤泥产率%<asp:TextBox id="nmcl" runat="server" name="煤泥产率" valued="must2" Height="16px" Width ="50px" CssClass="auto-style4" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'.')"></asp:TextBox>
                矸石产率%<asp:TextBox id="gscl" runat="server" name="矸石产率" valued="must2" Height="16px" Width ="50px" CssClass="auto-style4" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'.')"></asp:TextBox>
                损耗率%<asp:TextBox id="shl" runat="server" name="损耗率" valued="must2" Height="16px" Width ="50px" CssClass="auto-style4" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'.')"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="计算" OnClick="Button2_Click" />&nbsp&nbsp
            </p>            
            
            <asp:GridView ID="GridView_SCXX" runat="server" CssClass="xs_table" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None"  >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="煤种" DataField="mz"  >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="金额" DataField="je"  >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="数量" DataField="sl" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="颗粒产率%" DataField="klcl"  >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="混合煤产率%" DataField="hhmcl"  >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="沫煤产率%" DataField="mmcl"  >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="中煤产率%" DataField="zmcl" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="煤泥产率%" DataField="nmcl" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="矸石产率%" DataField="gscl"  >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="损耗率%" DataField="shl"  >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                       <%-- <asp:TemplateField  HeaderText="操作">
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("mz") %>' CssClass="buttonCancle"   OnClientClick="return confirm('是否删除？')" Text="删除" />
                        <%--<asp:Button ID="btnShenghe" runat="server" actionid="03" CommandArgument='<%#Eval("htbh") %>' CssClass="buttonCancle" OnClick="btnShengHe_Click" OnClientClick="return confirm('是否确定合同通过审核？')" Text="审核" />--%>
<%--                    </ItemTemplate>
                   <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:TemplateField>--%>
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

        <div>
            <p class="auto-style5">产出信息</p>
            <p>
                <asp:Button ID="ccxx_tjmz" runat="server" Text="添加煤种" OnClick="ccxx_tjmz_Click" />&nbsp&nbsp
                <telerik:RadComboBox RenderMode="Lightweight" ID="DropDownListMZ2" AutoPostBack="True" runat="server" Width="80px" Height="400px"
  EmptyMessage="选择"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="公司名称" valued="must" 
   HighlightTemplatedItems="true">
    </telerik:RadComboBox>
                数量(t):<asp:TextBox id="ccxx_sl" valued="must3" name="数量" runat="server" Height="16px" Width ="150px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>&nbsp
                金额<asp:TextBox id="ccxx_je" runat="server" valued="must3" name="金额"  Height="16px" Width ="200px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                 产率%<asp:TextBox id="ccxx_cl" runat="server" valued="must3" name="产率" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
            </p>     
            
            <asp:GridView ID="GridView_CCXX" runat="server" CssClass="xs_table" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None"  >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="煤种" DataField="mz"  >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="数量" DataField="sl" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                     <asp:BoundField HeaderText="产率" DataField="cl"  >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:TemplateField  HeaderText="操作">
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("mz") %>' CssClass="buttonCancle"   OnClientClick="return confirm('是否删除？')" Text="删除" />
                        <%--<asp:Button ID="btnShenghe" runat="server" actionid="03" CommandArgument='<%#Eval("htbh") %>' CssClass="buttonCancle" OnClick="btnShengHe_Click" OnClientClick="return confirm('是否确定合同通过审核？')" Text="审核" />--%>
                    </ItemTemplate>
                   <HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                </asp:TemplateField>
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

        <p class="auto-style5">
            <asp:Button ID="submit" text="保存" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp               
            <asp:Button ID="Button1" text="重填" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClientClick="javascript:return false;"></asp:Button>&nbsp
        </p> 
        </div>
    </form>
</body>
</html>
