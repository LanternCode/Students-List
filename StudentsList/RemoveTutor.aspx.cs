using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RemoveTutor : System.Web.UI.Page
{
    Int32 TutorId;
    protected void Page_Load(object sender, EventArgs e)
    {
        TutorId = Convert.ToInt32(Request.QueryString["txtTutorID"]);
    }

    protected void btnRemoveConfirm_Click(object sender, EventArgs e)
    {
        clsTutorCollection MyTutors = new clsTutorCollection();
        
        Boolean Found;

        Found = MyTutors.ThisTutor.Find(TutorId);

        if (Found)
            MyTutors.Delete();

        Response.Redirect("Tutor.aspx");
        
    }

    protected void btnRemoveReject_Click(object sender, EventArgs e)
    {
        Response.Redirect("Tutor.aspx");
    }
}