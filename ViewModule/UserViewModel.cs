using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project.ViewModule
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private User user;

        public UserViewModel(User u)
        {
            user = u;
        }

        public string Name
        {
            get { return user.Name; }
            set
            {
                user.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Lastname
        {
            get { return user.Lastname; }
            set
            {
                user.Lastname = value;
                OnPropertyChanged("Lastname");
            }
        }

        public int Id
        {
            get { return user.Id; }
            set
            {
                user.Id = value;
                OnPropertyChanged("Id");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
