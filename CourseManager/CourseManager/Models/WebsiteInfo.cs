using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public class WebsiteInfo
    {
      
      public const string String = "课程管理系统";
      private string p;
      public List<ActionLinks> ActionLinks { get; set; }

      public string SiteName { get; set; }
      public string CopyRight { get; set; }

      public WebsiteInfo(string siteName, string copyRight)
      {
          SiteName = siteName;
          CopyRight = copyRight;

          ActionLinks = new List<ActionLinks>{
             new ActionLinks{Name="主页", Controller="Home",Action= "Index"},
             new ActionLinks{Name="关于", Controller="Home",Action= "About"},
             new ActionLinks{Name="联系方式", Controller="Home",Action= "Contact"}
      
        };
      }

      public WebsiteInfo(string p)
      {
          // TODO: Complete member initialization
          this.p = p;
      }

      public static string siteName { get; set; }
    }
}