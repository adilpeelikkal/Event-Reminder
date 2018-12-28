using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RemainderApplication
{
        public class ReminderDbContext : DbContext
        {
            public ReminderDbContext()
                : base("Data Source=DESKTOP-D7JV3D3\\SQLEXPRESS;Initial Catalog=Gandeev;Persist Security Info=True;User ID=TestDb;Password=password123;MultipleActiveResultSets=True")
        {
            
        }
            public DbSet<ReminderModel> Reminders { get; set; }
        }
}
