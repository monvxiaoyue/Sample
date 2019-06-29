using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManager.BLLs.Classes
{
   public interface CourseManageDetail
    {
       public string  Classname { get;set;}

       public string Coursname { get; set; }

       public string Teachername { get; set; }
    }
}
