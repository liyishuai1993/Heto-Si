<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tyxsckd.aspx.cs" Inherits="XSSystem.Page.P_Order.Tyxsckd" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>铁运销售出库单</title>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
    text-align: center;
    border-style: none;
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
    <div> <p class="auto-style5">铁运销售出库单</p>
        <div>
            <telerik:RadScriptManager runat="server" ID="RadScriptManager1"></telerik:RadScriptManager>
            <p>基本信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*编号<asp:TextBox ID="bh" runat="server" Height="16px" Width="500px"></asp:TextBox></td>
                    <td class="auto-style3">合同编号<asp:TextBox id="htbh" name="合同编号" runat="server" Height="16px" Width ="500px" valued="must1"></asp:TextBox> </td>                                    
                </tr>
                <tr>
                    <td class="auto-style3">委托方<telerik:RadComboBox RenderMode="Lightweight" ID="tk_wtf" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入委托方"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="委托方" valued="must1" 
   HighlightTemplatedItems="true"/> </td>
                    <td class="auto-style3">受托方<telerik:RadComboBox RenderMode="Lightweight" ID="tk_stf" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入受托方"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="受托方" valued="must1" 
   HighlightTemplatedItems="true"/></td>
                </tr>
                <tr>
                    <td class="auto-style3">*发煤煤场<telerik:RadComboBox RenderMode="Lightweight" ID="tk_fmmc" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入发煤煤场"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="发煤煤场" valued="must1" 
   HighlightTemplatedItems="true"/> </td>
                    <td class="auto-style3">*物料名称<asp:TextBox id="wlmc" name="物料名称" runat="server" Height="16px" Width ="500px" CssClass="auto-style4" valued="must1"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">煤价<asp:TextBox id="mj" name="煤价" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must1"></asp:TextBox> </td>
                    <td class="auto-style3">装车站<telerik:RadComboBox RenderMode="Lightweight" ID="tk_zcz" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入装车站"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="装车站" valued="must1" 
   HighlightTemplatedItems="true"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">终到站<telerik:RadComboBox RenderMode="Lightweight" ID="tk_zdz" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入终到站"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="终到站" valued="must1" 
   HighlightTemplatedItems="true"/> </td>
                    <td class="auto-style3">箱类型<asp:TextBox id="xlx" runat="server" Height="16px" Width ="500px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">提成标准<asp:TextBox id="tcbz" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">提成金额<asp:TextBox id="tcje" runat="server" Height="16px" Width ="500px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">业务员<asp:TextBox id="ywy" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">卸货吨位<asp:TextBox id="xhdw" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                </tr>

            </table>     
        </div>
        
        <div>
            <div class="divcss5">
            <p>集装箱信息<asp:Button ID="Button2" runat="server" Text="新增记录"  OnClick="AddJgxx"/></p>
            <p>
                
                箱号<asp:TextBox id="xh" runat="server" name="箱号" Height="16px" Width ="150px" valued="must2"></asp:TextBox>
                上箱吨数<asp:TextBox id="sxds" runat="server" name="上箱吨数" Height="16px" Width ="150px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                装箱日期<asp:TextBox id="zxrq" Text="" onClick="WdatePicker()" name="装箱日期" runat="server" Height="16px" Width ="150px" valued="must2"></asp:TextBox>
                发车日期<asp:TextBox id="fcrq" Text="" onClick="WdatePicker()" runat="server" Height="16px" Width ="150px"></asp:TextBox>
                </p>
            <p>
                卸货吨数<asp:TextBox id="xhds" runat="server" Height="16px" name="卸货吨数" Width ="150px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                到站日期<asp:TextBox id="dzrq" Text="" onClick="WdatePicker()" runat="server" Height="16px" Width ="150px"></asp:TextBox>
                结算货款<asp:TextBox id="jshk" runat="server" Height="16px" name="结算货款" Width ="150px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>     
                自备箱使费(元/组)<asp:TextBox id="zbxsf" runat="server" name="自备箱使费" Height="16px" Width ="150px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                </p>
            <p>
                发站代理费(元/组)<asp:TextBox id="fzdlf" runat="server" name="发站代理费" Height="16px" Width ="150px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                发站装箱费(元/吨)<asp:TextBox id="fzzxf" runat="server" name="发站装箱费" Height="16px" Width ="150px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox>
                发站倒短(元/吨)<asp:TextBox id="fzddf" runat="server" name="发站倒短" Height="16px" Width ="150px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> 
                铁路运费(元/组)<asp:TextBox id="tlyf" runat="server" name="铁路运费" Height="16px" Width ="150px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> 
                </p>
            <p>
                到站装卸费(元/组)<asp:TextBox id="dzzxf" runat="server" name="到站装卸费" Height="16px" Width ="150px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> 
                到站-煤场倒短费(元/组)<asp:TextBox id="dzmcddf" runat="server" name="到站-煤场倒短费" Height="16px" Width ="150px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> 
                到站代理费(元/吨)<asp:TextBox id="dzdlf" runat="server" name="到站代理费" Height="16px" Width ="150px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')" valued="must2"></asp:TextBox> 
                铁路运费小计<asp:TextBox id="tlyfxj" runat="server" Height="16px" Width ="150px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> 
            
            </p>
                </div>
            <p>
                
                <asp:GridView ID="GridView1" runat="server" CssClass="xs_table" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="序号" DataField="bh" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="箱号" DataField="xh" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="上箱吨数" DataField="sxds" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="装箱日期" DataField="zxrq" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发车日期" DataField="fcrq" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="卸货吨数" DataField="xhds" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="到站日期" DataField="dzrq" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="结算货款" DataField="jshk" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="自备箱使费(元/组)" DataField="zbxsf" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发站代理费(元/组)" DataField="fzdlf" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发站装箱费(元/吨)" DataField="fzzxf" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发站倒短(元/吨)" DataField="fzddf" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="铁路运费(元/组)" DataField="tlyf" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="到站装卸费(元/组)" DataField="dzzxf" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="到站-煤场倒短费(元/组)" DataField="dzmcddf" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="到站代理费(元/吨)" DataField="dzdlf" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="铁路运费小计" DataField="tlyfxj" HeaderStyle-Width="5%" >
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
                <asp:Button ID="Button1" text="计算表单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="Button1_Click"></asp:Button>&nbsp
                <asp:Button ID="submit" text="保存" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp          
                <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>
