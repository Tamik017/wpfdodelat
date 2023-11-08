using System;
using System.CodeDom.Compiler;
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
        private string userSearchText;
        private string bookSearchText;

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
                      selectedBook.Count--;
                      UserBook usBook = new UserBook()
                      {
                          Name = SelectedUser.Name,
                          Lastname = SelectedUser.Lastname,
                          Title = SelectedBook.Title
                      };
                      UsersBooks.Add(usBook);
                  },
                  (obj) => selectedBook != null && selectedUser != null && selectedBook.Count > 0));
            }
        }

        //удаление
        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            //get
            //{
            //    return removeCommand ??
            //      (removeCommand = new RelayCommand(obj =>
            //      {
            //          Book book = obj as Book;
            //          if (book != null && book.Title == selectedUserBook.Title)
            //          {
            //              book.Count++;
            //          }
            //          UserBook reuser = obj as UserBook;
            //          if (reuser != null)
            //          {
            //              UsersBooks.Remove(reuser);
            //          }
            //      }));
            //}

            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      selectedBook.Count++;
                      UserBook reuser = obj as UserBook;
                      if (reuser != null)
                      {
                          UsersBooks.Remove(reuser);
                      }
                  }));
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

        public string UserSearchText
        {
            get { return userSearchText; }
            set
            {
                userSearchText = value;
                OnPropertyChanged(nameof(UserSearchText));
                OnPropertyChanged(nameof(FilteredUsers));
            }
        }
        public ObservableCollection<User> FilteredUsers
        {
            get
            {
                if (userSearchText == null)
                    return Users;
                return new(Users.Where(x => x.Name.Contains(userSearchText, StringComparison.OrdinalIgnoreCase) || x.Lastname.Contains(userSearchText, StringComparison.OrdinalIgnoreCase)));
            }
        }

        public string BookSearchText
        {
            get { return bookSearchText; }
            set 
            { 
                bookSearchText = value; 
                OnPropertyChanged(nameof(BookSearchText));
                OnPropertyChanged(nameof(FilteredBooks));
            }
        }

        public ObservableCollection<Book> FilteredBooks
        {
            get
            {
                if (bookSearchText == null)
                    return Books;
                return new(Books.Where(x => x.Title.Contains(bookSearchText, StringComparison.OrdinalIgnoreCase) || x.Author.Contains(bookSearchText, StringComparison.OrdinalIgnoreCase)));
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
                //new UserBook { Name = "name", Lastname = "lastname", Title = "title" }
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
