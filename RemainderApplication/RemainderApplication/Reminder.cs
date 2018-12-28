using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RemainderApplication
{
    public class ReminderModel
    {
           public int Id { get; set; }

            public string Reminder { get; set; }

            public DateTime Date { get; set; }

            public TimeSpan Time { get; set; }
     }
}
