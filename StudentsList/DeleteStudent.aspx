<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStudent.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 607px;
        }
        .auto-style2 {
            z-index: 1;
            left: 282px;
            top: 331px;
            position: absolute;
        }
        .auto-style4 {
            z-index: 1;
            left: 545px;
            top: 332px;
            position: absolute;
        }
        .auto-style5 {
            z-index: 1;
            left: 270px;
            top: 245px;
            position: absolute;
        }
        .auto-style7 {
            z-index: 1;
            left: 306px;
            top: 194px;
            position: absolute;
        }
        .auto-style8 {
            position: absolute;
            top: 285px;
            left: 364px;
            z-index: 1;
        }
    </style>
</head>
<body style="height: 597px">
    <form id="form1" runat="server" class="auto-style1">
        <asp:Button ID="btnRemoveReject" runat="server" Text="No, return to homepage." OnClick="btnRemoveReject_Click" CssClass="auto-style2" />
        <asp:Button ID="btnRemoveConfirm" runat="server" OnClick="btnRemoveConfirm_Click" Text="Yes, proceed." CssClass="auto-style4" />
        <asp:Label ID="lblDeleteWarning" runat="server" Text="Are you sure you want to remove this student from the list?" CssClass="auto-style5"></asp:Label>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" CssClass="auto-style7"></asp:Label>
        <asp:Label ID="lblWarning" runat="server" CssClass="auto-style8" Font-Bold="True" Text="This action cannot be undone."></asp:Label>
    </form>
</body>
</html>
