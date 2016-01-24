using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy
{
    using System;
    using Interfaces;

    public class Project //: //IProject
    {
        private string projectName;
        private string details;

        public Project(string projectName, DateTime startDate, string details)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = startDate;
            this.Details = details;
        }

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Project name cannot be null");
                }
                this.projectName = value;
            }
        }

        public DateTime ProjectStartDate { get; set; }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Details cannot be null");
                }
                this.details = value;
            }
        }

        public bool State { get; private set; } = true;

        public void CloseProject()
        {
            this.State = false;
        }

        public override string ToString()
        {
            return string.Format("Project name: {0}\nStart date: {1}\nStatus: {2}\n", this.ProjectName, this.ProjectStartDate.Date, (this.State ? "Open" : "Closed"));
        }
    }
}
