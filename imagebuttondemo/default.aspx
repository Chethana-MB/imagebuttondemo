<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="imagebuttondemo._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/paint.png" OnClick="ImageButton1_Click" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 245px; width: 873px" />
    </form>
</body>
</html>
