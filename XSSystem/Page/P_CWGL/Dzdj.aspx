<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dzdj.aspx.cs" Inherits="XSSystem.Page.P_Order.Dzdj" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>调账单据</title>
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
            width:400px;
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
    <div> <p class="auto-style5">调账单据</p>
        <div>
            <p>资金增加</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*编号<asp:TextBox ID="zjzj_bh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>  <%--FY+日期+序号--%>
                    <td class="auto-style3">日期<asp:TextBox ID="zjzj_rq" runat="server" Height="25px" Width="284px" CssClass="auto-style4" Text="" onClick="WdatePicker()"></asp:TextBox></td>
                    <td class="auto-style3">公司名称<asp:TextBox id="zjzj_gsmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">收入名称<asp:TextBox id="zjzj_srmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">金额<asp:TextBox id="zjzj_je" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td>
                    <td class="auto-style3">账户<asp:TextBox id="zjzj_zh" runat="server" Height="16px" Width ="284px"></asp:TextBox></td> 
                </tr>
                <tr>
                    <td class="auto-style3">实收金额<asp:TextBox id="zjzj_ssje" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">备注<asp:TextBox id="zjzj_bz" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3"> </td>                  
                </tr>
            </table>     
            <p class="auto-style5">
                <asp:Button ID="submit" text="提交" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p>        
        </div>

        <div>
            <p>资金减少</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*编号<asp:TextBox ID="zjjs_bh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>  <%--FY+日期+序号--%>
                    <td class="auto-style3">日期<asp:TextBox ID="zjjs_rq" runat="server" Height="25px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">公司名称<asp:TextBox id="zjjs_gsmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">费用名称<asp:TextBox id="zjjs_fymc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">金额<asp:TextBox id="zjjs_je" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td>
                    <td class="auto-style3">账户<asp:TextBox id="zjjs_zh" runat="server" Height="16px" Width ="284px"></asp:TextBox></td> 
                </tr>
                <tr>
                    <td class="auto-style3">实付金额<asp:TextBox id="zjjs_sfje" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">备注<asp:TextBox id="zjjs_bz" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3"> </td>                  
                </tr>
            </table>     
            <p class="auto-style5">
                <asp:Button ID="Button1" text="提交" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p>        
        </div>

        <div>
            <p>应收款增加</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*编号<asp:TextBox ID="yskzj_bh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>  <%--FY+日期+序号--%>
                    <td class="auto-style3">日期<asp:TextBox ID="yskzj_rq" runat="server" Height="25px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">公司名称<asp:TextBox id="yskzj_gsmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">往来单位<asp:TextBox id="yskzj_wldw" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">收入名称<asp:TextBox id="yskzj_srmc" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3">增加金额<asp:TextBox id="yskzj_zjje" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td> 
                </tr>
                <tr>
                   
                    <td class="auto-style3">备注<asp:TextBox id="yskzj_bz" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3"> </td>        
                    <td class="auto-style3"> </td>             
                </tr>
            </table>     
            <p class="auto-style5">
                <asp:Button ID="Button2" text="提交" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p>        
        </div>

        <div>
            <p>应收款减少</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*编号<asp:TextBox ID="yskjs_bh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>  <%--FY+日期+序号--%>
                    <td class="auto-style3">日期<asp:TextBox ID="yskjs_rq" runat="server" Height="25px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">公司名称<asp:TextBox id="yskjs_gsmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">往来单位<asp:TextBox id="yskjs_wldw" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">费用名称<asp:TextBox id="yskjs_fymc" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3">减少金额<asp:TextBox id="yskjs_jsje" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td> 
                </tr>
                <tr>
                   
                    <td class="auto-style3">备注<asp:TextBox id="yskjs_bz" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3"> </td>        
                    <td class="auto-style3"> </td>             
                </tr>
            </table>     
            <p class="auto-style5">
                <asp:Button ID="Button3" text="提交" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p>        
        </div>

        <div>
            <p>应付款增加</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*编号<asp:TextBox ID="fykzj_bh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>  <%--FY+日期+序号--%>
                    <td class="auto-style3">日期<asp:TextBox ID="fykzj_rq" runat="server" Height="25px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">公司名称<asp:TextBox id="fykzj_gsmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">往来单位<asp:TextBox id="fykzj_wldw" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">费用名称<asp:TextBox id="fykzj_fymc" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3">增加金额<asp:TextBox id="fykzj_zjje" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td> 
                </tr>
                <tr>
                   
                    <td class="auto-style3">备注<asp:TextBox id="fykzj_bz" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3"> </td>        
                    <td class="auto-style3"> </td>             
                </tr>
            </table>     
            <p class="auto-style5">
                <asp:Button ID="Button4" text="提交" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p>        
        </div>


        <div>
            <p>应付款减少</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*编号<asp:TextBox ID="yfkjs_bh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>  <%--FY+日期+序号--%>
                    <td class="auto-style3">日期<asp:TextBox ID="yfkjs_rq" runat="server" Height="25px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">公司名称<asp:TextBox id="yfkjs_gsmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">往来单位<asp:TextBox id="yfkjs_wldw" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">收入名称<asp:TextBox id="yfkjs_srmc" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3">减少金额<asp:TextBox id="yfkjs_jsje" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td> 
                </tr>
                <tr>
                   
                    <td class="auto-style3">备注<asp:TextBox id="yfkjs_bz" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3"> </td>        
                    <td class="auto-style3"> </td>             
                </tr>
            </table>     
            <p class="auto-style5">
                <asp:Button ID="Button5" text="提交" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p>        
        </div>
        
        </div>
    </form>
</body>
</html>
