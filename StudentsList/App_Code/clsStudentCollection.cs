using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsAddressCollection
/// </summary>
public class clsStudentCollection
{
    clsDataConnection dBConnection = new clsDataConnection();
    clsStudent mThisStudent = new clsStudent();
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
            MyDatabase.AddParameter("@StudentNo", mThisStudent.StudentNo);
            MyDatabase.Execute("sproc_tblStudent_Delete");
            return true;
        }
        catch
        {
            return false;
        }
    }

    public List<clsStudent> StudentList
    {
        get
        {

            //Create the list to store students
            List<clsStudent> mStudentList = new List<clsStudent>();

            //Connect with the DB and select data via a stored procedure
            Int32 RecordCount;
            Int32 Index = 0;

            RecordCount = dBConnection.Count;

            //Assign collected data to the variables
            while (Index < RecordCount)
            {
                clsStudent Student = new clsStudent();

                Student.StudentNo = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["StudentNo"]);
                Student.StudentPNumber = Convert.ToString(dBConnection.DataTable.Rows[Index]["StudentPNumber"]);
                Student.StudentFullName = Convert.ToString(dBConnection.DataTable.Rows[Index]["StudentFullName"]);
                Student.StudentCourseNo = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["StudentCourseNo"]);
                Student.StudentAdditionDate = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["StudentAdditionDate"]);
                Student.StudentExpelled = Convert.ToBoolean(dBConnection.DataTable.Rows[Index]["StudentExpelled"]);
                Student.StudentAttendancePercentage = Convert.ToDecimal(dBConnection.DataTable.Rows[Index]["StudentAttendancePercentage"]);
                Student.StudentStartingYear = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["StudentStartingYear"]);
                Student.StudentTutorNo = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["StudentTutorId"]);

                mStudentList.Add(Student);
                Index++;
            }
            return mStudentList;
        }

    }

    public Int32 Add()
    {
        clsDataConnection NewDBStudent = new clsDataConnection();
       
        NewDBStudent.AddParameter("@StudentPNumber", mThisStudent.StudentPNumber );
        NewDBStudent.AddParameter("@StudentFullName", mThisStudent.StudentFullName );
        NewDBStudent.AddParameter("@StudentAdditionDate", mThisStudent.StudentAdditionDate );
        NewDBStudent.AddParameter("@StudentExpelled", mThisStudent.StudentExpelled );
        NewDBStudent.AddParameter("@StudentCourseNo", mThisStudent.StudentCourseNo );
        NewDBStudent.AddParameter("@StudentAttendancePercentage", mThisStudent.StudentAttendancePercentage );
        NewDBStudent.AddParameter("@StudentStartingYear", mThisStudent.StudentStartingYear );
        NewDBStudent.AddParameter("@StudentTutorNo", mThisStudent.StudentTutorNo);

        return NewDBStudent.Execute("sproc_tblStudent_Insert");
    }

    public Int32 Update()
    {
        clsDataConnection ExistingDBStudent = new clsDataConnection();

        ExistingDBStudent.AddParameter("@StudentNo", mThisStudent.StudentNo);
        ExistingDBStudent.AddParameter("@StudentPNumber", mThisStudent.StudentPNumber);
        ExistingDBStudent.AddParameter("@StudentFullName", mThisStudent.StudentFullName);
        ExistingDBStudent.AddParameter("@StudentAdditionDate", mThisStudent.StudentAdditionDate);
        ExistingDBStudent.AddParameter("@StudentExpelled", mThisStudent.StudentExpelled);
        ExistingDBStudent.AddParameter("@StudentCourseNo", mThisStudent.StudentCourseNo);
        ExistingDBStudent.AddParameter("@StudentAttendancePercentage", mThisStudent.StudentAttendancePercentage);
        ExistingDBStudent.AddParameter("@StudentStartingYear", mThisStudent.StudentStartingYear);
        ExistingDBStudent.AddParameter("@StudentTutorNo", mThisStudent.StudentTutorNo);

        return ExistingDBStudent.Execute("sproc_tblStudent_Update");
    }

    public void ReportByCourse(string Course)
    {
        dBConnection = new clsDataConnection();
        if(Course != "")
        {
            dBConnection.AddParameter("@StudentCourseNo", Course);
            dBConnection.Execute("sproc_tblStudent_FilterByCourseName");
        }
        else
        {
            dBConnection.Execute("sproc_tblStudent_SelectAll");
        }
    }

    public clsStudent ThisStudent
    {
        get
        {
            return mThisStudent;
        }
        set
        {
            mThisStudent = value;
        }
    }

}