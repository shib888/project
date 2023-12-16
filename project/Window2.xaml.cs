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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace project
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
       

      

      

        public Window2(int Score ,  string Name)
        {
            
            InitializeComponent();
            Points.Text =  Score.ToString();
            FinalName.Text = Name;

        }

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            MessageBoxResult result = MessageBox.Show("Do you want to restart the game?", "Restart Game", MessageBoxButton.YesNo, MessageBoxImage.Question);
           if(result == MessageBoxResult.Yes)
            {
                MainWindow newGame = new MainWindow();
                newGame.Show();
                this.Close();
                count++;

            }
           this.Close();
            
        }
    }
}
