using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_38_04
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Group { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}, {Group}, {Gender}, {BirthDate.ToShortDateString()}";
        }
    }

    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();
        private const string DataFileName = "students.json";

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // Проверка заполнения полей
            if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtGroup.Text) ||
                dpBirthDate.SelectedDate == null)
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Создание нового студента
            var student = new Student
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                Group = txtGroup.Text,
                Gender = rbMale.IsChecked == true ? Gender.Male : Gender.Female,
                BirthDate = dpBirthDate.SelectedDate.Value
            };

            // Добавление в список и обновление ListBox
            students.Add(student);
            lbStudents.Items.Add(student.ToString());

            // Очистка полей ввода
            ClearFields();
        }

        private void ClearFields()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtGroup.Clear();
            rbMale.IsChecked = true;
            dpBirthDate.SelectedDate = null;
        }

        private void LoadData()
        {
            if (File.Exists(DataFileName))
            {
                try
                {
                    string json = File.ReadAllText(DataFileName);
                    students = JsonSerializer.Deserialize<List<Student>>(json);

                    lbStudents.Items.Clear();
                    foreach (var student in students)
                    {
                        lbStudents.Items.Add(student.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}",
                        "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(students, options);
                File.WriteAllText(DataFileName, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}