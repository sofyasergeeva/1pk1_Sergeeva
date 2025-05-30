using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Task_39_02
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> shoppingItems = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            lbShoppingList.ItemsSource = shoppingItems;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewItem.Text))
            {
                shoppingItems.Add(txtNewItem.Text);
                txtNewItem.Clear();
                tbStatus.Text = $"Добавлен продукт: {shoppingItems[shoppingItems.Count - 1]}";
            }
            else
            {
                tbStatus.Text = "Введите название продукта!";
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lbShoppingList.SelectedItem != null)
            {
                string removedItem = (string)lbShoppingList.SelectedItem;
                shoppingItems.Remove(removedItem);
                tbStatus.Text = $"Удален продукт: {removedItem}";
            }
            else
            {
                tbStatus.Text = "Выберите продукт для удаления!";
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (shoppingItems.Count == 0)
            {
                tbStatus.Text = "Список покупок пуст!";
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                DefaultExt = ".txt",
                Title = "Сохранить список покупок",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    File.WriteAllLines(saveFileDialog.FileName, shoppingItems);
                    tbStatus.Text = $"Список сохранен в файл: {saveFileDialog.FileName}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла:\n{ex.Message}",
                        "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                Title = "Загрузить список покупок",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    shoppingItems.Clear();
                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            shoppingItems.Add(line);
                        }
                    }
                    tbStatus.Text = $"Загружено {shoppingItems.Count} продуктов из файла: {openFileDialog.FileName}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла:\n{ex.Message}",
                        "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}