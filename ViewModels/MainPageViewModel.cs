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

        private ICommand addCommand { get; }
        private ICommand deleteCommand { get; }

        public MainPageViewModel()
        {

            addCommand = new AddCommand();
            deleteCommand = new DeleteCommand();
        }
    }
}
