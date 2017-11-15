<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Qyzxhdlr.aspx.cs" Inherits="XSSystem.Page.P_Order.Qyzxhdlr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>汽运直销回单录入</title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
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
    <div> <p class="auto-style5">汽运直销回单录入</p>
        <div>
            <p>出库信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px">
                <tr>
                    <td class="auto-style3">出库磅单号<asp:TextBox ID="ckbdh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">装车时间
                        <asp:TextBox ID="zcsj" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">批次号<asp:TextBox id="pch" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    

                </tr>
                <tr>
                    <td class="auto-style3">供方名称<asp:TextBox id="gfmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">收货方名称<asp:TextBox id="shfmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">
                        业务员<asp:TextBox id="ywy" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">物料名称<asp:TextBox id="wlmc" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">规格型号<asp:TextBox id="ggxh" runat="server" Height="16px" Width ="284px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">
                        承运单位<asp:TextBox id="cydw" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">车号<asp:TextBox id="ch" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">驾驶员<asp:TextBox id="jsy" runat="server" Height="16px" Width ="284px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">
                        联系方式<asp:TextBox id="lxfs" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">出库单编号<asp:TextBox id="ckdbh" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">提货单号<asp:TextBox id="thdh" runat="server" Height="16px" Width ="284px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">
                        运价<asp:TextBox id="yj" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">毛重<asp:TextBox id="mz" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">皮重<asp:TextBox id="pz" runat="server" Height="16px" Width ="284px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">
                        净重<asp:TextBox id="jz" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
            </table>            
        </div>

         <div>
            <p>入库信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*入库磅单号<asp:TextBox ID="rkbdh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">入库时间
                        <asp:TextBox ID="rksj" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">批次号<asp:TextBox id="pch2" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">入库毛重<asp:TextBox id="rkmz" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">入库皮重<asp:TextBox id="rkpz" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">
                        入库净重<asp:TextBox id="rkjz" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">亏损吨数<asp:TextBox id="ksds" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">盈余吨数<asp:TextBox id="yyds" runat="server" Height="16px" Width ="284px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">
                        扣吨<asp:TextBox id="kd" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">运费路耗标准<asp:TextBox id="yflhbz" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">运费路耗类型<asp:TextBox id="yflhlx" runat="server" Height="16px" Width ="284px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">
                        运费合理路耗<asp:TextBox id="yfhllh" runat="server" Height="16px" Width ="284px"></asp:TextBox>  
                   </td> 
                </tr>
                <tr>
                    <td class="auto-style3">扣款标准<asp:TextBox id="kkbz" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">扣亏数<asp:TextBox id="kks" runat="server" Height="16px" Width ="284px"></asp:TextBox> 
                    </td>
                    <td class="auto-style3">运费结算吨数<asp:TextBox id="yfjsds" runat="server" Height="16px" Width ="284px"></asp:TextBox>  </td> 
                </tr>
                <tr>
                    <td class="auto-style3">应付运费<asp:TextBox id="yfyf" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">扣款金额<asp:TextBox id="kkje" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3">结算运费<asp:TextBox id="jsyf" runat="server" Height="16px" Width ="284px"></asp:TextBox></td> 
                </tr>

                <tr>
                    <td class="auto-style3">货款路耗类型<asp:TextBox id="TextBox28" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">货款路耗标准<asp:TextBox id="TextBox29" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3">货款合理路耗<asp:TextBox id="TextBox30" runat="server" Height="16px" Width ="284px"></asp:TextBox></td> 
                </tr>

                <tr>
                    <td class="auto-style3">货款结算吨位<asp:TextBox id="TextBox31" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">结算货款<asp:TextBox id="TextBox32" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3"></td> 
                </tr>

                <tr>
                    <td class="auto-style3">验货员<asp:TextBox id="TextBox34" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">司磅员<asp:TextBox id="TextBox35" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3"></td> 
                </tr>

                <tr><td colspan="3">备注<asp:TextBox id="TextBox36" runat="server" Height="16px" Width ="1100px"></asp:TextBox></td></tr>
            </table>            
        </div>


        <p class="auto-style5">
                <asp:Button ID="submit" text="保存并关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>&nbsp
                &nbsp
            <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>
