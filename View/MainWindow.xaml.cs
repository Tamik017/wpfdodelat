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
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ApplicationViewModel();
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
    }
}
