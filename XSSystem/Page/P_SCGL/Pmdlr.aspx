<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pmdlr.aspx.cs" Inherits="XSSystem.Page.P_Order.Pmdlr" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>配煤单录入</title>
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
    <form id="form1" runat="server">
    <div> <p class="auto-style5">配煤单录入</p>
        <div>
            <telerik:RadScriptManager runat="server" ID="RadScriptManager1"></telerik:RadScriptManager>
            <p>基本信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1271px" >
                <tr>
                    <td class="auto-style3">配煤编号<asp:TextBox ID="bh" runat="server" Height="16px" Width="500px"></asp:TextBox></td>
                    <td class="auto-style3">配煤日期<asp:TextBox ID="pmrq" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox> </td>                                    
                </tr>
                
                <tr>
                    <td class="auto-style3">生产煤场<telerik:RadComboBox RenderMode="Lightweight" ID="tk_scmc" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入生产煤场"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="生产煤场" valued="must1" 
   HighlightTemplatedItems="true"/> </td>
                    <td class="auto-style3">公司名称<telerik:RadComboBox RenderMode="Lightweight" ID="tk_gsmc" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入公司名称"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="公司名称" valued="must1" 
   HighlightTemplatedItems="true"/></td>
                </tr>     
            </table>     
        </div>


        <div>
            <p class="auto-style5">原料煤种</p>
            <p>
                <asp:Button ID="ylmz_tjje" runat="server" Text="添加原料" OnClick="ylmz_tjje_Click"/>&nbsp&nbsp 
                原料
                <asp:DropDownList id="YLDropDownList" runat="server" Height="16px" Width ="80px">
                    <asp:ListItem>请选择</asp:ListItem>
                </asp:DropDownList>      
                 原料吨数<asp:TextBox id="ylds" runat="server" Height="16px" Width ="50px" CssClass="auto-style4" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/\D/g,'')"></asp:TextBox>  
                成本单价<asp:TextBox id="cbdj" runat="server" Height="16px" Width ="50px" CssClass="auto-style4" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/\D/g,'')"></asp:TextBox>   
                 配煤费(元/吨)<asp:TextBox id="pmf" runat="server" Height="16px" Width ="50px" CssClass="auto-style4" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/\D/g,'')"></asp:TextBox> 
                 金额(元)<asp:TextBox id="je" runat="server" Height="16px" Width ="50px" CssClass="auto-style4" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/\D/g,'')"></asp:TextBox>
            </p>       
            
            <asp:GridView ID="GridView_YLMZ" runat="server" CssClass="xs_table" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None"  >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="原料" DataField="yl"  >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="原料吨数" DataField="ylds" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                     <asp:BoundField HeaderText="成本单价" DataField="cbdj"  >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="配煤费(元/吨)" DataField="pmf"  >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="金额(元)" DataField="je"  >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:TemplateField  HeaderText="操作">
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("yl") %>' CssClass="buttonCancle"   OnClientClick="return confirm('是否删除？')" Text="删除" />
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

        <div>
            <p class="auto-style5">产出煤种</p>
            <p>
                <asp:Button ID="ccmz_tjje" runat="server" Text="添加产品" OnClick="ccmz_tjje_Click" />&nbsp&nbsp 
                产品
                <asp:DropDownList id="CPDropDownList" runat="server" Height="16px" Width ="80px">
                    <asp:ListItem>请选择</asp:ListItem>
                </asp:DropDownList>
                产出吨数<asp:TextBox id="ccds" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox>
                 金额(元)<asp:TextBox id="je2" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox>
                 成本单价(元/吨)<asp:TextBox id="cbdj2" runat="server" Height="16px" Width ="50px" CssClass="auto-style4"></asp:TextBox>
            </p>
            
            <asp:GridView ID="CPGridView" runat="server" CssClass="xs_table" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None"  >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="产品" DataField="cp"  >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="产出吨数" DataField="cpds" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                     <asp:BoundField HeaderText="金额(元)" DataField="je"  >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="成本单价(元/吨)" DataField="cbdj"  >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:TemplateField  HeaderText="操作">
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("cp") %>' CssClass="buttonCancle"   OnClientClick="return confirm('是否删除？')" Text="删除" />
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
            <asp:Button ID="Button1" text="重填" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp
        </p> 
        </div>
    </form>
</body>
</html>
