using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    class Activity : IActivity
    {
        public string Title { get; set; }
        public Activity(string title)
        {
            Title = title;
            
        }
        public void Execute()
        {
            Console.WriteLine("Implementing Activity {0}",Title);
        }
    }
}
