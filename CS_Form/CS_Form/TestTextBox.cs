using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CS_Form
{
    internal class TestTextBox : TextBox

    {
        TestButton _testButton;

        string number;
        public TestTextBox(int x, int y, int width, int height, string str)
        {
            Text = str;
            Location = new Point(x, y);
            Size = new Size(width, height);
        }
        public void TextUpdate(string str)
        {
            
            Text = str;
         
        }
        public string TextReplacement(string str)
        {
            string temp = Text;
            Text = str;
            return temp;
        }
    }
}
