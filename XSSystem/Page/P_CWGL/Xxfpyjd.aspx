<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Xxfpyjd.aspx.cs" Inherits="XSSystem.Page.P_CWGL.Xxfpyjd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>销项发票邮寄单</title>
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
            width:400px;
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
    <div> <p class="auto-style5">销项发票邮寄单</p>        
         <div>
            <p>基本信息</p>
            <table border="1" aria-haspopup="False" class="auto-style1" style="width: 1200px" >
                <tr>
                    <td class="auto-style3">*单号<asp:TextBox ID="dh" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                    <td class="auto-style3">录单日期
                        <asp:TextBox ID="ldrq" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">合同号<asp:TextBox ID="hth" runat="server" Height="16px" Width="284px"></asp:TextBox></td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">供方名称<asp:TextBox id="gfmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">需方名称<asp:TextBox id="xfmc" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">开票日期<asp:TextBox ID="kprq" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox> </td> 
                </tr>
                <tr>
                    <td class="auto-style3">票号<asp:TextBox id="ph" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">品名<asp:TextBox id="pm" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style3">数量<asp:TextBox id="shuliang" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td> 
                </tr>
                <tr>
                    <td class="auto-style3">单价(含税)<asp:TextBox id="dj_hs" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td> 
                    <td class="auto-style3">金额<asp:TextBox id="je" runat="server" Height="16px" Width ="285px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">税率<asp:TextBox id="sl" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox></td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">税额<asp:TextBox id="se" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">税价合计<asp:TextBox id="sjhj" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox> </td>
                    <td class="auto-style3">印花税<asp:TextBox id="yhs" runat="server" Height="16px" Width ="284px" OnKeyPress="isnum()" OnKeyUp="value=value.replace(/[^\d.]/g,'')"></asp:TextBox>  </td> 
                </tr>
                <tr>
                    <td class="auto-style3">快递单号<asp:TextBox id="kddh" runat="server" Height="16px" Width ="284px"></asp:TextBox> </td>
                    <td class="auto-style3">备注<asp:TextBox id="bz" runat="server" Height="16px" Width ="284px"></asp:TextBox></td>
                    <td class="auto-style4">
                        <asp:CheckBox ID="sqzt" runat="server" TextAlign="Left" Text="是否收取" />
                    </td>
                </tr>

            </table>            
        </div>


        <p class="auto-style5">
                <asp:Button ID="submit" text="保存并关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>&nbsp
                &nbsp
            <asp:Button ID="close" text="关闭" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua"></asp:Button>
                </p> 
        </div>
    </form>
</body>
</html>

