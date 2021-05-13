using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsTutorCollection
/// </summary>
public class clsTutorCollection
{

    clsDataConnection dBConnection = new clsDataConnection();
    clsTutor mThisTutor = new clsTutor();

    public clsTutorCollection()
    {
        dBConnection.Execute("sproc_tblTutor_SelectAll");
    }

    public clsTutor ThisTutor
    {
        get
        {
            return mThisTutor;
        }
        set
        {
            mThisTutor = value;
        }
    }

    public Int32 Count
    {
        get
        {
            return dBConnection.Count;
        }
    }

    public bool Delete()
    {
        try
        {
            clsDataConnection MyDatabase = new clsDataConnection();
            MyDatabase.AddParameter("@TutorId", mThisTutor.TutorId);
            MyDatabase.Execute("sproc_tblTutor_Delete");
            return true;
        }
        catch
        {
            return false;
        }
    }

    public List<clsTutor> TutorList
    {
        get
        {
            //Create the list to store Tutors
            List<clsTutor> mTutorList = new List<clsTutor>();

            //Connect with the DB and select data via a stored procedure
            Int32 RecordCount;
            Int32 Index = 0;

            RecordCount = dBConnection.Count;

            //Assign collected data to the variables
            while (Index < RecordCount)
            {
                clsTutor Tutor = new clsTutor();

                Tutor.TutorId = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["TutorId"]);
                Tutor.TutorCertificates = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["TutorCertificates"]);
                Tutor.TutorName = Convert.ToString(dBConnection.DataTable.Rows[Index]["TutorName"]);
                Tutor.TutorCourseNo = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["TutorCourseNo"]);
                Tutor.TutorRegisterDate = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["TutorRegisterDate"]);
                Tutor.TutorEligible = Convert.ToBoolean(dBConnection.DataTable.Rows[Index]["TutorEligible"]);
                Tutor.TutorSurname = Convert.ToString(dBConnection.DataTable.Rows[Index]["TutorSurname"]);

                mTutorList.Add(Tutor);
                Index++;
            }
            return mTutorList;
        }

    }

    public Int32 Add()
    {
        clsDataConnection NewDBTutor = new clsDataConnection();

        NewDBTutor.AddParameter("@TutorName", mThisTutor.TutorName);
        NewDBTutor.AddParameter("@TutorSurname", mThisTutor.TutorSurname);
        NewDBTutor.AddParameter("@TutorRegisterDate", mThisTutor.TutorRegisterDate);
        NewDBTutor.AddParameter("@TutorEligible", mThisTutor.TutorEligible);
        NewDBTutor.AddParameter("@TutorCourseNo", mThisTutor.TutorCourseNo);
        NewDBTutor.AddParameter("@TutorCertificates", mThisTutor.TutorCertificates);

        return NewDBTutor.Execute("sproc_tblTutor_Insert");
    }

    public Int32 Update()
    {
        clsDataConnection ExistingDBTutor = new clsDataConnection();

        ExistingDBTutor.AddParameter("@TutorId", ThisTutor.TutorId);
        ExistingDBTutor.AddParameter("@TutorName", ThisTutor.TutorName);
        ExistingDBTutor.AddParameter("@TutorSurname", ThisTutor.TutorSurname);
        ExistingDBTutor.AddParameter("@TutorRegisterDate", ThisTutor.TutorRegisterDate);
        ExistingDBTutor.AddParameter("@TutorEligible", ThisTutor.TutorEligible);
        ExistingDBTutor.AddParameter("@TutorCourseNo", ThisTutor.TutorCourseNo);
        ExistingDBTutor.AddParameter("@TutorCertificates", ThisTutor.TutorCertificates);

        return ExistingDBTutor.Execute("sproc_tblTutor_Update");
    }

    public void ReportByCourse(string Course)
    {

        dBConnection = new clsDataConnection();
        if (Course != "")
        {
            dBConnection.AddParameter("@TutorCourse", Course);
            dBConnection.Execute("sproc_tblTutor_FilterByCourseName");
        }
        else
        {
            dBConnection.Execute("sproc_tblTutor_SelectAll");
        }
        
    }

    public List<clsTutor> AllTutors
    {
        get
        {
            List<clsTutor> mAllTutors = new List<clsTutor>();
            Int32 Index = 0;
            while (Index < dBConnection.Count)
            {
                clsTutor NewTutor = new clsTutor();
                NewTutor.TutorId = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["TutorId"]);
                NewTutor.TutorName = Convert.ToString(dBConnection.DataTable.Rows[Index]["TutorName"]);

                mAllTutors.Add(NewTutor);
                Index++;
            }
            return mAllTutors;
        }
    }

}