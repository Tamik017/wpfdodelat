using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using project.ViewModule;

namespace project
{
    public partial class MainWindow : Window
    {
        //private ObservableCollection<User> users = new ObservableCollection<User>();
        //private ObservableCollection<Book> books = new ObservableCollection<Book>();
        //private ObservableCollection<UserBook> userbooks = new ObservableCollection<UserBook>();

        //public class User
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public string LastName { get; set; }
        //    public List<Book> Books { get; set; } = new List<Book>();
        //}

        //public class Book
        //{
        //    public string Title { get; set; }
        //    public string Author { get; set; }
        //    public DateTime Year { get; set; }
        //    public int Count { get; set; }
        //}

        //public class UserBook
        //{
        //    public User User { get; set; }
        //    public Book Book { get; set; }
        //}
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ApplicationViewModel();

        //    userListView.ItemsSource = users;
        //    bookListView.ItemsSource = books;
        //    issuedBooksListView.ItemsSource = userbooks;

        //    DateTime dt = new DateTime(1867,01,01);

        //    users.Add(new User { Id = 1, Name = "Андрей", LastName = "Воркунов" });
        //    users.Add(new User { Id = 2, Name = "Андрей", LastName = "Ермоленко" });

        //    books.Add(new Book { Title = "Война и мир", Author = "Лев Толстой", Year = dt, Count = 10 });
        //    books.Add(new Book { Title = "Преступление и наказание", Author = "Фёдор Достоевский", Year = DateTime.Now, Count = 3 });
        //    books.Add(new Book { Title = "Отцы и дети", Author = "Иван Тургенев", Year = DateTime.Now, Count = 4 });
        //    books.Add(new Book { Title = "Евгений Онегин", Author = "Александр Пушкин", Year = DateTime.Now, Count = 2 });
        //    books.Add(new Book { Title = "Горе от ума", Author = "Александр Грибоедов", Year = DateTime.Now, Count = 5 });
        //    books.Add(new Book { Title = "Мертвые души", Author = "Николай Гоголь", Year = DateTime.Now, Count = 1 });
        }

        //Поиск 
        private void SearchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (searchUserTextBox.Text == "Поиск...")
            {
                searchUserTextBox.Text = "";
            }

            if (searchBookTextBox.Text == "Поиск...")
            {
                searchBookTextBox.Text = "";
            }
        }

        private void SearchBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchUserTextBox.Text))
            {
                searchUserTextBox.Text = "Поиск...";
            }

            if (string.IsNullOrWhiteSpace(searchBookTextBox.Text))
            {
                searchBookTextBox.Text = "Поиск...";
            }

            if (string.IsNullOrWhiteSpace(newUserNameTextBox.Text))
            {
                newUserNameTextBox.Text = "Имя";
            }

            if (string.IsNullOrWhiteSpace(newUserLastNameTextBox.Text))
            {
                newUserLastNameTextBox.Text = "Фамилия";
            }
        }

        private void NameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (newUserNameTextBox.Text == "Имя")
            {
                newUserNameTextBox.Text = "";
            }
        }

        private void LastNameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (newUserLastNameTextBox.Text == "Фамилия")
            {
                newUserLastNameTextBox.Text = "";
            }
        }

        //private void SearchButton_Click(object sender, RoutedEventArgs e)
        //{
        //    string searchText = searchUserTextBox.Text.Trim();

        //    if (string.IsNullOrEmpty(searchText))
        //    {
        //        MessageBox.Show("Пожалуйста, введите Имя или Фамилию пользователя для поиска.");
        //        return;
        //    }

        //    // Очистка выделения в списке пользователей
        //    userListView.SelectedItem = null;

        //    // Проход по списку пользователей и поиск
        //    foreach (User user in users)
        //    {
        //        if  (user.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
        //            user.LastName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
        //            (user.Name + " " + user.LastName).Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
        //            (user.LastName + " " + user.Name).Contains(searchText, StringComparison.OrdinalIgnoreCase))
        //        {
        //            userListView.SelectedItem = user;
        //            issuedBooksListView.SelectedItem = user;
        //            break;
        //        }
        //    }

        //    if (userListView.SelectedItem == null)
        //    {
        //        MessageBox.Show("Пользователь не найден.");
        //    }
        //}

        //private void SearchBookButton_Click(object sender, RoutedEventArgs e)
        //{
        //    string searchText = searchBookTextBox.Text.Trim();

        //    if (string.IsNullOrEmpty(searchText))
        //    {
        //        MessageBox.Show("Пожалуйста, введите название книги или автора для поиска.");
        //        return;
        //    }

        //    // Очистка выделения в списке книг
        //    bookListView.SelectedItem = null;

        //    foreach (Book book in books)
        //    {
        //        if (book.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase) || book.Author.Contains(searchText, StringComparison.OrdinalIgnoreCase))
        //        {
        //            bookListView.SelectedItem = book;
        //            break;
        //        }
        //    }

        //    if (bookListView.SelectedItem == null)
        //    {
        //        MessageBox.Show("Книга не найдена.");
        //    }
        //}

        //private void AddUserAndBookButton_Click(object sender, RoutedEventArgs e)
        //{
        //    string name = newUserNameTextBox.Text.Trim();
        //    string lastname = newUserLastNameTextBox.Text.Trim();
        //    User selectedUser = (User)userListView.SelectedItem;
        //    Book selectedBook = (Book)bookListView.SelectedItem;

        //    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(lastname) && /*selectedUser != null &&*/ selectedBook != null && selectedBook.Count > 0 &&
        //        (name) != "Имя" && (lastname) != "Фамилия")
        //    {
        //        User newUser = new User { Id = users.Count + 1, Name = name, LastName = lastname };
        //        users.Add(newUser);
        //        newUserNameTextBox.Clear();
        //        newUserLastNameTextBox.Clear();

        //        UserBook newUserBook = new UserBook { User = newUser, Book = selectedBook };
        //        userbooks.Add(newUserBook);

        //        // Уменьшение количества книг
        //        selectedBook.Count--;

        //        // Обновление отображения количества книг в списке книг
        //        CollectionViewSource.GetDefaultView(books).Refresh();
        //    }
        //    else if (selectedBook != null && selectedBook.Count==0)
        //    {
        //        MessageBox.Show("Данная книга закончилась, выберите другую!");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Пожалуйста, введите Имя и Фамилию пользователя.");
        //    }
        //}

        //private void ReturnBookButton_Click(object sender, RoutedEventArgs e)
        //{
        //    UserBook selectedLoan = (UserBook)issuedBooksListView.SelectedItem;

        //    if (selectedLoan != null)
        //    {
        //        selectedLoan.Book.Count++;

        //        // Удаление записи о возврате из коллекции loans
        //        userbooks.Remove(selectedLoan);

        //        // Обновление отображения количества книг в списке книг
        //        CollectionViewSource.GetDefaultView(books).Refresh();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Выберите книгу для возврата.");
        //    }
        //}
    }
}
