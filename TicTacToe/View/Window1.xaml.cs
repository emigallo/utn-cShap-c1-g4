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
        public Boolean FormAccepted { get; set; }

        public Window1()
        {
            InitializeComponent();
            this.FormAccepted = false;
        }

        private void InitiateButton_Click (Object sender, RoutedEventArgs e)
        {
            if (namePlayerOne == null || namePlayerTwo == null)
            {
                MessageBox.Show("Ingrese los nombres correctamente");
            } else if(namePlayerOne == namePlayerTwo)
            {
                MessageBox.Show("Ingrese un nombre diferente");
            }
            else
            {
                this.FormAccepted = true;
                this.Hide();
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

        public void ExitGame_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
