using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialDesignThemes.Wpf;
using Reminder.Views;

namespace Reminder.Commands
{
    public class AddCommand : CommandBase
    {
        public override void Execute(object? parameter)
        {
            NewReminderView newReminderView = new NewReminderView();
            newReminderView.Show();
        }
    }
}
