using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    Int32 StudentNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        StudentNo = Convert.ToInt32(Request.QueryString["StudentNo"]);
    }

    protected void btnRemoveConfirm_Click(object sender, EventArgs e)
    {
        clsStudentCollection MyStudents = new clsStudentCollection();
        
        Boolean Found;
        Found = MyStudents.ThisStudent.Find(StudentNo);

        if(Found)
            MyStudents.Delete();

        Response.Redirect("Default.aspx");
    }

    protected void btnRemoveReject_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}