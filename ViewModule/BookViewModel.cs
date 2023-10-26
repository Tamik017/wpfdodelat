using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project.ViewModule
{
    public class BookViewModel : INotifyPropertyChanged
    {
        private Book book;

        public BookViewModel(Book b)
        {
            book = b;
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

        public string Author
        {
            get { return book.Author; }
            set
            {
                book.Author = value;
                OnPropertyChanged("Author");
            }
        }

        public DateTime Year
        {
            get { return book.Year; }
            set
            {
                book.Year = value;
                OnPropertyChanged("Year");
            }
        }

        public int Count
        {
            get { return book.Count; }
            set
            {
                book.Count = value;
                OnPropertyChanged("Count");
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
