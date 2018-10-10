<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZlhtZjxx.aspx.cs" Inherits="XSSystem.Page.P_HTGL.ZlhtZjxx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <base target="_parent" />
    <script src="../../My97DatePicker/WdatePicker.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="1" aria-haspopup="False" class="xs_table" style="width: 400px"  >
            <tr><td class="auto-style3"><asp:TextBox ID="htbh" runat="server" Height="16px" Width="284px" Visible="false"></asp:TextBox></td></tr>
                <tr>
                         <td class="auto-style3">起始日期<asp:TextBox ID="qsrq" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox></td></tr>
                  <tr>   <td class="auto-style3">终止日期<asp:TextBox ID="zzrq" runat="server" Text="" onClick="WdatePicker()" Width="284px"></asp:TextBox> </td> </tr>
                   <tr>  <td class="auto-style3">租金<asp:TextBox id="zj" runat="server" height="25px" Width ="284px"></asp:TextBox> </td>
                </tr>
            <tr>
                         <td class="auto-style3">付款条款<asp:TextBox ID="fktk" runat="server" Height="16px" Width="284px"></asp:TextBox></td> </tr>
                 <tr>    <td class="auto-style3">执行状态<asp:TextBox id="zxzt" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
              <tr>       <td class="auto-style3">备注<asp:TextBox id="bz" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>

                   
            </table>   
         <p class="auto-style5">
                <asp:Button ID="submit" text="新增" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>
            </p>     
    </div>
    </form>
</body>
</html>
