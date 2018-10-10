<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CghtZlbz.aspx.cs" Inherits="XSSystem.Page.P_HTGL.CghtZlbz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <base target="_parent"/>
    <script type="text/css">
        .auto-style3 {
            height: 30px;
            width:100px;
            text-align:right;
            }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1" aria-haspopup="False" class="xs_table" style="width: 400px"  >
            <tr><td class="auto-style3" ><asp:TextBox ID="htbh" Visible="false" runat="server" Height="16px" Width="284px"></asp:TextBox></td></tr>
                <tr>
                         <td class="auto-style3">煤种<asp:TextBox ID="mz" runat="server" Height="16px" Width="90px"></asp:TextBox></td>
                     <td class="auto-style3">粒度<asp:TextBox id="ld" runat="server" height="25px" Width ="90px"></asp:TextBox> </td> 
                    <td class="auto-style3">灰分<asp:TextBox id="hf" runat="server" height="25px" Width ="90px"></asp:TextBox> </td>
                </tr>
            <tr>
                         <td class="auto-style3">挥发分<asp:TextBox ID="hff" runat="server" Height="16px" Width="90px"></asp:TextBox></td> 
                    <td class="auto-style3">固定碳<asp:TextBox id="gdt" runat="server" height="25px" Width ="90px"></asp:TextBox> </td> 
                    <td class="auto-style3">粘结指数<asp:TextBox id="njzs" runat="server" height="25px" Width ="90px"></asp:TextBox> </td> </tr>

            <tr>
                         <td class="auto-style3">水分<asp:TextBox ID="sf" runat="server" Height="16px" Width="90px"></asp:TextBox></td>
                     <td class="auto-style3">铁<asp:TextBox id="tie" runat="server" height="25px" Width ="90px"></asp:TextBox> </td> 
                     <td class="auto-style3">铝<asp:TextBox id="lv" runat="server" height="25px" Width ="90px"></asp:TextBox> </td> </tr>

            <tr>
                         <td class="auto-style3">钙<asp:TextBox ID="gai" runat="server" Height="16px" Width="90px"></asp:TextBox></td>
                     <td class="auto-style3">磷<asp:TextBox id="lin" runat="server" height="25px" Width ="90px"></asp:TextBox> </td> 
                    <td class="auto-style3">钛<asp:TextBox id="tai" runat="server" height="25px" Width ="90px"></asp:TextBox> </td>
                </tr>
            <tr>
                         <td class="auto-style3">硫<asp:TextBox ID="liu" runat="server" Height="16px" Width="90px"></asp:TextBox></td>
                     <td class="auto-style3"> </td> 
                    <td class="auto-style3"> </td>
                </tr>

            </table>   
         <p class="auto-style5">
                <asp:Button ID="submit" text="新增" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>
            </p>          
    </div>
    </form>
</body>
</html>
