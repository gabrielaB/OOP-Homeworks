using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Employees.RegularEmployees
{
   public class Project: IProject
   {
       private string projectName;
       private DateTime projectStartDate;
       private string details;
        private State state;

       public Project(string projectName,DateTime projectStartDate,string details,State state)
       {
           this.ProjectName = projectName;
           this.ProjectStartDate = projectStartDate;
           this.Details = details;
           this.State = state;

       }

      

       public string ProjectName { get; set; }
       public DateTime ProjectStartDate { get; set; }
       public string Details { get; set; }
       public State State { get; set; }

       public void ClosedProject()
       {
           Console.WriteLine("Project closed");
       }
   }
}
