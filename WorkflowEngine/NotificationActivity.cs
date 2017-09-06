using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class NotificationActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Notifying user that video upload has begun..");
        }
    }
}
