<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tyht.aspx.cs" Inherits="XSSystem.Page.P_Order.Tyht" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>铁运合同</title>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <link href="../../style/sysCss.css" rel="stylesheet" />
        <script src="../../js/FormStyle.js"></script>
    <style type="text/css">
        .autosize{
            height:auto;
            width:auto;
        }
        .auto-style3 {
            height: auto;
            width:400px;
            text-align:right;

            }
        .Wdate {}
        .auto-style5 {
            height:auto;
            width:auto;
            text-align:center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div> <p class="auto-style5">铁运合同</p>
        <telerik:RadScriptManager runat="server" ID="RadScriptManager1"></telerik:RadScriptManager>
        <div class="autosize">
            <p>基本信息</p>
            <%--<table border="1" aria-haspopup="False" class="xs_table" style="width: 1200px;table-layout:fixed;" >--%>
                <table border="0" aria-haspopup="False" class="auto-style1" style="width: 1200px; font-family: 宋体, Arial, Helvetica, sans-serif; line-height: normal; background-color: #33CCFF;" >
                <tr>
                    <td class="auto-style3" style="table-layout: fixed">*合同编号<asp:TextBox ID="htbh" runat="server" Height="16px" Width="284px"  Enabled="False"></asp:TextBox></td>
                    <td class="auto-style3">*合同类型<asp:DropDownList id="htlx" runat="server" height="25px" Width="284px" >
                        <asp:ListItem>预付款</asp:ListItem>
                        <asp:ListItem>直供赊销</asp:ListItem>
                        <asp:ListItem>超付</asp:ListItem>
                        </asp:DropDownList> </td>
                    <td class="auto-style3">*签订日期
                        <asp:TextBox ID="qdrq" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    
                    <td class="auto-style3">*委托方<telerik:RadComboBox RenderMode="Lightweight" ID="tk_wtf" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入委托方"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="委托方" valued="must1" 
   HighlightTemplatedItems="true"/>
                    </td>
                    <td class="auto-style3">
                        *受托方<telerik:RadComboBox RenderMode="Lightweight" ID="tk_stf" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入受托方"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="受托方" valued="must1" 
   HighlightTemplatedItems="true"/>
                   </td> 
                    <td class="auto-style3">
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" style="table-layout: fixed">*发煤煤场<telerik:RadComboBox RenderMode="Lightweight" ID="tk_fmmc" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输发煤煤场"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="发煤煤场" valued="must1" 
   HighlightTemplatedItems="true"/>
                    </td>
                    <td class="auto-style3">物料名称<telerik:RadComboBox RenderMode="Lightweight" ID="tk_wlmc" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输物料名称"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="物料名称" valued="must1" 
   HighlightTemplatedItems="true"/>
                    </td>
                    <td class="auto-style3">执行期限
               <asp:TextBox ID="zxqxQ" runat="server" Text="" onClick="WdatePicker()" Width="140px"></asp:TextBox>-
                        <asp:TextBox ID="zxqxZ" runat="server" Text="" onClick="WdatePicker()" Width="140px"></asp:TextBox>
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">*装车站<telerik:RadComboBox RenderMode="Lightweight" ID="tk_zcz" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入装车站"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="装车站" valued="must1" 
   HighlightTemplatedItems="true"/>
                    </td>
                    <td class="auto-style3">*终到站<telerik:RadComboBox RenderMode="Lightweight" ID="tk_zdz" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入终到站"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="终到站" valued="must1" 
   HighlightTemplatedItems="true"/>
                    </td>
                    <td class="auto-style3"></td> 
                </tr>
                <tr>
                    <td class="auto-style3">*箱类型<asp:DropDownList id="xlx" runat="server" Height="25px" Width="284px">
                        <asp:ListItem>铁路箱</asp:ListItem>
                        <asp:ListItem>自备箱</asp:ListItem>
                       </asp:DropDownList> 
                    </td>
                    <td class="auto-style3">数量(组)<asp:TextBox id="sl" runat="server" Height="16px" Width="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3"> </td>
                </tr>
       
            </table>            
        </div>

        <div style="margin-top:15px">
            <div class="divcss5">
            <p>价格信息(元/吨)<asp:Button ID="Button1" runat="server" Text="新增记录" OnClick="AddJgxx" /></p>
            <span>
                
                公司名称<telerik:RadComboBox RenderMode="Lightweight" ID="tk_gsmc" AutoPostBack="True" runat="server" Width="140px" Height="200px"
  EmptyMessage="请输入公司名称"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="公司名称" valued="must1" 
   HighlightTemplatedItems="true"/>
                对方合同号<asp:TextBox id="dfhth" runat="server" Height="16px" Width ="100px"></asp:TextBox>
                开票类型<asp:TextBox id="kplx" runat="server" Height="16px" Width ="100px"></asp:TextBox>
                
                </span>
            <p>
                自备箱使费(元/组)<asp:TextBox id="zbxsf" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                代理费(元/组)<asp:TextBox id="dlf" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                装箱费(元/吨)<asp:TextBox id="zxf" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                始发站倒短(元/吨)<asp:TextBox id="sfzdd" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>     
                
                </p>
            <p>
                铁路运费(元/组)<asp:TextBox id="tlyf" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                到站装卸费(元/组)<asp:TextBox id="dzzxf" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                到站-煤场倒短费(元/组)<asp:TextBox id="dzmcddf" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                到站代理费(元/组)<asp:TextBox id="dzdlf" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>         
            
            </p>
                </div>
            <p>
                
                <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" EmptyDataText="无记录" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="序号" DataField="bh" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="公司名称" DataField="gsmc" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="对方合同号" DataField="dfhth" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                         <asp:BoundField HeaderText="开票类型" DataField="kplx" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="自备箱使费(元/组)" DataField="zbxsf" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="代理费(元/组)" DataField="dlf" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="装箱费(元/吨)" DataField="zxf" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="始发站倒短(元/吨)" DataField="sfzdd" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="铁路运费(元/组)" DataField="tlyf" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="到站装卸费(元/组)" DataField="dzzxf" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="到站-煤场倒短费(元/组)" DataField="dzmcddf" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="到站代理费(元/组)" DataField="dzdlf" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                    <asp:TemplateField HeaderStyle-Width="10%" HeaderText="操作">
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("bh") %>' CssClass="buttonCancle"  OnClick="DelJgxx" OnClientClick="return confirm('是否删除？')" Text="删除" />
                        <%--<asp:Button ID="btnShenghe" runat="server" actionid="03" CommandArgument='<%#Eval("htbh") %>' CssClass="buttonCancle" OnClick="btnShengHe_Click" OnClientClick="return confirm('是否确定合同通过审核？')" Text="审核" />--%>
                    </ItemTemplate>
                    <HeaderStyle Width="5%" />
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
            </p>
            

                   
        </div>

        <p class="auto-style5">
                <asp:Button ID="submit" text="保存" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp
                <asp:Button ID="update" text="修改" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="update_Click"></asp:Button>&nbsp
                <asp:Button ID="refresh" text="审核" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="btnShengHe_Click"></asp:Button>&nbsp
                <asp:Button ID="done" text="执行" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="btnZhiXing_Click"></asp:Button>&nbsp
                <asp:Button ID="close" text="关闭" runat ="server" width="90px"   BorderStyle="Groove" BackColor="Aqua"></asp:Button>
            </p> 
        </div>
    </form>
</body>
</html>