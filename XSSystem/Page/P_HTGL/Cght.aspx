<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cght.aspx.cs" Inherits="XSSystem.Page.P_Order.Cght" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>采购合同</title>
    <script src="../../My97DatePicker/WdatePicker.js" type="text/javascript"></script>
    <script src="../../My97DatePicker/calendar.js" type="text/javascript"></script>
    <script src="../../My97DatePicker/config.js" type="text/javascript"></script>
    <script src="../../js/FormStyle.js"></script>
    <link href="../../style/sysCss.css" rel="stylesheet" />
    <link href="../../My97DatePicker/skin/WdatePicker.css" rel="stylesheet" />
    <link href="../../style/FormStyle.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function FormCheck() {
            var a = document.getElementById("htmj").value;
            var b = document.getElementById("qdds").value;
            document.getElementById("qdje").value = (a * b).toFixed(2);


            
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadScriptManager runat="server" ID="RadScriptManager1"></telerik:RadScriptManager>
        <div>
            <p class="auto-style5">采购合同</p>
            <div>
                <p>基本信息</p>
                <table border="0" aria-haspopup="False" class="auto-style1" style="width: 1200px; font-family: 宋体, Arial, Helvetica, sans-serif; line-height: normal; background-color: #33CCFF;">
                    <%--<table border="1" aria-haspopup="False" class="xs_table" style="width: 1200px"  >--%>
                    <tr>
                        <td class="auto-style3"><span>合同编号</span><asp:TextBox ID="htbh" runat="server" Height="16px" Width="284px" ReadOnly="true" Enabled="False"></asp:TextBox></td>
                        <td class="auto-style3"><span>合同类型</span><asp:DropDownList ID="htlx" runat="server" Height="25px" Width="284px">
                            <asp:ListItem Value="yfk">预付款</asp:ListItem>
                            <asp:ListItem>直供赊销</asp:ListItem>
                            <asp:ListItem>超付</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                        <td class="auto-style3"><span>签订日期</span>
                            <asp:TextBox ID="qdrq" runat="server" name="签订日期" valued="must1" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                        </td>

                    </tr>
                    <tr>
                        <td class="auto-style3"><span>对方合同号</span><asp:TextBox ID="dfhth" name="对方合同号" valued="must1" runat="server" Height="16px" Width="284px"></asp:TextBox>
                        </td>
                        <td class="auto-style3"><span>供方名称</span><telerik:RadComboBox RenderMode="Lightweight" ID="DropDownList_gfmc" runat="server" Width="284px" Height="200px"
                            EmptyMessage="请输入供方名称" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="供方名称" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                        <td class="auto-style3"><span>需方名称</span><telerik:RadComboBox RenderMode="Lightweight" ID="DropDownList_xfmc" runat="server" Width="284px" Height="200px"
                            EmptyMessage="请输入需方名称" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="需方名称" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>货款结算依据</span><asp:DropDownList ID="hkjsyj" runat="server" Height="25px" Width="284px" CssClass="auto-style4">
                            <asp:ListItem>原发净重</asp:ListItem>
                            <asp:ListItem>收货净重</asp:ListItem>
                            <asp:ListItem>原发净重减扣吨</asp:ListItem>
                            <asp:ListItem>收货净重减扣吨</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                        <td class="auto-style3"><span>货款路耗类型</span><asp:DropDownList ID="hklhlx" runat="server" Height="25px" Width="284px">
                            <asp:ListItem>不计路耗</asp:ListItem>
                            <asp:ListItem>百分之或千分比</asp:ListItem>
                            <asp:ListItem>吨数</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                        <td class="auto-style3">
                            <span>货款路耗标准</span><asp:TextBox ID="hklhbz" runat="server" name="货款路耗标准" valued="must1" Height="16px" Width="284px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>开票类型</span><asp:DropDownList ID="kpxx" runat="server" Height="25px" Width="284px">
                            <asp:ListItem>无票</asp:ListItem>
                            <asp:ListItem>一票</asp:ListItem>
                            <asp:ListItem>两票</asp:ListItem>
                            <asp:ListItem>原票原转</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                        <td class="auto-style3"><span>执行时间</span><asp:TextBox ID="jhsjQ" name="执行时间" valued="must1" runat="server" Text="" onClick="WdatePicker()" Width="142px"></asp:TextBox>-
                        <asp:TextBox ID="jhsjZ" runat="server" Text="" name="执行时间" valued="must1" onClick="WdatePicker()" Width="142px"></asp:TextBox>
                        </td>
                        <td class="auto-style3"><span>货款结算方式</span><asp:DropDownList ID="hkjsfs" runat="server" Height="25px" Width="284px">
                            <asp:ListItem>现金</asp:ListItem>
                            <asp:ListItem>电汇</asp:ListItem>
                            <asp:ListItem>承兑汇票</asp:ListItem>
                            <asp:ListItem>电汇或承兑</asp:ListItem>
                            <asp:ListItem>电汇加承兑</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>交货地点</span><telerik:RadComboBox RenderMode="Lightweight" ID="tk_jhdd" runat="server" Width="284px" Height="200px"
                            EmptyMessage="请输入交货地点" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="供方名称" valued="must1"
                            HighlightTemplatedItems="true" />
                        </td>
                        <td class="auto-style3">运费付款方式<asp:DropDownList ID="yffkfs" runat="server" Height="25px" Width="284px">
                            <asp:ListItem>我方付款</asp:ListItem>
                            <asp:ListItem>对方付款</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                        <td class="auto-style3" hidden="hidden"><span>煤矿名称</span><asp:TextBox ID="mkmc" name="煤矿名称" runat="server" Height="16px" Width="284px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4" colspan="3">备注<asp:TextBox ID="bz" runat="server" Height="16px" Width="1148px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>


            <div style="margin-top: 20px">
                <div class="divcss5">
                    <p>价格信息<asp:Button ID="Button2" runat="server" Text="新增记录" OnClick="AddJgxx" /></p>
                    <p class="pstyle">
                        结算方式<asp:DropDownList ID="mkmcgv" runat="server" Height="25px" Width="100px">
                            <asp:ListItem>电汇</asp:ListItem>
                            <asp:ListItem>承兑汇票</asp:ListItem>
                            <asp:ListItem>电汇或承兑</asp:ListItem>
                        </asp:DropDownList>
                        物料名称<asp:TextBox ID="mzmc" valued="must2" name="煤种名称" runat="server" Height="16px" Width="100px"></asp:TextBox>
                        发热量<asp:TextBox ID="frl" valued="must2" name="发热量" runat="server" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'-')"></asp:TextBox>
                        硫份<asp:TextBox ID="lf" valued="must2" name="硫份" runat="server" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        开票煤价<asp:TextBox ID="kpmj" valued="must2" name="开票煤价" runat="server" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                    </p>
                    <p class="pstyle">

                        <span>合同煤价</span><asp:TextBox ID="htmj" valued="must2" runat="server" Height="16px" cal="must1" name="合同煤价" Width="100px" OnKeyPress="isnum()" OnBlur="FormCheck()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        扣损率<asp:TextBox ID="ksl" valued="must2" name="扣损率" runat="server" Height="16px" Width="100px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        <span>签订吨数</span><asp:TextBox ID="qdds" valued="must2" runat="server" Height="16px" Width="100px" cal="must1" name="签订吨数" OnBlur="FormCheck()" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        <asp:Label runat="server" ForeColor="MediumBlue">签订金额</asp:Label>
                        <asp:TextBox ID="qdje" valued="must2" name="签订金额" BackColor="LightBlue" runat="server" Height="16px" Width="100px" OnKeyPress="isnum()" OnFocus="FormCheck()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        状态<asp:TextBox ID="zt" runat="server" Height="16px" Width="100px"></asp:TextBox>
                    </p>
                </div>
                <p>
                    <asp:GridView ID="GridView_JGXX" runat="server" CssClass="xs_table" ShowHeaderWhenEmpty="true" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField HeaderText="序号" Visible="false" DataField="bh">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                                <HeaderTemplate>
                                    序号
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="煤矿名称" DataField="mkmc">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="煤种名称" DataField="mzmc">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="发热量" DataField="frl">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="硫份" DataField="lf">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="开票煤价" DataField="kpmj">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="合同煤价" DataField="htmj">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="扣损率" DataField="ksl">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="签订吨数" DataField="qdds">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="签订金额" DataField="qdje">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="状态" DataField="zt">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="操作">
                                <ItemTemplate>
                                    <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("bh") %>' CssClass="buttonCancle" OnClick="DelJgxx" OnClientClick="return confirm('是否删除？')" Text="删除" />
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
                </p>
            </div>



            <div>
                <div class="divcss5">
                    <p>质量标准<asp:Button ID="Button1" runat="server" Text="新增记录" OnClick="AddZlbz" /></p>
                    <p>
                        煤种<asp:TextBox ID="mz" valued="must3" name="煤种" runat="server" Height="16px" Width="80px"></asp:TextBox>
                        粒度<asp:TextBox ID="ld" runat="server" valued="must3" name="粒度" Height="16px" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'-')"></asp:TextBox>
                        灰分<asp:TextBox ID="hf" runat="server" valued="must3" name="灰分" Height="16px" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'-')"></asp:TextBox>
                        挥发分<asp:TextBox ID="hff" runat="server" valued="must3" name="挥发分" Height="16px" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'-')"></asp:TextBox>
                        固定碳<asp:TextBox ID="gdt" runat="server" valued="must3" name="固定碳" Height="16px" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        粘结指数<asp:TextBox ID="njzs" runat="server" valued="must3" name="粘结指数" Height="16px" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                    </p>
                    <p>
                        水分<asp:TextBox ID="sf" runat="server" Height="16px" valued="must3" name="水分" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        铁<asp:TextBox ID="tie" runat="server" Height="16px" valued="must3" name="铁" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        铝<asp:TextBox ID="lv" runat="server" Height="16px" valued="must3" name="铝" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        钙<asp:TextBox ID="gai" runat="server" Height="16px" valued="must3" name="钙" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        磷<asp:TextBox ID="lin" runat="server" Height="16px" valued="must3" name="磷" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        钛<asp:TextBox ID="tai" runat="server" Height="16px" valued="must3" name="钛" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        硫<asp:TextBox ID="liu" runat="server" Height="16px" valued="must3" name="硫" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                    </p>
                </div>
                <p>
                    <asp:GridView ID="GridView_ZLBZ" runat="server" CssClass="xs_table" ShowHeaderWhenEmpty="true" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField HeaderText="序号" Visible="false" DataField="bh">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                                <HeaderTemplate>
                                    序号
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="煤种" DataField="mz">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="粒度%-%" DataField="ld">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="灰分%-%" DataField="hf">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="挥发份%-%" DataField="hff">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="固定碳≥%" DataField="gdt">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="粘结指数≥%" DataField="njzs">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="水分≤%" DataField="sf">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="铁≤%" DataField="tie">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="铝≤%" DataField="lv">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="钙≤%" DataField="gai">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="磷≤%" DataField="lin">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="钛≤%" DataField="tai">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="硫≤%" DataField="liu">
                                <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" Width="10%" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="操作">
                                <ItemTemplate>
                                    <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("bh") %>' CssClass="buttonCancle" OnClick="DelZlbz" OnClientClick="return confirm('是否删除？')" Text="删除" />
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
                </p>



            </div>

            <p class="auto-style5">
                <asp:Button ID="add" Text="新增" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp
                <asp:Button ID="update" Text="修改" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="update_Click"></asp:Button>&nbsp    
                <asp:Button ID="shenhe" Text="审核" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="btnShengHe_Click"></asp:Button>&nbsp
                <asp:Button ID="done" Text="执行" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="btnZhiXing_Click"></asp:Button>&nbsp
                <asp:Button ID="close" Text="关闭" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="close_Click"></asp:Button>
            </p>
        </div>
    </form>
</body>
</html>
