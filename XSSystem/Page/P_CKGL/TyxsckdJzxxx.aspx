<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TyxsckdJzxxx.aspx.cs" Inherits="XSSystem.Page.P_CKGL.TyxsckdJzxxx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <base target="_parent"/>
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
    text-align: center;
    border-style: dotted;
    border-color:#00ffff;
        }
        .auto-style3 {
            height: 30px;
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
    <div>
        <table border="1" aria-haspopup="False" class="xs_table" style="width: 400px"  >
            <tr><td class="auto-style3"><asp:TextBox ID="htbh" runat="server" Height="16px" Width="284px" Visible="false"></asp:TextBox></td></tr>
            <tr><td class="auto-style3"><asp:TextBox ID="bh" runat="server" Height="16px" Width="284px" Visible="false"></asp:TextBox></td></tr>
                <tr>
                         <td class="auto-style3">箱号<asp:TextBox ID="xhao" runat="server" Height="16px" Width="284px"></asp:TextBox></td></tr>
                  <tr>   <td class="auto-style3">上箱吨数<asp:TextBox id="sxds" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
                   <tr>  <td class="auto-style3">装箱日期<asp:TextBox id="zxrq" runat="server" height="25px" Text="" onClick="WdatePicker()" Width ="284px"></asp:TextBox> </td>
                </tr>
            <tr>
                         <td class="auto-style3">发车日期<asp:TextBox ID="fcrq" runat="server" Height="16px" Text="" onClick="WdatePicker()"  Width="284px"></asp:TextBox></td> </tr>
                 <tr>    <td class="auto-style3">卸载吨数<asp:TextBox id="xhds" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
              <tr>       <td class="auto-style3">到站日期<asp:TextBox id="dzrq" runat="server" height="25px" Text="" onClick="WdatePicker()" Width ="284px"></asp:TextBox> </td> </tr>

            <tr>
                         <td class="auto-style3">结算货款<asp:TextBox ID="jshk" runat="server" Height="16px" Width="284px"></asp:TextBox></td></tr>
               <tr>      <td class="auto-style3">自备箱使费(元/组)<asp:TextBox id="zbxsf" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
              <tr>       <td class="auto-style3">发站代理费(元/组)<asp:TextBox id="fzdlf" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
            <tr>       <td class="auto-style3">发站装箱费(元/吨)<asp:TextBox id="fzzxf" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
            <tr>       <td class="auto-style3">发站倒短(元/吨)<asp:TextBox id="fzddf" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
            <tr>       <td class="auto-style3">铁路运费(元/组)<asp:TextBox id="tlyf" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
            <tr>       <td class="auto-style3">到站装卸费(元/组)<asp:TextBox id="dzzxf" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
            <tr>       <td class="auto-style3">到站-煤场倒短费(元/组)<asp:TextBox id="dzmcddf" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
            <tr>       <td class="auto-style3">到站代理费(元/吨)<asp:TextBox id="dzdlf" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
            <tr>       <td class="auto-style3">铁路运费小计<asp:TextBox id="tlyfxj" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
            </table>
         <p class="auto-style5">
                <asp:Button ID="submit" text="新增" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>
            </p>          
    </div>
    </form>
</body>
</html>
