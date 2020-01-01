<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rsclr.aspx.cs" Inherits="XSSystem.Page.P_Order.Rsclr" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>日生产录入</title>
    <link href="../../style/FormStyle.css" rel="stylesheet" />
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <script src="../../js/FormStyle.js"></script>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            border-style: none;
            width: 1200px;
            font-family: 宋体, Arial, Helvetica, sans-serif;
            line-height: normal;
            background-color: #33CCFF;
        }

        .auto-style3 {
            height: 20px;
            width: 640px;
            text-align: right;
        }

        .Wdate {
        }

        .auto-style4 {
            text-align: left;
        }

        .auto-style5 {
            height: auto;
            width: auto;
            text-align: center;
        }

        .auto-style6 {
            border: 1px dashed #147393;
            height: auto;
            width: auto;
            padding: 4px;
            margin-top: 15px;
        }
    </style>
    <script type="text/javascript">
        function FormCheck() {
            var a = document.getElementById("klcl").value;
            var b = document.getElementById("hhmcl").value;
            var c = document.getElementById("mmcl").value;
            var d = document.getElementById("zmcl").value;
            var e = document.getElementById("nmcl").value;
            var f = document.getElementById("gscl").value;
            document.getElementById("shl").value = (100 - a - b - c - d - e - f).toFixed(2);

        }

        function calJE() {
            var a = document.getElementById("scxx_sl").value;
            var b = document.getElementById("sxcc_dj").value;
           
            document.getElementById("scxx_je").value = (a * b).toFixed(2);

        }
    </script>
</head>
<body style="height: auto; width: auto">
    <form id="form1" runat="server" defaultbutton="Button1">
        <div>
            <telerik:RadScriptManager runat="server" ID="RadScriptManager1"></telerik:RadScriptManager>
            <p class="auto-style5">日生产录入</p>
            <div>
                <p>基本信息</p>
                <table border="0" aria-haspopup="False" class="auto-style1" style="width: 900px">
                    <tr hidden="hidden">
                        <td>
                            <asp:TextBox ID="bh" runat="server" Visible="false"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>所属煤场</span><asp:TextBox ID="ssmc" valued="must1" name="所属煤场" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                        <td class="auto-style3"><span>日期</span><asp:TextBox ID="rq" runat="server" name="日期" valued="must1" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>开机时间</span><asp:TextBox ID="kjsj" name="开机时间" runat="server" valued="must1" Text="" onClick="WdatePicker({dateFmt:'HH:mm:ss'})" Width="284px"></asp:TextBox></td>
                        <td class="auto-style3"><span>关机时间</span><asp:TextBox ID="gjsj" name="关机时间" runat="server" valued="must1" Text="" onClick="WdatePicker({dateFmt:'HH:mm:ss'})" Width="284px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">班次<asp:DropDownList ID="bc" runat="server" Height="20px" Width="284px" CssClass="auto-style4">
                            <asp:ListItem>白班</asp:ListItem>
                            <asp:ListItem>中班</asp:ListItem>
                            <asp:ListItem>夜班</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                        <td class="auto-style3"><span>用电总数(度)</span><asp:TextBox ID="ydzs" name="用电总数" runat="server" valued="must1" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>用电吨耗(吨/度)</span><asp:TextBox ID="yddh" name="用电吨耗" runat="server" valued="must1" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        </td>
                        <td class="auto-style3"><span>用煤总数(吨)</span><asp:TextBox ID="ymzs" name="用煤总数" runat="server" valued="must1" Height="16px" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">公司名称
                            <telerik:RadComboBox RenderMode="Lightweight" ID="DropDownList_gsmc" runat="server" Width="284px" Height="400px"
                                EmptyMessage="请输入公司名称" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="公司名称" valued="must1"
                                HighlightTemplatedItems="true">
                            </telerik:RadComboBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span>加工费金额</span>
                            <asp:TextBox ID="jgfje" name="加工费金额" runat="server" Height="16px" valued="must1" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td>
                        <td class="auto-style3"><span>每吨费用(元/吨)</span><asp:TextBox ID="mdfy" name="每吨费用" runat="server" Height="16px" valued="must1" Width="284px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                    </tr>
                </table>
            </div>

            <div class="auto-style6">
                <p class="auto-style5">生产</p>
                <%--                <p>
                    <asp:Button ID="Button4" runat="server" Text="新增产率" OnClick="scxx_tjmz_Click" />&nbsp&nbsp
                </p>--%>
                <p>
                    颗粒产率%<asp:TextBox ID="klcl" runat="server" name="颗粒产率" valued="must2" Height="16px" Width="45px" CssClass="auto-style4" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'.')"></asp:TextBox>
                    混合煤产率%<asp:TextBox ID="hhmcl" runat="server" name="混合煤产率" valued="must2" Height="16px" Width="45px" CssClass="auto-style4" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'.')"></asp:TextBox>
                    沫煤产率%<asp:TextBox ID="mmcl" runat="server" name="沫煤产率" valued="must2" Height="16px" Width="45px" CssClass="auto-style4" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'.')"></asp:TextBox>
                    中煤产率%<asp:TextBox ID="zmcl" runat="server" name="中煤产率" valued="must2" Height="16px" Width="45px" CssClass="auto-style4" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'.')"></asp:TextBox>
                    煤泥产率%<asp:TextBox ID="nmcl" runat="server" name="煤泥产率" valued="must2" Height="16px" Width="45px" CssClass="auto-style4" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'.')"></asp:TextBox>
                    矸石产率%<asp:TextBox ID="gscl" OnBlur="FormCheck()" runat="server" name="矸石产率" valued="must2" Height="16px" Width="45px" CssClass="auto-style4" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'.')"></asp:TextBox>
                    #损耗率%<asp:TextBox ID="shl" BackColor="LightBlue" runat="server" OnFocus="FormCheck()" name="损耗率" valued="must2" Height="16px" Width="45px" CssClass="auto-style4" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'.')"></asp:TextBox>
                </p>

            </div>

            <div class="auto-style6">
                <p class="auto-style5">生产信息</p>

                <p>
                    <asp:Button ID="scxx_tjmz" runat="server" Text="添加煤种" OnClick="scxx_tjmz_Click" />&nbsp&nbsp
                <telerik:RadComboBox RenderMode="Lightweight" ID="DropDownListMZ" runat="server" Width="80px" Height="400px"
                    EmptyMessage="选择" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="公司名称" valued="must2"
                    HighlightTemplatedItems="true">
                </telerik:RadComboBox>
                    数量(t):<asp:TextBox ID="scxx_sl" valued="must2" cal="must1" name="数量" runat="server" Height="16px" Width="80px" CssClass="auto-style4" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>&nbsp
                单价:<asp:TextBox ID="sxcc_dj" valued="must2" OnBlur="calJE()" cal="must1" name="单价" runat="server" Height="16px" Width="80px" CssClass="auto-style4" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>&nbsp
                #金额<asp:TextBox ID="scxx_je" BackColor="LightBlue"  OnFocus="calJE()" runat="server" name="金额" valued="must2" Height="16px" Width="80px" CssClass="auto-style4" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'.')"></asp:TextBox>
                </p>

                <asp:GridView ID="GridView_SCXX" runat="server" CssClass="xs_table" ShowHeaderWhenEmpty="true" EmptyDataText="无记录" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="编号" DataField="bh" Visible="false">
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
                        <asp:BoundField HeaderText="单价" DataField="dj">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="金额" DataField="je">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="数量" DataField="sl">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="操作">
                            <ItemTemplate>
                                <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("bh") %>' CssClass="buttonCancle" OnClick="DelScxx" OnClientClick="return confirm('是否删除？')" Text="删除" />
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




            <div class="auto-style6">
                <p class="auto-style5">产出信息</p>
                <p>
                    <asp:Button ID="ccxx_tjmz" runat="server" Text="添加煤种" OnClick="ccxx_tjmz_Click" />&nbsp&nbsp
                <telerik:RadComboBox RenderMode="Lightweight" ID="DropDownListMZ2" runat="server" Width="80px" Height="400px"
                    EmptyMessage="选择" MarkFirstMatch="true" EnableLoadOnDemand="true" Filter="Contains" name="公司名称" valued="must"
                    HighlightTemplatedItems="true">
                </telerik:RadComboBox>
                    数量(t):<asp:TextBox ID="ccxx_sl" valued="must3" name="数量" runat="server" Height="16px" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>&nbsp
                金额<asp:TextBox ID="ccxx_je" runat="server" valued="must3" name="金额" Height="16px" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                    单价<asp:TextBox ID="ccxx_cl" runat="server" valued="must3" name="产率" Height="16px" Width="80px" OnKeyPress="isnum()" ToolTip="纯数字" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>
                </p>

                <asp:GridView ID="GridView_CCXX" runat="server" CssClass="xs_table" ShowHeaderWhenEmpty="true" EmptyDataText="无记录" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="编号" DataField="bh">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="煤种" DataField="mz">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="金额" DataField="je">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="数量" DataField="sl">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="单价" DataField="cl">
                            <HeaderStyle HorizontalAlign="Left" Width="10%" />
                            <ItemStyle HorizontalAlign="Left" Width="10%" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="操作">
                            <ItemTemplate>
                                <asp:Button ID="btnDelete" runat="server" actionid="04" CommandArgument='<%#Eval("bh") %>' CssClass="buttonCancle" OnClick="DelCcxx" OnClientClick="return confirm('是否删除？')" Text="删除" />
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
                <asp:Button ID="Button4" Text="校验金额" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="Button4_Click"></asp:Button>&nbsp               
                <asp:Button ID="add" Text="保存" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp   
                <asp:Button ID="update" Text="修改" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="update_Click"></asp:Button>&nbsp               
            <asp:Button ID="Button1" Text="关闭" runat="server" Width="90px" BorderStyle="Groove" BackColor="Aqua" OnClick="Button1_Click"></asp:Button>&nbsp
            </p>
        </div>
    </form>
</body>
</html>
