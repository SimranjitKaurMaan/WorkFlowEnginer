using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    class Workflow :IWorkFlow
    {
        private readonly List<IActivity> _activities = new List<IActivity>();

        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }
        
        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}
