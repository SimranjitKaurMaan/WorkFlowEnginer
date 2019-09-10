using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    interface IWorkFlow
    {
        void Add(IActivity activity);
        IEnumerable<IActivity> GetActivities();

    }
}
