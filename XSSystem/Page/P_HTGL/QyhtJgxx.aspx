<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QyhtJgxx.aspx.cs" Inherits="XSSystem.Page.P_HTGL.QyhtJgxx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
                <tr>
                         <td class="auto-style3">物料名称<asp:TextBox ID="wlmc" runat="server" Height="16px" Width="284px"></asp:TextBox></td></tr>
                  <tr>   <td class="auto-style3">起运地<asp:TextBox id="qyd" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
                   <tr>  <td class="auto-style3">目的地<asp:TextBox id="mdd" runat="server" height="25px" Width ="284px"></asp:TextBox> </td>
                </tr>
            <tr>
                         <td class="auto-style3">运价<asp:TextBox ID="yj" runat="server" Height="16px" Width="284px"></asp:TextBox></td> </tr>
                 <tr>    <td class="auto-style3">运费路耗标准<asp:TextBox id="yflhbz" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
              <tr>       <td class="auto-style3">备注<asp:TextBox id="bz" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>        
            </table>   
         <p class="auto-style5">
                <asp:Button ID="submit" text="新增" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>
            </p>    
    </div>
    </form>
</body>
</html>
