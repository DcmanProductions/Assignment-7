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
using System.IO;

namespace Assignment_7___Cypher_Encoder_Decoder
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public static string Encrypt(string str, int n)
        {
            return string.Join("", str.Select(x => Encrypt(x, n)));
        }

        public static string Decrypt(string str, int n)
        {
            return string.Join("", str.Select(x => Decrypt(x, n)));
        }

        public static char Encrypt(char chr, int n)
        {
            int x = chr - 65;

            return (char)((65) + ((x + n) % 26));
        }

        public static char Decrypt(char chr, int n)
        {
            int x = chr - 65;

            return (char)((65) + ((x - n) % 26));
        }

        private void Encrypt_Click(object sender, RoutedEventArgs e)
        {
            EncryptionText.Text = Encrypt(EncryptionText.Text.ToUpper(), 5);
        }

        private void DecryptButton_Click(object sender, RoutedEventArgs e)
        {
            EncryptionText.Text = Decrypt(EncryptionText.Text.ToUpper(), 5);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                BufferedStream bs = new BufferedStream(fs);
                StreamReader sr = new StreamReader(bs);
                string line = "";
                while((line = sr.ReadLine()) != null)
                {
                    EncryptionText.Text = line;
                }
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();


            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite);
                BufferedStream bs = new BufferedStream(fs);
                StreamWriter sr = new StreamWriter(bs);
                sr.WriteLine(EncryptionText.Text);
            }
        }
    }
}
