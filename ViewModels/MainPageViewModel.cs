using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Reminder.Commands;
using Reminder.Models;

namespace Reminder.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReminderModel> _reminders;





        public MainPageViewModel()
        {
            AddCommand = new AddCommand();
        }
        public ICommand AddCommand { get; }
    }
}
