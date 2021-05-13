<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddTutor.aspx.cs" Inherits="AddTutor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            position: absolute;
            top: 140px;
            left: 128px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 178px;
            left: 128px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 219px;
            left: 102px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 259px;
            left: 117px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 305px;
            left: 93px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 366px;
            left: 167px;
            z-index: 1;
        }
        .auto-style8 {
            height: 619px;
        }
        .auto-style10 {
            position: absolute;
            top: 138px;
            left: 270px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 180px;
            left: 267px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 219px;
            left: 268px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 257px;
            left: 266px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 306px;
            left: 266px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 420px;
            left: 241px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 419px;
            left: 78px;
            z-index: 1;
        }
        .auto-style17 {
            position: absolute;
            top: 133px;
            left: 483px;
            z-index: 1;
            width: 699px;
            height: 118px;
        }
    </style>
</head>
<body style="height: 602px">
    <form id="form1" runat="server" class="auto-style8" visible="True">
        <div>
        </div>
        <asp:Label ID="lblTutorName" runat="server" CssClass="auto-style2" Text="Tutor's first name:"></asp:Label>
        <asp:Label ID="lblTutorSurname" runat="server" CssClass="auto-style3" Text="Tutor's last name:"></asp:Label>
        <asp:Label ID="lblTutorCertificates" runat="server" CssClass="auto-style6" Text="Tutor's certificate count:"></asp:Label>
        <asp:Label ID="lblTutorCourse" runat="server" CssClass="auto-style4" Text="Tutor's teaching course:"></asp:Label>
        <asp:Label ID="lblTutorRegisteredOn" runat="server" CssClass="auto-style5" Text="Tutor registered on:"></asp:Label>
        <asp:CheckBox ID="chkTutorEligible" runat="server" CssClass="auto-style7" Text="Tutor currently unavailable" />
        <asp:TextBox ID="txtTutorFirstName" runat="server" CssClass="auto-style10"></asp:TextBox>
        <asp:TextBox ID="txtTutorLastName" runat="server" CssClass="auto-style11"></asp:TextBox>
        <asp:DropDownList ID="ddlTutorTeachingCourse" runat="server" CssClass="auto-style12">
        </asp:DropDownList>
        <asp:TextBox ID="txtTutorRegisteredOn" runat="server" CssClass="auto-style13"></asp:TextBox>
        <asp:TextBox ID="txtTutorCertificateCount" runat="server" CssClass="auto-style14"></asp:TextBox>
        <asp:Button ID="btnSave" runat="server" CssClass="auto-style15" Text="Save and update" OnClick="btnSave_Click" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style16" OnClick="btnCancel_Click" Text="&lt;- Return" />
        <asp:TextBox ID="txtErrorMessage" runat="server" CssClass="auto-style17" Visible="False" ForeColor="Red" TextMode="MultiLine"></asp:TextBox>
    </form>
</body>
</html>
