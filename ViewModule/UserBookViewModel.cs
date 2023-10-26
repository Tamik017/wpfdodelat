using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project.ViewModule
{
    public class UserBookViewModel : INotifyPropertyChanged
    {
        private User user;
        private Book book;

        public UserBookViewModel(User u, Book b)
        {
            user = u;
            book = b;
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

        public string Title
        {
            get { return book.Title; }
            set
            {
                book.Title = value;
                OnPropertyChanged("Title");
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
