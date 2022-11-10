using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder.Models
{
    public class ReminderModel
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime DateAndTime { get; }
    }
}
