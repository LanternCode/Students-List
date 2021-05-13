<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>StudentsList</title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 23px;
            top: 27px;
            position: absolute;
            width: 268px;
            height: 163px;
        }
        .auto-style2 {
            z-index: 1;
            left: 97px;
            top: 233px;
            position: absolute;
        }
        .auto-style3 {
            z-index: 1;
            left: 39px;
            top: 199px;
            position: absolute;
        }
        .auto-style4 {
            z-index: 1;
            left: 55px;
            top: 269px;
            position: absolute;
            right: 1403px;
        }
        .auto-style6 {
            z-index: 1;
            left: 173px;
            top: 270px;
            position: absolute;
        }
        .auto-style7 {
            z-index: 1;
            left: 29px;
            top: 320px;
            position: absolute;
            width: 100px;
        }
        .auto-style8 {
            z-index: 1;
            left: 137px;
            top: 320px;
            position: absolute;
            width: 150px;
        }
        .auto-style9 {
            z-index: 1;
            left: 29px;
            top: 351px;
            position: absolute;
            width: 257px;
        }
        .newStyle1 {
            padding: 10px;
        }
        .auto-style10 {
            height: 632px;
        }
        .auto-style11 {
            position: absolute;
            top: 384px;
            left: 29px;
            width: 258px;
            height: 23px;
        }
        .auto-style12 {
            position: absolute;
            top: 118px;
            left: 368px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style10">
        <div>
        </div>
        <asp:Button ID="btnTutors" runat="server" Text="Tutors -&gt;" CssClass="auto-style11" OnClick="btnTutors_Click1" />
        <asp:Button ID="btnApply" runat="server" Text="Apply filter" CssClass="auto-style4" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" CssClass="auto-style6" OnClick="btnDisplayAll_Click" />
        <asp:Label ID="lblModuleName" runat="server" style="margin-top: 0px; margin-bottom: 0px" Text="Filter by course name:" CssClass="auto-style3"></asp:Label>
        <asp:TextBox ID="txtCourseName" runat="server" CssClass="auto-style2" placeholder="Ex. Computing"></asp:TextBox>
        <asp:ListBox ID="lstStudents" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Button ID="btnDelete" runat="server" Text="Remove student from the list" OnClick="btnDelete_Click" CssClass="auto-style9" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit student data" CssClass="auto-style8" OnClick="btnEdit_Click" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add student" CssClass="auto-style7" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style12" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
