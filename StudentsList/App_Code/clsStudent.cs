using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsStudent
/// </summary>
public class clsStudent
{

    private Int32 mStudentNo;
    private String mStudentPNumber;
    private String mStudentFullName;
    private DateTime mStudentAdditionDate;
    private Boolean mStudentExpelled;
    private Int32 mStudentCourseNo;
    private Decimal mStudentAttendancePercentage;
    private Int32 mStudentStartingYear;
    private Int32 mStudentTutorNo;
    
    public Int32 StudentNo
    {
        get
        {
            return mStudentNo;
        }
        set
        {
            mStudentNo = value;
        }
    }

    public String StudentPNumber
    {
        get
        {
            return mStudentPNumber;
        }
        set
        {
            mStudentPNumber = value;
        }
    }
    public String StudentFullName
    {
        get
        {
            return mStudentFullName;
        }
        set
        {
            mStudentFullName = value;
        }
    }
    public DateTime StudentAdditionDate
    {
        get
        {
            return mStudentAdditionDate;
        }
        set
        {
            mStudentAdditionDate = value;
        }
    }
    public Boolean StudentExpelled
    {
        get
        {
            return mStudentExpelled;
        }
        set
        {
            mStudentExpelled = value;
        }
    }
    public Int32 StudentCourseNo
    {
        get
        {
            return mStudentCourseNo;
        }
        set
        {
            mStudentCourseNo = value;
        }
    }
    public Decimal StudentAttendancePercentage
    {
        get
        {
            return mStudentAttendancePercentage;
        }
        set
        {
            mStudentAttendancePercentage = value;
        }
    }

    public Int32 StudentStartingYear
    {
        get
        {
            return mStudentStartingYear;
        }
        set
        {
            mStudentStartingYear = value;
        }
    }

    public Int32 StudentTutorNo
    {
        get
        {
            return mStudentTutorNo;
        }
        set
        {
            mStudentTutorNo = value;
        }
    }

    public string StudentValid(string StudentPNumber,
                               string StudentFullName,
                               string StudentAdditionDate,
                               string StudentAssignmentCompletion,
                               string StudentStartingYear)
    {
        string ErrorMsg = "";

        //Validation rules for StudentPNumber field
        if (StudentPNumber.Length == 0)
        {
            ErrorMsg += "The PNumber is a required field" + Environment.NewLine;
        }
        else if (StudentPNumber.Length != 8)
        {
            ErrorMsg += "The PNumber must consist of exactly 8 characters" + Environment.NewLine;
        }
        else if (!StudentPNumber.StartsWith("P"))
        {
            ErrorMsg += "The PNumber must start with the P letter" + Environment.NewLine;
        }
        else if (StudentPNumber.Any(ch => !Char.IsLetterOrDigit(ch)))
        {
            ErrorMsg += "The PNumber can only contain letters and digits" + Environment.NewLine;
        }
        else if(StudentPNumber.Count(char.IsLetter) > 1)
        {
            ErrorMsg += "The PNumber can only contain one letter, the P at the front." + Environment.NewLine;
        }
        
        //Validation rules for StudentFullName field
        if (StudentFullName.Length == 0)
        {
            ErrorMsg += "Student's Full Name is a required field" + Environment.NewLine;
        }
        else if (StudentFullName.Trim().Length < 4 | StudentFullName.Trim().Length > 70)
        {
            ErrorMsg += "Student's Full Name must be between 4 and 70 characters" + Environment.NewLine;
        }
        else if(!StudentFullName.All( x => char.IsLetter(x) || x == ' '))
        {
            ErrorMsg += "Student's Full Name cannot contain any special characters" + Environment.NewLine;
        }

        //Validation rules for StudentAdditionDate field
        if(StudentAdditionDate.Length == 0)
        {
            ErrorMsg += "Original Addition Date is a required field" + Environment.NewLine;
        }
        else if (StudentAdditionDate.Length != 10)
        {
            ErrorMsg += "Original Addition Date must consist of 10 characters, DD/MM/YYYY format." + Environment.NewLine;
        }
        else
        {
            //Check if the date is actually valid
            try
            {
                
                DateTime correctStudentAdditionDate = Convert.ToDateTime(StudentAdditionDate);

                //If it is valid, check if it is in between the correct range
                if(correctStudentAdditionDate < Convert.ToDateTime("01 Jan 1981") | correctStudentAdditionDate > DateTime.Now)
                {
                    ErrorMsg += "Original Addition Date cannot be in a future. The starting accepted year is 1981." + Environment.NewLine;
                }
                
            }
            catch
            {
                ErrorMsg += "Please enter the correct Original Addition Date" + Environment.NewLine;
            }
            
        }

        //Validation rules for StudentAssignmentCompletion field
        if(StudentAssignmentCompletion.Length == 0)
        {
            ErrorMsg += "Student Assignment Completion is a required field" + Environment.NewLine;
        }
        else
        {
            try
            {
                Decimal correctStudentAssignmentCompletion = Convert.ToDecimal(StudentAssignmentCompletion);
                
                if(correctStudentAssignmentCompletion < 0 | correctStudentAssignmentCompletion > 100)
                {
                    ErrorMsg += "Student Assignment Completion has to be between 0% and 100%. Decimal separator is '.'" + Environment.NewLine;
                }
                
            }
            catch
            {
                ErrorMsg += "Please enter valid Student Assignment Completion Percentage" + Environment.NewLine;
            }
        }

        //Validation rules for Student Starting Years field
        if(StudentStartingYear.Length == 0)
        {
            ErrorMsg += "Student starting year is a required field" + Environment.NewLine;
        }
        else if(StudentStartingYear.Length != 1)
        {
            ErrorMsg += "Student starting year has to be 1-digit long." + Environment.NewLine;
        }
        else
        {
            try
            {
                Int32 correctStudentStartingYear = Convert.ToInt32(StudentStartingYear);
                
                if(correctStudentStartingYear != 1 && correctStudentStartingYear != 2 && correctStudentStartingYear != 3)
                {
                     ErrorMsg += "Student starting year has to be either 1, 2 or 3." + Environment.NewLine;
                }
                
            }
            catch
            {
                ErrorMsg += "Student starting year has to be 1-digit long." + Environment.NewLine;
            }
        }

        return ErrorMsg;
    }

    public Boolean Find(Int32 StudentNo)
    {
        clsDataConnection dBConnection = new clsDataConnection();
        dBConnection.AddParameter("@StudentNo", StudentNo);
        dBConnection.Execute("sproc_tblStudent_FilterByStudentNo");
        if(dBConnection.Count == 1)
        {
            mStudentNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["StudentNo"]);
            mStudentPNumber = Convert.ToString(dBConnection.DataTable.Rows[0]["StudentPNumber"]);
            mStudentAdditionDate = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["StudentAdditionDate"]);
            mStudentAttendancePercentage = Convert.ToDecimal(dBConnection.DataTable.Rows[0]["StudentAttendancePercentage"]);
            mStudentCourseNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["StudentCourseNo"]);
            mStudentFullName = Convert.ToString(dBConnection.DataTable.Rows[0]["StudentFullName"]);
            mStudentStartingYear = Convert.ToInt32(dBConnection.DataTable.Rows[0]["StudentStartingYear"]);
            mStudentTutorNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["StudentTutorId"]);

            try
            {
                mStudentExpelled = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["StudentExpelled"]);
            }
            catch
            {
                mStudentExpelled = true;
            }
            return true;
        }
        else
        {
            return false;
        }
    }

}