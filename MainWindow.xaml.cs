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
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void trybutt_Click(object sender, RoutedEventArgs e)
        {
            TextRange doc = new TextRange(RTB.Document.ContentStart, RTB.Document.ContentEnd);
            doc.Text += doc.Text;

        }
        //   private void SaveDocument()
        //    {
        //        SaveFileDialog sfd = new SaveFileDialog();
        //        sfd.Filter = "Text Files (*.txt)|*.txt|RichText Files (*.rtf)|*.rtf|XAML Files (*.xaml)|*.xaml|All files (*.*)|*.*";
        //        if (sfd.ShowDialog() == true)
        //        {
        //            TextRange doc = new TextRange(RTB.Document.ContentStart, RTB.Document.ContentEnd);
        //            using (FileStream fs = File.Create(sfd.FileName))
        //            {
        //                if (Path.GetExtension(sfd.FileName).ToLower() == ".rtf")
        //                    doc.Save(fs, DataFormats.Rtf);
        //                else if (Path.GetExtension(sfd.FileName).ToLower() == ".txt")
        //                    doc.Save(fs, DataFormats.Text);
        //                else
        //                    doc.Save(fs, DataFormats.Xaml);
        //            }
        //        }
        //}
        //private void OpenDocument()
        //{
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    ofd.Filter = "Text(*.txt*)|*.txt*";

        //    if (ofd.ShowDialog() == true)
        //    {
        //        TextRange doc = new TextRange(docBox.Document.ContentStart, docBox.Document.ContentEnd);
        //        using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
        //        {

        //            else if (Path.GetExtension(ofd.FileName).ToLower() == ".txt")
        //                doc.Load(fs, DataFormats.Text);
        //            else
        //                doc.Load(fs, DataFormats.Xaml);
        //        }
        //    }
        //}
    }
}
