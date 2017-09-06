using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var wEngine = new Engine();

            var workflow = new Workflow();
            workflow.Add(new NotificationActivity());
            workflow.Add(new VideoUploadActivity());

            wEngine.Run(workflow);

            Console.ReadLine();
        }
    }
}
