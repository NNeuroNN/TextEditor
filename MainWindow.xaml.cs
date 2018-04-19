using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace TextEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextAreaInit();
        }
        private TextArea Text;
        bool access = false;
        private void TextAreaInit() {
            
            Text = new TextArea();
            Text.textChanged += TextChanged;
            Text.Set(RTB, "test");
            access = true;
        }

        void TextChanged(object sender, EventArgs e) {
            InfoLabel.Content = " Символов:"+Text.CharCount.ToString();   
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            TextRange doc = new TextRange(RTB.Document.ContentStart, RTB.Document.ContentEnd);
            SaveDocument(doc.Text);
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            WriteText();

        }


        private void SaveDocument(string text)
        {
           
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt";
            if (sfd.ShowDialog() == true)
            {
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.Write(text);
                    sw.Close();
                    Text.SavePath = sfd.FileName;
                }
            }
                
            
          
        }
        private void SaveDefault(string text) {
            if (Text.SavePath == null)
            {
                SaveDocument(text);
            }
            else
            {
                StreamWriter sw = new StreamWriter(Text.SavePath);
                sw.Write(text);
                sw.Close();
            }
        }

        private void WriteText()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text(*.txt*)|*.txt*";

            if (ofd.ShowDialog() == true)
            {
                StreamReader strread = new StreamReader(ofd.FileName);
                TextRange doc = new TextRange(RTB.Document.ContentStart, RTB.Document.ContentEnd);
                doc.Text = strread.ReadToEnd();
                strread.Close();
            }
        }

        private void RTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (access)
                Text.Refresh();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void SaveDefault(object sender, RoutedEventArgs e)
        {
            TextRange doc = new TextRange(RTB.Document.ContentStart, RTB.Document.ContentEnd);
            SaveDefault(doc.Text);
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            try { RTB.FontSize = int.Parse(SizeBox.Text); }
            catch (Exception) { }
        }
    }
}

