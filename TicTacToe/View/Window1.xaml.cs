using System;
using System.Windows;
using System.Windows.Controls;

namespace GUI
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private string namePlayerOne;
        private string namePlayerTwo;
        public Boolean formAccepted =false;

        public Window1()
        {
            InitializeComponent();
        }

        private void InitiateButton_Click (Object sender, RoutedEventArgs e)
        {
            if (namePlayerOne != null && namePlayerTwo != null && namePlayerOne!=namePlayerTwo)
            {
                this.formAccepted = true;
                this.Hide();
            } else
            {
                MessageBox.Show("Ingrese los nombres correctamente");
            }
        }

        private void TextBoxPlayerOne (object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            this.namePlayerOne = textBox.Text;
        }

        private void TextBoxPlayerTwo (object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            this.namePlayerTwo = textBox.Text;
        }

        public string[] GetNames ()
        {
            string[] names = new string[2];
            names[0] = this.namePlayerOne;
            names[1] = this.namePlayerTwo;

            return names;
        }

    }
}
