﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XshtJgxx.aspx.cs" Inherits="XSSystem.Page.P_HTGL.XshtJgxx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <base target="_parent" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table border="1" aria-haspopup="False" class="xs_table" style="width: 400px"  >
            <tr><td class="auto-style3"><asp:TextBox ID="htbh" runat="server" Height="16px" Width="284px" Visible="false"></asp:TextBox></td></tr>
                <tr>
                         <td class="auto-style3">货款结算方式<asp:TextBox ID="mkmc" runat="server" Height="16px" Width="284px"></asp:TextBox></td></tr>
                  <tr>   <td class="auto-style3">煤种名称<asp:TextBox id="mzmc" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
                   <tr>  <td class="auto-style3">发热量<asp:TextBox id="frl" runat="server" height="25px" Width ="284px"></asp:TextBox> </td>
                </tr>
            <tr>
                         <td class="auto-style3">硫份<asp:TextBox ID="lf" runat="server" Height="16px" Width="284px"></asp:TextBox></td> </tr>
                 <tr>    <td class="auto-style3">开票煤价<asp:TextBox id="kpmj" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
              <tr>       <td class="auto-style3">合同煤价<asp:TextBox id="htmj" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>

            <tr>
                         <td class="auto-style3">扣损率<asp:TextBox ID="ksl" runat="server" Height="16px" Width="284px"></asp:TextBox></td></tr>
               <tr>      <td class="auto-style3">签订吨数<asp:TextBox id="qdds" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
              <tr>       <td class="auto-style3">签订金额<asp:TextBox id="qdje" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
            </table>   
         <p class="auto-style5">
                <asp:Button ID="submit" text="新增" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>
            </p>      
    </div>
    </form>
</body>
</html>
