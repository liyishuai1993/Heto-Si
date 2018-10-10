<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Qyxsckd.aspx.cs" Inherits="XSSystem.Page.P_Order.Qyxsckd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>汽运销售出库单</title>
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
    <div> <p class="auto-style5">汽运销售出库单</p>
        <div>
            <p>出库信息(出库单)</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">出库磅单号<asp:TextBox ID="ckbdh" runat="server" Height="16px" Width="500px"></asp:TextBox></td>
                    <td class="auto-style3">合同编号<asp:TextBox id="htbh" runat="server" Height="16px" Width ="500px"></asp:TextBox> </td>                                    
                </tr>
                <tr>
                    <td class="auto-style3">装车时间<asp:TextBox id="zcsj" runat="server" Text="" onClick="WdatePicker()" Width="500px"></asp:TextBox> </td>
                    <td class="auto-style3">发煤煤场<asp:TextBox id="fmmc" runat="server" Height="16px" Width ="500px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">供方<asp:TextBox id="gf" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">需方<asp:TextBox id="xf" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">车号<asp:TextBox id="ch" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">驾驶员<asp:TextBox id="jsy" runat="server" Height="16px" Width ="500px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">联系电话<asp:TextBox id="lxdh" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">物料名称<asp:TextBox id="wlmc" runat="server" Height="16px" Width ="500px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">出库毛重<asp:TextBox id="ckmz" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">出库皮重<asp:TextBox id="ckpz" runat="server" Height="16px" Width ="500px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">加磅吨数<asp:TextBox id="jbds" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">出库净重1<asp:TextBox id="ckjz1" runat="server" Height="16px" Width ="500px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">出库净重2<asp:TextBox id="ckjz2" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">煤价<asp:TextBox id="mj" runat="server" Height="16px" Width ="500px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">货款估算金额<asp:TextBox id="hkgsje" runat="server" Height="16px" Width ="482px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">已付油卡<asp:TextBox id="yfyk" runat="server" Height="16px" Width ="500px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">运价<asp:TextBox id="yj" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox></td>
                    <td class="auto-style3">付卡账户<asp:TextBox id="fkzh" runat="server" Height="16px" Width ="500px" CssClass="auto-style4"></asp:TextBox> </td>
                    
                </tr>

            </table>     
        </div>
        
        <div>
            <p>入库信息(客户回单)</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*入库磅单号<asp:TextBox ID="rkbdh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">入库时间
                        <asp:TextBox ID="rksj" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>                
                </tr>
                <tr>
                    <td class="auto-style3">入库毛重<asp:TextBox id="rkmz" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">入库皮重<asp:TextBox id="rkpz" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">入库净重<asp:TextBox id="rkjz" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td class="auto-style3">亏损吨数<asp:TextBox id="ksds" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">盈余吨数<asp:TextBox id="yyds" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3">扣吨(扣杂)<asp:TextBox id="kd" runat="server" Height="16px" Width ="284px"></asp:TextBox></td> 
                </tr>
                <tr>
                    <td class="auto-style3">运费合理路耗(吨)<asp:TextBox id="yfhllh" runat="server" Height="16px" Width ="254px"></asp:TextBox></td> 
                    <td class="auto-style3">运费扣款标准(元/吨)<asp:TextBox id="yflhbz" runat="server" Height="16px" Width ="233px"></asp:TextBox> </td>
                    <td class="auto-style3">运费扣亏吨数<asp:TextBox id="yfkkds" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">运费扣款金额<asp:TextBox id="yfkkje" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">运费结算吨位<asp:TextBox id="yfjsdw" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">应付运费<asp:TextBox id="yfyf" runat="server" Height="16px" Width ="284px"></asp:TextBox>  </td> 
                </tr>
                <tr>
                    <td class="auto-style3">费用扣款(手续费、卸车费)<asp:TextBox id="fykk" runat="server" Height="16px" Width ="188px"></asp:TextBox></td> 
                    <td class="auto-style3">结算运费<asp:TextBox id="jsyf" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">货款结算吨位<asp:TextBox id="hkjsdw" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    
                </tr>

                <tr>
                    <td class="auto-style3">结算货款<asp:TextBox id="jshk" runat="server" Height="16px" Width ="284px"></asp:TextBox></td> 
                    <td class="auto-style3">提成标准<asp:TextBox id="tcbz" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">提成金额<asp:TextBox id="tcje" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    
                </tr>

                <tr>
                    <td class="auto-style3">业务员<asp:TextBox id="ywy" runat="server" Height="16px" Width ="284px"></asp:TextBox></td> 
                    <td class="auto-style3">运费结算状态<asp:TextBox id="yfjszt" runat="server" Height="16px" Width ="284px" CssClass="auto-style4"></asp:TextBox> </td>
                    <td class="auto-style3">审核状态<asp:TextBox id="shzt" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    
                </tr>

            </table>            
        </div>


        <p class="auto-style5">
                <asp:Button ID="submit" text="保存出库单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp
            <asp:Button ID="submit2" text="保存回单" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit2_Click"></asp:Button>&nbsp
            <asp:Button ID="Button1" text="重填" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" ></asp:Button>&nbsp
                <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>
