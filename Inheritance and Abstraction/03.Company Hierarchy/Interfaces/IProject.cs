using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Interfaces
{
    public interface IProject
    {
        string ProjectName { get; }
        DateTime StartDate { get; }

        string Details { get; }

        bool State { get; }

        void CloseProject();
    }
}
