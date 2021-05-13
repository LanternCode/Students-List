<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddStudent.aspx.cs" Inherits="AddStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 599px;
        }
        .auto-style2 {
            z-index: 1;
            left: 221px;
            top: 153px;
            position: absolute;
        }
        .auto-style3 {
            z-index: 1;
            left: 45px;
            top: 207px;
            position: absolute;
            height: 22px;
        }
        .auto-style4 {
            z-index: 1;
            left: 218px;
            top: 210px;
            position: absolute;
        }
        .auto-style5 {
            z-index: 1;
            left: 125px;
            top: 264px;
            position: absolute;
            width: 258px;
        }
        .auto-style8 {
            z-index: 1;
            left: 43px;
            top: 305px;
            position: absolute;
        }
        .auto-style9 {
            z-index: 1;
            left: 287px;
            top: 304px;
            position: absolute;
        }
        .auto-style10 {
            z-index: 1;
            left: 28px;
            top: 352px;
            position: absolute;
        }
        .auto-style11 {
            z-index: 1;
            left: 298px;
            top: 352px;
            position: absolute;
        }
        .auto-style13 {
            z-index: 1;
            left: 56px;
            top: 500px;
            position: absolute;
            margin-top: 0px;
        }
        .auto-style14 {
            z-index: 1;
            left: 242px;
            top: 501px;
            position: absolute;
            margin-top: 0px;
        }
        .auto-style27 {
            z-index: 1;
            left: 270px;
            top: 410px;
            position: absolute;
            margin-top: 0px;
            width: 119px;
        }
        .auto-style28 {
            z-index: 1;
            left: 57px;
            top: 407px;
            position: absolute;
            margin-top: 0px;
            width: 158px;
        }
        .auto-style29 {
            z-index: 1;
            left: 535px;
            top: 141px;
            position: absolute;
            margin-top: 0px;
            width: 639px;
        }
        .auto-style30 {
            z-index: 1;
            left: 58px;
            top: 99px;
            position: absolute;
        }
        .auto-style31 {
            z-index: 1;
            left: 220px;
            top: 99px;
            position: absolute;
        }
        .auto-style32 {
            z-index: 1;
            left: 62px;
            top: 151px;
            position: absolute;
        }
        .auto-style33 {
            position: absolute;
            top: 453px;
            left: 137px;
            z-index: 1;
        }
        .auto-style34 {
            position: absolute;
            top: 450px;
            left: 245px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
        </div>
        <asp:TextBox ID="txtStudentNames" runat="server" CssClass="auto-style2" TabIndex="2"></asp:TextBox>
        <asp:Label ID="lblStudentNames" runat="server" Text="Student's full name:" CssClass="auto-style32"></asp:Label>
        <asp:TextBox ID="txtStudentPNumber" runat="server" TabIndex="1" CssClass="auto-style31"></asp:TextBox>
        <asp:CheckBox ID="chkStudentExpelled" runat="server" CssClass="auto-style5" Text=" Student was expelled" TabIndex="4" />
        <asp:DropDownList ID="ddlStudentCourse" runat="server" CssClass="auto-style9" TabIndex="5">
        </asp:DropDownList>
        <asp:Label ID="lblStudentID" runat="server" Text="Student's P-number:" CssClass="auto-style30"></asp:Label>
        <p>
            <asp:Label ID="lblStudentCourse" runat="server" Text="Course attended by the student:" CssClass="auto-style8"></asp:Label>
        </p>
        <asp:TextBox ID="txtStudentDate" runat="server" CssClass="auto-style4" TabIndex="3"></asp:TextBox>
        <asp:Label ID="lblStudentDate" runat="server" Text="Original addition date:" CssClass="auto-style3"></asp:Label>
        <asp:TextBox ID="txtStudentAttendancePercentage" runat="server" CssClass="auto-style11" TabIndex="6"></asp:TextBox>
        <asp:Button ID="btnStudentConfirm" runat="server" Text="Confirm changes" CssClass="auto-style13" OnClick="btnStudentConfirm_Click" TabIndex="8" />
        <asp:Button ID="btnStudentCancel" runat="server" OnClick="btnStudentCancel_Click" Text="Cancel and go back" CssClass="auto-style14" />
        <asp:Label ID="lblStudentCompletion" runat="server" Text="Student's attendance percentage (in %):" CssClass="auto-style10"></asp:Label>
        <asp:Label ID="lblStartingYear" runat="server" Text="Student starting year:" CssClass="auto-style28"></asp:Label>
        <asp:TextBox ID="txtStartingYear" runat="server" CssClass="auto-style27" TabIndex="7"></asp:TextBox>
        <asp:TextBox ID="lblError" runat="server" style="margin-bottom: 0px; height: 132px;" CssClass="auto-style29" TextMode="MultiLine" Font-Bold="True" ForeColor="Red" Visible="False"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style33" Text="Tutor:"></asp:Label>
        <asp:DropDownList ID="ddlStudentTutor" runat="server" CssClass="auto-style34">
        </asp:DropDownList>
    </form>
</body>
</html>
