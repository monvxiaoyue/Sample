using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseManager.Migrations.Seeds
{
    public class SideBarsCreator
    {
          private readonly CourseManager.Models.CourseManageEntities _context;

         public SideBarsCreator( CourseManager.Models.CourseManageEntities context)
            {
             _context = context;
         
            }
         public void Seed()
            {
               var initralSideBars=new List<SideBars>
               {
                     new  SideBars
                 {
                    Name = "班级管理",
                    Controller = "Class",
                    Action  = "Index"
                 },
                      new  SideBars
                 {
                    Name = "教师管理",
                    Controller = "Teacher",
                    Action  = "Index"
                 },
                      new  SideBars
                 {
                    Name = "学生管理",
                    Controller = "Student",
                    Action  = "Index"
                 },
                      new  SideBars
                 {
                    Name = "课程科目管理",
                    Controller = "Course",
                    Action  = "Index"
                 },
                      new  SideBars
                 {
                    Name = "课程安排管理",
                    Controller = "CourseManagement",
                    Action  = "Index"
                 },
                      new  SideBars
                 {
                    Name = "顶部导航栏管理",
                    Controller = "ActionLink",
                    Action  = "Index"
                  },
                     new  SideBars
                  {
                    Name = "侧边导航栏管理",
                    Controller = "SideBar",
                    Action  = "Index"
                 },
              };
             foreach (var bar in initralSideBars)
             {
               if (_context.SideBars.Any(r => r.Name == bar.Name ))
               {
                     continue;
               }
                 _context.SideBars.Add(bar);
             }
              _context.SaveChanges();
        }
    
          public  string Name { get; set; }}
    }
