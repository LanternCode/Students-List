<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tutor.aspx.cs" Inherits="Tutor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <style type="text/css">

        .auto-style1 {
            z-index: 1;
            left: 23px;
            top: 27px;
            position: absolute;
            width: 242px;
            height: 112px;
        }
        .auto-style3 {
            z-index: 1;
            left: 25px;
            top: 152px;
            position: absolute;
        }
        .auto-style4 {
            z-index: 1;
            left: 45px;
            top: 194px;
            position: absolute;
            right: 1160px;
        }
        .auto-style6 {
            z-index: 1;
            left: 165px;
            top: 194px;
            position: absolute;
        }
        .auto-style7 {
            z-index: 1;
            left: 292px;
            top: 36px;
            position: absolute;
            right: 840px;
            width: 122px;
            height: 55px;
        }
        .auto-style8 {
            z-index: 1;
            left: 294px;
            top: 112px;
            position: absolute;
            width: 123px;
            height: 63px;
            margin-top: 0px;
        }
        .auto-style9 {
            z-index: 1;
            left: 291px;
            top: 195px;
            position: absolute;
            width: 126px;
            height: 61px;
            margin-top: 0px;
        }
        .auto-style11 {
            position: absolute;
            top: 230px;
            left: 18px;
            width: 258px;
            height: 23px;
        }
        .auto-style92 {
            height: 722px;
        }
        .auto-style93 {
            position: absolute;
            top: 275px;
            left: 21px;
            z-index: 1;
        }
        .auto-style95 {
            position: absolute;
            top: 150px;
            left: 136px;
            width: 83px;
            z-index: 1;
        }
        </style>
</head>
<body>

    <form id="form1" runat="server" class="auto-style92">
        <asp:ListBox ID="lstTutors" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Label ID="lblFilterBy" runat="server" style="margin-top: 0px; margin-bottom: 0px; right: 1128px;" Text="Filter by Course:" CssClass="auto-style3"></asp:Label>&nbsp;
        <asp:Button ID="btnFilter" runat="server" Text="Apply Filter" CssClass="auto-style4" OnClick="btnFilter_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="auto-style8" OnClick="btnEdit_Click" />
        <asp:Button ID="btnAllTutors" runat="server" Text="All Tutors" CssClass="auto-style6" OnClick="btnAllTutors_Click" />
        <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="auto-style7" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete (!)" CssClass="auto-style9" BackColor="#FF3300" ForeColor="White" OnClick="btnDelete_Click" />
        <asp:Button ID="btnReturn" runat="server" Text="&lt;- Students" CssClass="auto-style11" OnClick="btnStudents_Click" />
        <asp:TextBox ID="txtFilterBy" runat="server" CssClass="auto-style95"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style93" ForeColor="Red"></asp:Label>
    </form>

</body>
</html>

