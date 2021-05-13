using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tutor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
            DisplayTutors("");
    }

    protected void btnStudents_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void btnAllTutors_Click(object sender, EventArgs e)
    {
        DisplayTutors("");
    }
    Int32 DisplayTutors(string CourseFilter)
    {
        Int32 TutorId;
        string TutorSurname;
        string TutorName;

        clsTutorCollection TutorList = new clsTutorCollection();
        TutorList.ReportByCourse(CourseFilter);
        Int32 RecordCount;
        Int32 Index = 0;
        RecordCount = TutorList.Count;
        lstTutors.Items.Clear();
        

        while (Index < RecordCount)
        {
            TutorId = TutorList.TutorList[Index].TutorId;
            TutorName = TutorList.TutorList[Index].TutorName;
            TutorSurname = TutorList.TutorList[Index].TutorSurname;

            ListItem NewEntry = new ListItem(TutorName + " " + TutorSurname, TutorId.ToString());
            lstTutors.Items.Add(NewEntry);
            Index++;
        }
        return RecordCount;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddTutor.aspx?txtTutorId=-1");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if(lstTutors.SelectedIndex != -1)
        {
            Response.Redirect("AddTutor.aspx?txtTutorId=" + lstTutors.SelectedValue);
        }
        else
        {
            lblError.Text = "You have to select a tutor first in order to edit their details!";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if(lstTutors.SelectedIndex != -1)
        {
            Response.Redirect("RemoveTutor.aspx?txtTutorID=" + lstTutors.SelectedValue);
        }
        else
        {
            lblError.Text = "You have to select a tutor first in order to remove them!";
        }
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        DisplayTutors(txtFilterBy.Text);
    }
}