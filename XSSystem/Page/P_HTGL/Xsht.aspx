﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Xsht.aspx.cs" Inherits="XSSystem.Page.P_Order.Xsht" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>销售合同</title>
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
            height: auto;
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
    <div> <p class="auto-style5">销售合同</p>
        <div>
            <telerik:RadScriptManager runat="server" ID="RadScriptManager1"></telerik:RadScriptManager>
            <p>基本信息</p>
            <table border="0" aria-haspopup="False" class="auto-style1" style="width: 1200px; font-family: 宋体, Arial, Helvetica, sans-serif; line-height: normal; background-color: #33CCFF;" >
                <tr>
                    <td class="auto-style3">*合同编号<asp:TextBox ID="htbh" runat="server" Height="16px" Width="284px" Enabled="false"></asp:TextBox></td>
                    <td class="auto-style3">*合同类型<asp:DropDownList id="htlx" runat="server" Height="25px" Width ="284px">
                        <asp:ListItem>预付款</asp:ListItem>
                        <asp:ListItem>直供赊销</asp:ListItem>
                        <asp:ListItem>超付</asp:ListItem>
                        </asp:DropDownList> </td>
                    <td class="auto-style3">*签订日期
                        <asp:TextBox ID="qdrq" runat="server" name="签订日期" valued="must1" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">对方合同号<asp:TextBox id="dfhth" name="对方合同号" valued="must1" runat="server" Height="16px" Width ="284px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">*供方名称<telerik:RadComboBox RenderMode="Lightweight" ID="tk_gfmc" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入供方名称"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="供方名称" valued="must1" 
   HighlightTemplatedItems="true"/>
                    </td>
                    <td class="auto-style3">
                        *需方名称<telerik:RadComboBox RenderMode="Lightweight" ID="tk_xfmc" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入需方名称"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="需方名称" valued="must1" 
   HighlightTemplatedItems="true"/>
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
                        货款路耗标准<asp:TextBox id="hklhbz" name="货款路耗标准" valued="must1" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">开票类型<asp:DropDownList id="kplx" runat="server" Height="25px" Width ="284px">
                        <asp:ListItem>无票</asp:ListItem>
                        <asp:ListItem>一票</asp:ListItem>
                        <asp:ListItem>两票</asp:ListItem>
                        <asp:ListItem>原票原转</asp:ListItem>
                        </asp:DropDownList> </td>
                    <td class="auto-style3">执行时间 <asp:TextBox ID="jhsjQ" name="执行时间" valued="must1" runat="server" Text="" onClick="WdatePicker()" Width="142px"></asp:TextBox>-
                        <asp:TextBox ID="jhsjZ" runat="server" Text="" name="执行时间" valued="must1" onClick="WdatePicker()" Width="142px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">货款结算方式<asp:DropDownList id="hkjsfs" runat="server" Height="25px" Width ="284px">
                        <asp:ListItem>现金</asp:ListItem>
                        <asp:ListItem>电汇</asp:ListItem>
                        <asp:ListItem>承兑汇票</asp:ListItem>
                        <asp:ListItem>电汇或承兑</asp:ListItem>
                        <asp:ListItem>电汇加承兑</asp:ListItem>
                        </asp:DropDownList> </td> 
                </tr>
                <tr>
                    <td class="auto-style3">发货地点<telerik:RadComboBox RenderMode="Lightweight" ID="tk_fhdd" AutoPostBack="True" runat="server" Width="284px" Height="200px"
  EmptyMessage="请输入发货地点"   MarkFirstMatch="true"  EnableLoadOnDemand="true" Filter="Contains" name="发货地点" valued="must1" 
   HighlightTemplatedItems="true"/>
                    </td>
                    <td class="auto-style3">运费付款方式<asp:DropDownList ID="yffkfs" runat="server" height="25px" Width="284px">
                        <asp:ListItem>我方付款</asp:ListItem>
                        <asp:ListItem>对方付款</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">煤矿名称<asp:TextBox id="mkmc" name="煤矿名称" valued="must1" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">控制标准<asp:DropDownList ID="kzbz" runat="server" Height="25px" Width="284px">
                        <asp:ListItem>不控制</asp:ListItem>
                        <asp:ListItem>控制余款</asp:ListItem>
                        <asp:ListItem>控制余吨</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">联系电话<asp:TextBox id="lxdh" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="3">备注<asp:TextBox id="bz" runat="server" Height="16px" Width ="1148px"></asp:TextBox>
                    </td>
                </tr>
            </table>            
        </div>

        
        <div style="margin-top:15px">
            <div class="divcss5">
            <p>价格信息<asp:Button ID="Button2" runat="server" Text="新增记录" OnClick="AddJgxx"/></p>
            <p>
                
                结算方式<asp:DropDownList id="mkmcgv" runat="server"  Height="25px" Width ="100px">
                        <asp:ListItem>电汇</asp:ListItem>
                        <asp:ListItem>承兑汇票</asp:ListItem>
                        <asp:ListItem>电汇或承兑</asp:ListItem>
                        </asp:DropDownList>
                煤种名称<asp:TextBox id="mzmc" runat="server" Height="16px" Width ="100px"></asp:TextBox>
                发热量<asp:TextBox id="frl" runat="server" Height="16px" Width ="100px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'-')"></asp:TextBox>
                硫份<asp:TextBox id="lf" runat="server" Height="16px" Width ="100px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
            开票煤价<asp:TextBox id="kpmj" runat="server" Height="16px" Width ="100px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>    
            </p>
            <p>
                
                合同煤价<asp:TextBox id="htmj" runat="server" Height="16px" cal="must1" name="合同煤价" Width ="100px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                扣损率<asp:TextBox id="ksl" runat="server" Height="16px" Width ="100px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                签订吨数<asp:TextBox id="qdds" runat="server" Height="16px" Width ="100px" cal="must1" name="签订吨数" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                #签订金额<asp:TextBox id="qdje" runat="server" Height="16px" Width ="100px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                状态<asp:TextBox id="zt" runat="server" Height="16px" Width ="100px"></asp:TextBox>
            </p>
                </div>
            <p>
                
                <asp:GridView ID="GridView2" runat="server" CssClass="xs_table" ShowHeaderWhenEmpty="true" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="序号" DataField="bh" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="煤矿名称" DataField="mkmc" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="煤种名称" DataField="mzmc" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发热量" DataField="frl" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="硫份" DataField="lf" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="开票煤价" DataField="kpmj" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="合同煤价" DataField="htmj" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="扣损率" DataField="ksl" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="签订吨数" DataField="qdds" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="签订金额" DataField="qdje" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="状态" DataField="zt" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderStyle-Width="10%" HeaderText="操作">
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("bh") %>' CssClass="buttonCancle" OnClick="DelJgxx" OnClientClick="return confirm('是否删除？')" Text="删除" />
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


        <div>
            <div class="divcss5">
            <p>质量标准<asp:Button ID="Button1" runat="server" Text="新增记录" OnClick="AddZlbz"/></p>
            <p>
               
                煤种<asp:TextBox id="mz" runat="server" Height="16px" Width ="80px"></asp:TextBox>
                粒度<asp:TextBox id="ld" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'-')"></asp:TextBox>
                灰分<asp:TextBox id="hf" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'-')"></asp:TextBox>
                挥发分<asp:TextBox id="hff" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'-')"></asp:TextBox>
                固定碳<asp:TextBox id="gdt" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                粘结指数<asp:TextBox id="njzs" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                                </p>
            <p>
                水分<asp:TextBox id="sf" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                铁<asp:TextBox id="tie" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                铝<asp:TextBox id="lv" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                钙<asp:TextBox id="gai" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                磷<asp:TextBox id="lin" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                钛<asp:TextBox id="tai" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                硫<asp:TextBox id="liu" runat="server" Height="16px" Width ="80px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
            
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
                        <asp:BoundField HeaderText="煤种" DataField="mz" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="粒度%-%" DataField="ld" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="灰分%-%" DataField="hf" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="挥发份%-%" DataField="hff" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="固定碳≥%" DataField="gdt" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="粘结指数≥%" DataField="njzs" HeaderStyle-Width="10%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="水分≤%" DataField="sf" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="铁≤%" DataField="tie" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="铝≤%" DataField="lv" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="钙≤%" DataField="gai" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="磷≤%" DataField="lin" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="钛≤%" DataField="tai" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="硫≤%" DataField="liu" HeaderStyle-Width="5%" >
<HeaderStyle HorizontalAlign="Left" Width="10%" />
                <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderStyle-Width="10%" HeaderText="操作">
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("bh") %>' CssClass="buttonCancle"  OnClick="DelZlbz" OnClientClick="return confirm('是否删除？')" Text="删除" />
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
            <asp:Button ID="Button3" text="计算表单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="Button3_Click"></asp:Button>&nbsp
                <asp:Button ID="submit" text="保存" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp
                <asp:Button ID="update" text="修改" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="update_Click"></asp:Button>&nbsp
                <asp:Button ID="refresh" text="审核" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="btnShengHe_Click"></asp:Button>&nbsp
                <asp:Button ID="done" text="执行" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="btnZhiXing_Click"></asp:Button>&nbsp
                <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
            </p> 
        </div>
    </form>
</body>
</html>
