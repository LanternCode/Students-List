using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddTutor : System.Web.UI.Page
{

    //global variables
    Int32 TutorId;

    protected void Page_Load(object sender, EventArgs e)
    {
        TutorId = Convert.ToInt32(Request.QueryString["txtTutorId"]);

        if(IsPostBack != true)
        {
            DisplayCourses();
            if (TutorId != -1)
            {
                DisplayTutor(TutorId);
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Tutor.aspx");
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        clsTutor ThisTutor = new clsTutor();
        string ErrorMsg;

        ErrorMsg = ThisTutor.TutorValid(txtTutorFirstName.Text,
                                            txtTutorLastName.Text,
                                            txtTutorRegisteredOn.Text,
                                            txtTutorCertificateCount.Text);

        txtErrorMessage.Visible = true;

        if (ErrorMsg == "")
        {
            clsTutorCollection NewTutor = new clsTutorCollection();
            if (TutorId == -1)
            {
                NewTutor.ThisTutor.TutorName = txtTutorFirstName.Text;
                NewTutor.ThisTutor.TutorSurname = txtTutorLastName.Text;
                NewTutor.ThisTutor.TutorRegisterDate = Convert.ToDateTime(txtTutorRegisteredOn.Text);
                NewTutor.ThisTutor.TutorEligible = chkTutorEligible.Checked;
                NewTutor.ThisTutor.TutorCertificates = Convert.ToInt32(txtTutorCertificateCount.Text);
                NewTutor.ThisTutor.TutorCourseNo = ddlTutorTeachingCourse.SelectedIndex+1;

                NewTutor.Add();
            }
            else
            {
                NewTutor.ThisTutor.TutorId = TutorId;
                NewTutor.ThisTutor.TutorName = txtTutorFirstName.Text;
                NewTutor.ThisTutor.TutorSurname = txtTutorLastName.Text;
                NewTutor.ThisTutor.TutorRegisterDate = Convert.ToDateTime(txtTutorRegisteredOn.Text);
                NewTutor.ThisTutor.TutorEligible = chkTutorEligible.Checked;
                NewTutor.ThisTutor.TutorCertificates = Convert.ToInt32(txtTutorCertificateCount.Text);
                NewTutor.ThisTutor.TutorCourseNo = ddlTutorTeachingCourse.SelectedIndex+1;

                NewTutor.Update();
            }
            Response.Redirect("Tutor.aspx");
        }
        else
        {
            txtErrorMessage.Text = ErrorMsg;
        }
    }

    void DisplayTutor(Int32 TutorsId)
    {
        clsTutor myTutor = new clsTutor();
        myTutor.Find(TutorsId);

        txtTutorCertificateCount.Text = Convert.ToString(myTutor.TutorCertificates);
        txtTutorFirstName.Text = myTutor.TutorName;
        txtTutorLastName.Text = myTutor.TutorSurname;
        txtTutorRegisteredOn.Text = myTutor.TutorRegisterDate.ToString("dd/MM/yyyy");
        chkTutorEligible.Checked = myTutor.TutorEligible;
        ddlTutorTeachingCourse.SelectedIndex = myTutor.TutorCourseNo-1;
    }

    Int32 DisplayCourses()
    {
        clsCourseCollection Courses = new clsCourseCollection();
        string CourseNo;
        string Course;
        Int32 Index = 0;
        while (Index < Courses.Count)
        {
            CourseNo = Convert.ToString(Courses.AllCourses[Index].CourseNo);
            Course = Courses.AllCourses[Index].CourseName;
            ListItem NewCourse = new ListItem(Course, CourseNo);
            ddlTutorTeachingCourse.Items.Add(NewCourse);
            Index++;
        }
        return Courses.Count;
    }

}