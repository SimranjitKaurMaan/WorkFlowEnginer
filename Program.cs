using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Workflow w = new Workflow();
            Activity a = new Activity("Adding a video");
            Activity b = new Activity("Encoding the video");
            Activity c = new Activity("Sending Email");
            Activity d = new Activity("Sending Message");
            Activity e = new Activity("Notifying the client");
            w.Add(a);
            w.Add(b);
            w.Add(c);
            w.Add(d);
            w.Add(e);
            WorkFlowEngine engine = new WorkFlowEngine();
            engine.Run(w);

           
        }

    }
}
