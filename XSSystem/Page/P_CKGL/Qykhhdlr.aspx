<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Qykhhdlr.aspx.cs" Inherits="XSSystem.Page.P_Order.Qykhhdlr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>汽运客户回单录入</title>
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
    <div> <p class="auto-style5">汽运客户回单录入</p>        
         <div>
            <p>入库信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*入库磅单号<asp:TextBox ID="rkbdh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">入库时间
                        <asp:TextBox ID="rksj" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">入库毛重<asp:TextBox id="rkmz" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox> </td>
                    <td class="auto-style3">入库皮重<asp:TextBox id="rkpz" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox> </td>
                    <td class="auto-style3">入库净重<asp:TextBox id="rkjz" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox> </td> 
                </tr>
                <tr>
                    <td class="auto-style3">亏损吨数<asp:TextBox id="ksds" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox> </td>
                    <td class="auto-style3">盈余吨数<asp:TextBox id="yyds" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox></td>
                    <td class="auto-style3">扣吨(扣杂)<asp:TextBox id="kd" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox></td> 
                </tr>
                <tr>
                    <td class="auto-style3">运费合理路耗(吨)<asp:TextBox id="yfhllh" runat="server" Height="16px" Width ="254px" OnKeyPress="isnum()"></asp:TextBox></td> 
                    <td class="auto-style3">运费扣款标准(元/吨)<asp:TextBox id="yflhbz" runat="server" Height="16px" Width ="233px" OnKeyPress="isnum()"></asp:TextBox> </td>
                    <td class="auto-style3">运费扣亏吨数<asp:TextBox id="yfkkds" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox></td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">运费扣款金额<asp:TextBox id="yfkkje" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox> </td>
                    <td class="auto-style3">运费结算吨位<asp:TextBox id="yfjsdw" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox> </td>
                    <td class="auto-style3">应付运费<asp:TextBox id="yfyf" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox>  </td> 
                </tr>
                <tr>
                    <td class="auto-style3">费用扣款(手续费、卸车费)<asp:TextBox id="fykk" runat="server" Height="16px" Width ="188px" OnKeyPress="isnum()"></asp:TextBox></td> 
                    <td class="auto-style3">结算运费<asp:TextBox id="jsyf" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox> </td>
                    <td class="auto-style3">货款结算吨位<asp:TextBox id="hkjsdw" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox></td>
                    
                </tr>

                <tr>
                    <td class="auto-style3">结算货款<asp:TextBox id="jshk" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox></td> 
                    <td class="auto-style3">提成标准<asp:TextBox id="tcbz" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox> </td>
                    <td class="auto-style3">提成金额<asp:TextBox id="tcje" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()"></asp:TextBox></td>
                    
                </tr>

                <tr>
                    <td class="auto-style3">业务员<asp:TextBox id="ywy" runat="server" Height="16px" Width ="284px"></asp:TextBox></td> 
                    <td class="auto-style3">运费结算状态<asp:TextBox id="yfjszt" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">审核状态<asp:TextBox id="shzt" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    
                </tr>

            </table>            
        </div>


        <p class="auto-style5">
                <asp:Button ID="submit" text="保存" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp
                &nbsp
            <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>
