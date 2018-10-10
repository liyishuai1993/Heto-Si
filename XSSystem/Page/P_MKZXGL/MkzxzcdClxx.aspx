<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MkzxzcdClxx.aspx.cs" Inherits="XSSystem.Page.P_MKZXGL.MkzxzcdClxx" %>

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
           <tr><td class="auto-style3"><asp:TextBox ID="djbh" runat="server" Height="16px" Width="284px" Visible="false"></asp:TextBox></td></tr>
           <%--<tr><td class="auto-style3"><asp:TextBox ID="bh" runat="server" Height="16px" Width="284px" Visible="false"></asp:TextBox></td></tr>--%>
                <tr>
                         <td class="auto-style3">磅单号<asp:TextBox ID="bdh" runat="server" Height="16px" Width="284px"></asp:TextBox></td></tr>
                  <tr>   <td class="auto-style3">提货单号<asp:TextBox id="thdh" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
                   <tr>  <td class="auto-style3">车号<asp:TextBox id="ch" runat="server" height="25px"  Width ="284px"></asp:TextBox> </td>
                </tr>
            <tr>
                         <td class="auto-style3">装车毛重<asp:TextBox ID="zcmz" runat="server" Height="16px" Width="284px"></asp:TextBox></td> </tr>
                 <tr>    <td class="auto-style3">装车皮重<asp:TextBox id="zcpz" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
              <tr>       <td class="auto-style3">装车净重<asp:TextBox id="zcjz" runat="server" height="25px" Text="" Width ="284px"></asp:TextBox> </td> </tr>

            <tr>
                         <td class="auto-style3">应付运费<asp:TextBox ID="yfyf" runat="server" Height="16px" Width="284px"></asp:TextBox></td></tr>
               <tr>      <td class="auto-style3">采购结算金额<asp:TextBox id="cgjsje" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
              <tr>       <td class="auto-style3">销售结算金额<asp:TextBox id="xsjsje" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
            <tr>       <td class="auto-style3">备注<asp:TextBox id="bz" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
            <tr>       <td class="auto-style3">状态<asp:TextBox id="zt" runat="server" height="25px" Width ="284px"></asp:TextBox> </td> </tr>
            </table>
         <p class="auto-style5">
                <asp:Button ID="submit" text="新增" runat ="server" width="90px"  BorderStyle="Groove" BackColor="Aqua" OnClick="submit_Click"></asp:Button>
            </p>          
    </div>
    </form>
</body>
</html>
