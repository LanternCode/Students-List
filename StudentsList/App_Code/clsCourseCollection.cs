using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsCourseCollection
/// </summary>
public class clsCourseCollection
{

    clsDataConnection Courses = new clsDataConnection();

    public clsCourseCollection()
    {
        Courses.Execute("sproc_tblCourse_SelectAll");
    }

    public Int32 Count
    {
        get
        {
            return Courses.Count;
        }
    }

    public List<clsCourse> AllCourses
    {
        get
        {
            List<clsCourse> mAllCourses = new List<clsCourse>();
            Int32 Index = 0;
            while( Index < Courses.Count )
            {
                clsCourse NewCourse = new clsCourse();
                NewCourse.CourseNo = Convert.ToInt32(Courses.DataTable.Rows[Index]["CourseNo"]);
                NewCourse.CourseName = Convert.ToString(Courses.DataTable.Rows[Index]["CourseName"]);

                mAllCourses.Add(NewCourse);
                Index++;
            }
            return mAllCourses;
        }
    }
}