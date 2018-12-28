using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RemainderApplication
{
    using System;
    public class Program
    {
       public static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to Reminder Application");
                Console.WriteLine("--------------------");
                Console.WriteLine("Choose The Operation");
                Console.WriteLine("1.View Existing Reminders");
                Console.WriteLine("2.Create New Reminder");
                Console.WriteLine("3.Update Existing Reminder");
                Console.WriteLine("4.Exit");
                int ch = Int32.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        ReminderBussinessLogic.ViewReminders();
                        Console.WriteLine("Press any key to Menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        ReminderBussinessLogic.CreateReminders();
                        ReminderBussinessLogic.ViewReminders();
                        Console.WriteLine("Press any key to Menu");
                        Console.ReadKey();
                        break;
                    case 3:
                        ReminderBussinessLogic.ViewReminders();
                        ReminderBussinessLogic.UpdateReminder();
                        Console.WriteLine("Press any key to Menu");
                        Console.ReadKey();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please Choose the correct Option");
                        break;
                }
            } while (true);
            
        }

      
    }
}
