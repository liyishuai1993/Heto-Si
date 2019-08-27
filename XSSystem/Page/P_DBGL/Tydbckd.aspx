<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tydbckd.aspx.cs" Inherits="XSSystem.Page.P_Order.Tydbckd" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>铁运调拨出库单</title>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
    <script src="../../js/FormStyle.js"></script>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
    text-align: center;
    border-style: none;
    width: 1200px; font-family: 宋体, Arial, Helvetica, sans-serif; line-height: normal; background-color: #33CCFF;
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
            <telerik:RadScriptManager runat="server" ID="RadScriptManager1"/>
            <p>基本信息</p>
            <table border="0" aria-haspopup="False" class="auto-style1">
                <tr>
                    <td class="auto-style3"><span>编号</span><asp:TextBox ID="bh" runat="server" Height="16px" Width="500px"></asp:TextBox></td>
                    <td class="auto-style3"><span>合同编号</span><asp:TextBox id="htbh" runat="server" name="合同编号" Height="16px" Width ="500px" valued="must1"></asp:TextBox> </td>                                    
                </tr>
                <tr>
                    <td class="auto-style3">公司名称<telerik:RadComboBox RenderMode="Lightweight" ID="tk_gsmc" AutoPostBack="True" runat="server" Width="500px" Height="200px"
  EmptyMessage="请输入供方名称"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains"
   HighlightTemplatedItems="true"/></td>
                    <td class="auto-style3">*发煤煤场<telerik:RadComboBox RenderMode="Lightweight" ID="tk_fmmc" AutoPostBack="True" runat="server" Width="500px" Height="200px"
  EmptyMessage="请输入发煤煤场"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="发煤煤场" valued="must1" 
   HighlightTemplatedItems="true"/></td>
                </tr>
                <tr>
                    <td class="auto-style3"><span>物料名称</span><asp:TextBox id="wlmc" runat="server" name="物料名称" Height="16px" Width ="500px" CssClass="auto-style4" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">装车站<telerik:RadComboBox RenderMode="Lightweight" ID="tk_zcz" AutoPostBack="True" runat="server" Width="500px" Height="200px"
  EmptyMessage="请输入装车站"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" 
   HighlightTemplatedItems="true"/></td>
                </tr>
                <tr>
                    <td class="auto-style3">终到站<telerik:RadComboBox RenderMode="Lightweight" ID="tk_zdz" AutoPostBack="True" runat="server" Width="500px" Height="200px"
  EmptyMessage="请输入终到站"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" 
   HighlightTemplatedItems="true"/> </td>
                    <td class="auto-style3">箱类型<asp:TextBox id="xlx" runat="server" Height="16px" Width ="500px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">卸货吨位<asp:TextBox id="xhdw" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">
                    </td>
                </tr>
                
            </table>     
        </div>


        <div style="margin-top:15px;width:1200px">
            <div class="divcss5">
            <p>集装箱信息 <asp:Button ID="Button2" runat="server" Text="新增记录" OnClick="AddJgxx" /></p>
            <p>
               
                箱号<asp:TextBox id="xh" runat="server" name="箱号" Height="16px" Width ="100px" valued="must2"></asp:TextBox>
                上箱吨数<asp:TextBox id="sxds" cal="must1" runat="server" name="上箱吨数" Height="16px" Width ="100px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                装箱日期<asp:TextBox id="zxrq" Text="" name="装箱日期" onClick="WdatePicker()" runat="server" Height="16px" Width ="100px" valued="must2"></asp:TextBox>
                发车日期<asp:TextBox id="fcrq" Text="" onClick="WdatePicker()" runat="server" Height="16px" Width ="100px"></asp:TextBox>
                调出煤价<asp:TextBox id="dcmj" cal="must1" name="调出煤价" runat="server" Height="16px" Width ="100px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                卸货吨数<asp:TextBox id="xhds" cal="must1" name="卸货吨数" runat="server" Height="16px" Width ="100px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                到站日期<asp:TextBox id="dzrq" Text="" onClick="WdatePicker()" runat="server" Height="16px" Width ="100px"></asp:TextBox>
                </p>
            <p>
                卸货仓库<asp:TextBox id="xhck" runat="server" name="卸货仓库" Height="16px" Width ="100px" valued="must2"></asp:TextBox>     
                自备箱使费(元/组)<asp:TextBox id="zbxsf" cal="must1" runat="server" name="自备箱使费" Height="16px" Width ="100px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                发站代理费(元/组)<asp:TextBox id="fzdlf" runat="server" cal="must1" name="发站代理费" Height="16px" Width ="100px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                发站装箱费(元/吨)<asp:TextBox id="fzzxf" runat="server" cal="must1" name="发站装箱费" Height="16px" Width ="100px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                发站倒短(元/吨)<asp:TextBox id="fzddf" runat="server" cal="must1" name="发站倒短" Height="16px" Width ="100px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> 
                </p>
            <p>
                铁路运费(元/组)<asp:TextBox id="tlyf" runat="server" cal="must1" name="铁路运费" Height="16px" Width ="100px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> 
                到站装卸费(元/组)<asp:TextBox id="dzzxf" runat="server" cal="must1" name="到站装卸费" Height="16px" Width ="100px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> 
                到站-煤场倒短费(元/组)<asp:TextBox id="dzmcddf" cal="must1" runat="server" name="到站-煤场倒短费" Height="16px" Width ="100px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> 
                到站代理费(元/吨)<asp:TextBox id="dzdlf" cal="must1" runat="server" name="到站代理费" Height="16px" Width ="100px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> 
                #调入煤价<asp:TextBox id="drmj" runat="server" Height="16px" Width ="100px" OnKeyPress="isnum()"  ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> 
            
        </p>
            </div>
            <p>
                
                <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="False" ShowHeaderWhenEmpty="true" CellPadding="4" ForeColor="#333333" GridLines="None" >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="箱号" DataField="xh" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="5%" />
                <ItemStyle HorizontalAlign="Left" Width="5%" />
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
                <asp:Button ID="Button1" text="计算表单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="Button1_Click"></asp:Button>&nbsp
                <asp:Button ID="submit" text="保存" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp
                <asp:Button ID="update" text="修改" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="update_Click"></asp:Button>&nbsp
                <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="close_Click"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>
