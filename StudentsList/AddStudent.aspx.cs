using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddStudent : System.Web.UI.Page
{

    //global variables
    Int32 StudentNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        StudentNo = Convert.ToInt32(Request.QueryString["StudentNo"]);

        if(IsPostBack != true)
        {
            DisplayCourses();
            DisplayTutors();

            if (StudentNo != -1)
                DisplayStudent(StudentNo);
        }
    }

    protected void btnStudentCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void btnStudentConfirm_Click(object sender, EventArgs e)
    {

        clsStudent ThisStudent = new clsStudent();
        string ErrorMsg;

        ErrorMsg = ThisStudent.StudentValid(txtStudentPNumber.Text, 
                                            txtStudentNames.Text, 
                                            txtStudentDate.Text, 
                                            txtStudentAttendancePercentage.Text, 
                                            txtStartingYear.Text);

        lblError.Visible = true;

        if(ErrorMsg == "")
        {
            clsStudentCollection NewStudent = new clsStudentCollection();
            if(StudentNo == -1)
            {
                NewStudent.ThisStudent.StudentPNumber = txtStudentPNumber.Text;
                NewStudent.ThisStudent.StudentFullName = txtStudentNames.Text;
                NewStudent.ThisStudent.StudentAdditionDate = Convert.ToDateTime(txtStudentDate.Text);
                NewStudent.ThisStudent.StudentAttendancePercentage = Convert.ToDecimal(txtStudentAttendancePercentage.Text);
                NewStudent.ThisStudent.StudentExpelled = chkStudentExpelled.Checked;
                NewStudent.ThisStudent.StudentStartingYear = Convert.ToInt32(txtStartingYear.Text);
                NewStudent.ThisStudent.StudentCourseNo = Convert.ToInt32(ddlStudentCourse.SelectedValue);
                NewStudent.ThisStudent.StudentTutorNo = Convert.ToInt32(ddlStudentTutor.SelectedValue);


                NewStudent.Add();
            }
            else
            {
                NewStudent.ThisStudent.StudentNo = StudentNo;
                NewStudent.ThisStudent.StudentPNumber = txtStudentPNumber.Text;
                NewStudent.ThisStudent.StudentFullName = txtStudentNames.Text;
                NewStudent.ThisStudent.StudentAdditionDate = Convert.ToDateTime(txtStudentDate.Text);
                NewStudent.ThisStudent.StudentAttendancePercentage = Convert.ToDecimal(txtStudentAttendancePercentage.Text);
                NewStudent.ThisStudent.StudentExpelled = chkStudentExpelled.Checked;
                NewStudent.ThisStudent.StudentStartingYear = Convert.ToInt32(txtStartingYear.Text);
                NewStudent.ThisStudent.StudentCourseNo = Convert.ToInt32(ddlStudentCourse.SelectedValue);
                NewStudent.ThisStudent.StudentTutorNo = Convert.ToInt32(ddlStudentTutor.SelectedValue);

                NewStudent.Update();
            }
            Response.Redirect("Default.aspx");
        }
        else
        {
            lblError.Text = ErrorMsg;
        }
        
    }

    void DisplayStudent(Int32 StudentNo)
    {
        clsStudent myStudent = new clsStudent();
        myStudent.Find(StudentNo);
        
        txtStudentPNumber.Text = myStudent.StudentPNumber;
        txtStudentNames.Text = myStudent.StudentFullName;
        txtStudentDate.Text = myStudent.StudentAdditionDate.ToString("dd/MM/yyyy");
        txtStartingYear.Text = Convert.ToString(myStudent.StudentStartingYear);
        txtStudentAttendancePercentage.Text = Convert.ToString(myStudent.StudentAttendancePercentage);
        chkStudentExpelled.Checked = myStudent.StudentExpelled;
        ddlStudentCourse.SelectedValue = Convert.ToString(myStudent.StudentCourseNo);
        ddlStudentTutor.SelectedValue = Convert.ToString(myStudent.StudentTutorNo);
    }

    Int32 DisplayCourses()
    {
        clsCourseCollection Courses = new clsCourseCollection();
        string CourseNo;
        string Course;
        Int32 Index = 0;
        while( Index < Courses.Count )
        {
            CourseNo = Convert.ToString(Courses.AllCourses[Index].CourseNo);
            Course = Courses.AllCourses[Index].CourseName;
            ListItem NewCourse = new ListItem(Course, CourseNo);
            ddlStudentCourse.Items.Add(NewCourse);
            Index++;
        }
        return Courses.Count;
    }

    Int32 DisplayTutors()
    {
        clsTutorCollection Tutors = new clsTutorCollection();
        string TutorNo;
        string Tutor;
        Int32 Index = 0;
        while (Index < Tutors.Count)
        {
            TutorNo = Convert.ToString(Tutors.AllTutors[Index].TutorId);
            Tutor = Tutors.AllTutors[Index].TutorName;
            ListItem NewTutor = new ListItem(Tutor, TutorNo);
            ddlStudentTutor.Items.Add(NewTutor);
            Index++;
        }
        return Tutors.Count;
    }
}