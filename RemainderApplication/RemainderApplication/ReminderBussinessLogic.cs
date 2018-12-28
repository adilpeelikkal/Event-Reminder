using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemainderApplication
{
   public static class ReminderBussinessLogic
    {
       public static void UpdateReminder()
        {
            Console.WriteLine("Enter the Reminder Id you want to update");
            int id = Int32.Parse(Console.ReadLine());
            ReminderDbContext reminderDbContext = new ReminderDbContext();
            var reminderData = reminderDbContext.Reminders.Find(id);
            if (reminderData != null)
            {
                CultureInfo provider = CultureInfo.InvariantCulture;
                Console.WriteLine("Enter Reminder..if you dont want to change just give enter");
                var reminder = Console.ReadLine();
                if (reminder != "")
                {
                    reminderData.Reminder = reminder;
                }
                Console.WriteLine("Enter Reminder Date in the format mm/dd/yyyy..if you dont want to change just give enter");
                var date = Console.ReadLine();
                if (date != "")
                {
                    reminderData.Date = DateTime.ParseExact(date, "mm/dd/yyyy", provider);
                }
                Console.WriteLine("Enter Reminder Time in the format hh.mm.ss ..if you dont want to change just give enter");
                var time = Console.ReadLine();
                if (time != "")
                {
                    reminderData.Time = DateTime.ParseExact(
                           time,
                          "HH.mm.ss",
                          CultureInfo.InvariantCulture
                          ).TimeOfDay;
                }
                reminderDbContext.SaveChanges();
                Console.WriteLine("Changes are Updated");
                ViewReminders();
            }
            else
            {
                Console.WriteLine("Id not Found");
            }
        }

       public static void CreateReminders()
        {
            Console.WriteLine("Enter Reminder");
            string reminder = Console.ReadLine();
            Console.WriteLine("Enter Reminder Date in the format mm/dd/yyyy");
            string date = Console.ReadLine();
            Console.WriteLine("Enter Reminder Time in the format hh.mm.ss");
            string time = Console.ReadLine();
            PerformDatabaseOperations(reminder, date, time);
        }

       public static void ViewReminders()
        {
            ReminderDbContext reminderDbContext = new ReminderDbContext();
            var RemindersList = reminderDbContext.Reminders.ToList();
            Console.WriteLine("ID      Reminder      Date           Time");
            foreach (var eachReminder in RemindersList)
            {
                Console.WriteLine(eachReminder.Id + "        " + eachReminder.Reminder + "      " + eachReminder.Date.ToShortDateString() + "       " + eachReminder.Time);
            }
        }
        public static void PerformDatabaseOperations(string reminder, string date, string time)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            using (var db = new ReminderDbContext())
            {
                var Reminder = new ReminderModel
                {
                    Reminder = reminder,
                    Date = DateTime.ParseExact(date, "mm/dd/yyyy", provider),
                    Time = DateTime.ParseExact(
                               time,
                               "HH.mm.ss",
                               CultureInfo.InvariantCulture
                               ).TimeOfDay
                };
                db.Reminders.Add(Reminder);
                db.SaveChanges();
            }
        }
    }
}
