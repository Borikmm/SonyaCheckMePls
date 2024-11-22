using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Shapes;

namespace DemoExam.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public Partner Partner { get; set; }


        private List<TextBox> TextBoxes = new();

        public EditWindow(Partner partner = null)
        {
            InitializeComponent();
            AddInputBoxes();
            Partner = partner ?? new Partner();
            DataContext = this;
        }

        private void AddInputBoxes()
        {
            TextBoxes.Add(type_input);
            TextBoxes.Add(company_name_input);
            TextBoxes.Add(inn_input);
            TextBoxes.Add(director_name_input);
            TextBoxes.Add(phone_input);
            TextBoxes.Add(rating_input);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            CheckInput();
        }


        private void CheckInput()
        {
            bool countinue_ = true;
            foreach (TextBox box in TextBoxes)
            {
                if (box.Text == "")
                {
                    box.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0)); 
                    countinue_ = false;
                }
                else
                {
                    box.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
                }
            }

            if (countinue_)
            {
                DialogResult = true;
            }

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
