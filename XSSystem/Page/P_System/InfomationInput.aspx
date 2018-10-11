<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InfomationInput.aspx.cs" Inherits="XSSystem.Page.P_System.InfomationInput" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <p>新增煤种<asp:TextBox runat="server" ID="MZ" ></asp:TextBox><asp:Button runat="server" text="新增" ID="submit1" OnClick="submit1_Click"/></p>
            <p>新增原料<asp:TextBox runat="server" ID="YL" ></asp:TextBox><asp:Button runat="server" text="新增" ID="submit2" OnClick="submit2_Click"/></p>
            <p>新增产品<asp:TextBox runat="server" ID="CP" ></asp:TextBox><asp:Button runat="server" text="新增" ID="submit3" OnClick="submit3_Click"/></p>

        </div>
    </form>
</body>
</html>
