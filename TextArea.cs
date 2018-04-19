using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace TextEditor
{
    class TextArea
    {

        public string DocumentName;
        private string text;
        public string Text {

             get{
                return text;
                }
             set{
                text = value;
                textChanged(this, new EventArgs());
                } }
        public int CharCount { get { return Text.Count()-2;} set { } }
        public string SavePath = null;
        public event EventHandler textChanged;

        private RichTextBox RTB;

        public void  Set(RichTextBox rtb, string name)
        {
            RTB = rtb;
            DocumentName = name;
            Text = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd).Text;
        }

        public void Refresh() {
            Text =   new TextRange(RTB.Document.ContentStart, RTB.Document.ContentEnd).Text;
        }
    }
}
