using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace project.ViewModule
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private User selectedUser;
        private Book selectedBook;
        private UserBook selectedUserBook;

        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Book> Books { get; set; }
        public ObservableCollection<UserBook> UsersBooks { get; set; }

        //добавление
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      User user = new User();
                      Users.Insert(0, user);
                      SelectedUser = user;

                      Book book = new Book();
                      Books.Insert(0, book);
                      SelectedBook = book;
                  }));
            }
        }

        //удаление
        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      User user = obj as User;
                      if (user != null)
                      {
                          Users.Remove(user);
                      }

                      Book book = obj as Book;
                      if(user != null)
                      {
                          Books.Remove(book);
                      }
                  },
                 (obj) => Users.Count > 0));
            }
        }

        public User SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }

        public Book SelectedBook
        {
            get { return selectedBook; }
            set
            {
                selectedBook = value;
                OnPropertyChanged("SelectedBook");
            }
        }

        public UserBook SelectedUserBook
        {
            get { return selectedUserBook; }
            set
            {
                selectedUserBook = value;
                OnPropertyChanged("SelectedUserBook");
            }
        }
        public ApplicationViewModel()
        {
            Users = new ObservableCollection<User>
            {
                new User { Id = 1, Name = "Андрей", Lastname = "Воркунов" },
                new User { Id = 2, Name = "Андрей", Lastname = "Ермоленко" }
            };

            DateTime dt = new DateTime(1867, 01, 01);
            Books = new ObservableCollection<Book>
            {
                new Book { Title = "Война и мир", Author = "Лев Толстой", Year = dt, Count = 10 },
                new Book { Title = "Преступление и наказание", Author = "Фёдор Достоевский", Year = DateTime.Now, Count = 3 },
                new Book { Title = "Отцы и дети", Author = "Иван Тургенев", Year = DateTime.Now, Count = 4 },
                new Book { Title = "Евгений Онегин", Author = "Александр Пушкин", Year = DateTime.Now, Count = 2 },
                new Book { Title = "Горе от ума", Author = "Александр Грибоедов", Year = DateTime.Now, Count = 5 },
                new Book { Title = "Мертвые души", Author = "Николай Гоголь", Year = DateTime.Now, Count = 1 }
            };

            UsersBooks = new ObservableCollection<UserBook>
            {
                new UserBook { Name = "name", Lastname = "lastname", Title = "title" }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
