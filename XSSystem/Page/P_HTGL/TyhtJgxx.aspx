<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TyhtJgxx.aspx.cs" Inherits="XSSystem.Page.P_HTGL.TyhtJgxx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <base target="_parent" />
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEEEE;
    text-align: center;
    border-style: dotted;
    border-color:#00ffff;
        }
        .auto-style3 {
            height: 30px;
            width:100px;
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
                     <td class="auto-style3">公司名称<asp:TextBox ID="gsmc" runat="server" Height="25px" Width="90px"></asp:TextBox></td>
                     <td class="auto-style3">对方合同号<asp:TextBox id="dfhth" runat="server" height="25px" Width ="90px"></asp:TextBox> </td> 
                     <td class="auto-style3">开票类型<asp:TextBox id="kplx" runat="server" height="25px" Width ="90px"></asp:TextBox> </td>
                </tr>
        <tr>
                     <td class="auto-style3">自备箱使费<asp:TextBox ID="zbxsf" runat="server" Height="25px" Width="90px"></asp:TextBox></td>
                     <td class="auto-style3">代理费<asp:TextBox id="dlf" runat="server" height="25px" Width ="90px"></asp:TextBox> </td> 
                     <td class="auto-style3">装箱费<asp:TextBox id="zxf" runat="server" height="25px" Width ="90px"></asp:TextBox> </td>
                </tr>
        <tr>
                     <td class="auto-style3">始发站倒短<asp:TextBox ID="sfzdd" runat="server" Height="25px" Width="90px"></asp:TextBox></td>
                     <td class="auto-style3">铁路运费<asp:TextBox id="tlyf" runat="server" height="25px" Width ="90px"></asp:TextBox> </td> 
                     <td class="auto-style3">到站装卸费<asp:TextBox id="dzzxf" runat="server" height="25px" Width ="90px"></asp:TextBox> </td>
                </tr>
        <tr>
                     <td class="auto-style3">到站-煤场倒短费<asp:TextBox ID="dzmcddf" runat="server" Height="25px" Width="90px"></asp:TextBox></td>
                     <td class="auto-style3">到站代理费<asp:TextBox id="dzdlf" runat="server" height="25px" Width ="90px"></asp:TextBox> </td> 
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
