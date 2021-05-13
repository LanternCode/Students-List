using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
            DisplayStudents("");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //This line of code redirects the user to the delete confirmation page
        //after pressing the Delete button
        Int32 StudentNo;
        if (lstStudents.SelectedIndex != -1)
        {
            StudentNo = Convert.ToInt32(lstStudents.SelectedValue);
            Response.Redirect("DeleteStudent.aspx?StudentNo=" + StudentNo);
        }
        else
        {
            lblError.Text = "You must select the student off the list first to delete them.";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddStudent.aspx?StudentNo=-1");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StudentNo;
        if(lstStudents.SelectedIndex != -1)
        {
            StudentNo = Convert.ToInt32(lstStudents.SelectedValue);
            Response.Redirect("AddStudent.aspx?StudentNo=" + StudentNo);
        }
        else
        {
            lblError.Text = "You must select the student off the list first to edit them.";
        }
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        DisplayStudents("");
    }

    Int32 DisplayStudents(string CourseFilter)
    {
        Int32 StudentNo;
        string StudentPNumber;
        string StudentFullName;
        Int32 StudentCourseNo;

        clsStudentCollection StudentList = new clsStudentCollection();
        StudentList.ReportByCourse(CourseFilter);
        
        Int32 RecordCount;
        Int32 Index = 0;
        RecordCount = StudentList.Count;
        lstStudents.Items.Clear();

        while( Index < RecordCount )
        {
            StudentNo = StudentList.StudentList[Index].StudentNo;
            StudentPNumber = StudentList.StudentList[Index].StudentPNumber;
            StudentFullName = StudentList.StudentList[Index].StudentFullName;
            StudentCourseNo = StudentList.StudentList[Index].StudentCourseNo;

            ListItem NewEntry = new ListItem(StudentFullName + " " + StudentPNumber, StudentNo.ToString());
            lstStudents.Items.Add(NewEntry);
            Index++;
        }
        return RecordCount;
    }

    protected void btnTutors_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Tutor.aspx");
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        DisplayStudents(txtCourseName.Text);
    }
}