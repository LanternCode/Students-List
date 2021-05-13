using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsCourse
/// </summary>
public class clsCourse
{

    private Int32 mCourseNo;
    private string mCourseName;

    public Int32 CourseNo
    {
        get
        {
            return mCourseNo;
        }
        set
        {
            mCourseNo = value;
        }
    }

    public string CourseName
    {
        get
        {
            return mCourseName;
        }
        set
        {
            mCourseName = value;
        }
    }

}