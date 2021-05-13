<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RemoveTutor.aspx.cs" Inherits="RemoveTutor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 231px;
            top: 146px;
            position: absolute;
        }
        .auto-style2 {
            z-index: 1;
            left: 32px;
            top: 187px;
            position: absolute;
        }
        .auto-style3 {
            height: 607px;
        }
        .auto-style4 {
            z-index: 1;
            left: 65px;
            top: 245px;
            position: absolute;
            margin-bottom: 6px;
        }
        .auto-style5 {
            z-index: 1;
            left: 338px;
            top: 245px;
            position: absolute;
            margin-bottom: 0px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style3">
        <p>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style1" ForeColor="Red"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblDeleteWarning" runat="server" Text="This action is irreversible! Are you sure that you want to remove this tutor?" CssClass="auto-style2" Font-Bold="True"></asp:Label>
        <asp:Button ID="btnRemoveReject" runat="server" Text="&lt;- No, cancel" OnClick="btnRemoveReject_Click" CssClass="auto-style4" />
        <asp:Button ID="btnRemoveConfirm" runat="server" OnClick="btnRemoveConfirm_Click" Text="Yes, proceed." CssClass="auto-style5" />
        </p>
    </form>
</body>
</html>
