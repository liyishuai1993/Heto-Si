<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WtjghtJgxx.aspx.cs" Inherits="XSSystem.Page.P_HTGL.WtjghtJgxx" %>

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
                     <td class="auto-style3">物料名称<asp:TextBox ID="wlmc" runat="server" Height="25px" Width="90px"></asp:TextBox></td></tr>
                   <tr>  <td class="auto-style3">加工费(元/吨)<asp:TextBox id="jgf" runat="server" height="25px" Width ="90px"></asp:TextBox> </td> </tr>
                   <tr>  <td class="auto-style3">出煤指标<asp:TextBox id="cmzb" runat="server" height="25px" Width ="90px"></asp:TextBox> </td>
                </tr>
        <tr>
                     <td class="auto-style3">备注<asp:TextBox ID="bz" runat="server" Height="25px" Width="90px"></asp:TextBox></td>
                     
                </tr>
                 
            </table>   
         <p class="auto-style5">
                <asp:Button ID="submit" text="新增" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>
            </p>    
    </div>
    </form>
</body>
</html>
