using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsTutor
/// </summary>
public class clsTutor
{

    private Int32 mTutorId;
    private Int32 mTutorCertificates;
    private String mTutorName;
    private DateTime mTutorRegisterDate;
    private Boolean mTutorEligible;
    private String mTutorSurname;
    private Int32 mTutorCourseNo;

    public Int32 TutorId
    {
        get
        {
            return mTutorId;
        }
        set
        {
            mTutorId = value;
        }
    }

    public Int32 TutorCertificates
    {
        get
        {
            return mTutorCertificates;
        }
        set
        {
            mTutorCertificates = value;
        }
    }
    public String TutorName
    {
        get
        {
            return mTutorName;
        }
        set
        {
            mTutorName = value;
        }
    }
    public DateTime TutorRegisterDate
    {
        get
        {
            return mTutorRegisterDate;
        }
        set
        {
            mTutorRegisterDate = value;
        }
    }
    public Boolean TutorEligible
    {
        get
        {
            return mTutorEligible;
        }
        set
        {
            mTutorEligible = value;
        }
    }
    public String TutorSurname
    {
        get
        {
            return mTutorSurname;
        }
        set
        {
            mTutorSurname = value;
        }
    }
    public Int32 TutorCourseNo
    {
        get
        {
            return mTutorCourseNo;
        }
        set
        {
            mTutorCourseNo = value;
        }
    }

    public string TutorValid(string TutorFirstName,
                              string TutorSurname,
                              string TutorAdditionDate,
                              string TutorCertificates)
    {
        string ErrorMsg = "";

        //Validation rules for TutorFirstName field
        if (TutorFirstName.Length == 0)
        {
            ErrorMsg += "The Tutor's first name is a required field" + Environment.NewLine;
        }
        else if (TutorFirstName.Trim().Length < 2 | TutorFirstName.Trim().Length > 50)
        {
            ErrorMsg += "Tutor's first name must be between 2 and 50 characters" + Environment.NewLine;
        }
        else if (!TutorFirstName.All(x => char.IsLetter(x)))
        {
            ErrorMsg += "Tutor's first name cannot contain any special characters" + Environment.NewLine;
        }

        //Validation rules for TutorSurname field
        if (TutorSurname.Length == 0)
        {
            ErrorMsg += "Tutor's last name is a required field" + Environment.NewLine;
        }
        else if (TutorSurname.Trim().Length < 2 | TutorSurname.Trim().Length > 50)
        {
            ErrorMsg += "Tutor's last name must be between 2 and 50 characters" + Environment.NewLine;
        }
        else if (!TutorSurname.All(x => char.IsLetter(x) || x == '-'))
        {
            ErrorMsg += "Tutor's last name cannot contain any special characters" + Environment.NewLine;
        }

        //Validation rules for TutorAdditionDate field
        if (TutorAdditionDate.Length == 0)
        {
            ErrorMsg += "Tutor registered date is a required field" + Environment.NewLine;
        }
        else if (TutorAdditionDate.Length != 10)
        {
            ErrorMsg += "Tutor registered date must consist of 10 characters, DD/MM/YYYY format." + Environment.NewLine;
        }
        else
        {
            //Check if the date is actually valid
            try
            {
                DateTime correctTutorAdditionDate = Convert.ToDateTime(TutorAdditionDate);
                //If it is valid, check if it is in between the correct range
                if (correctTutorAdditionDate < Convert.ToDateTime("01 Jan 1981") | correctTutorAdditionDate > DateTime.Now)
                {
                    ErrorMsg += "Tutor registered date cannot be in a future. The starting accepted year is 1981." + Environment.NewLine;
                }
            }
            catch
            {
                ErrorMsg += "Please enter the correct Tutor registered date" + Environment.NewLine;
            }

        }

        //Validation rules for Tutor Starting Years field
        if (TutorCertificates.Length == 0)
        {
            ErrorMsg += "Tutor certificate count is a required field" + Environment.NewLine;
        }
        else if (TutorCertificates.Length != 1)
        {
            ErrorMsg += "Tutor certificate count has to be 1-digit long." + Environment.NewLine;
        }
        else
        {
            try
            {
                Int32 correctTutorCertificates = Convert.ToInt32(TutorCertificates);
            }
            catch
            {
                ErrorMsg += "Tutor certificate count has to be a valid number" + Environment.NewLine;
            }
        }

        return ErrorMsg;
    }

    public Boolean Find(Int32 TutorId)
    {
        clsDataConnection dBConnection = new clsDataConnection();
        dBConnection.AddParameter("@TutorId", TutorId);
        dBConnection.Execute("sproc_tblTutor_FilterByTutorId");

        if (dBConnection.Count == 1)
        {
            mTutorId = Convert.ToInt32(dBConnection.DataTable.Rows[0]["TutorId"]);
            mTutorName = Convert.ToString(dBConnection.DataTable.Rows[0]["TutorName"]);
            mTutorRegisterDate = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["TutorRegisterDate"]);
            mTutorCourseNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["TutorCourseNo"]);
            mTutorSurname = Convert.ToString(dBConnection.DataTable.Rows[0]["TutorSurname"]);
            mTutorCertificates = Convert.ToInt32(dBConnection.DataTable.Rows[0]["TutorCertificates"]);
            try
            {
                mTutorEligible = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["TutorEligible"]);
            }
            catch
            {
                mTutorEligible = true;
            }
            return true;
        }
        else
        {
            return false;
        }
    }

}