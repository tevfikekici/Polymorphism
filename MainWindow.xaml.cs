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

namespace Polymorphism
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            main_Class message = new main_Class();

            message.n_Message("Polymorphism example");
        }

        private void button_P_Click(object sender, RoutedEventArgs e)
        {
            sub_Class message = new sub_Class();

            message.p_Message("Polymorphism example");
        }
    }

    public class main_Class
    {
        public void n_Message(string content)
        {
            MessageBox.Show(content);
        }

        public virtual void p_Message(string content)
        {
            MessageBox.Show(content);
        }
    }

    public class sub_Class: main_Class
    {
        public void n_Message(string content)
        {
            MessageBox.Show(content.ToUpper());
        }

        public override void p_Message(string content)
        {
            MessageBox.Show(content.ToUpper());
        }
    }
}
