using System;
namespace Student.class1
{
    public class student
    {
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public int Age { get; set; }

        public student(string fullname, string groupno, int age)
        {
            FullName = fullname;
            GroupNo = groupno;
            Age = age;

        }
         public static bool CheckGroupNo(string groupno)


        {
            if (groupno.Length==4 && char.IsUpper(groupno[0]))
            {
                return true;
            }
            return false;
        }
           public static bool CheckFullname(string checkfullname)
        {
            for (int i = 0; i < checkfullname.Length; i++)
            {
                if (checkfullname[i]==' ')
                {
                    return true;
                }
                
            }
            return false;
        }

    }

  
}
