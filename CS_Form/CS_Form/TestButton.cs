using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CS_Form
{
    internal class TestButton : Button
    {
        Form1 _form1;
        TestTextBox _textBox1;
        string number;
        char letter;
        
        public TestButton(Form1 form1, int x, int y, int width, int height, string numeric)
        {
            _form1 = form1;
            //if (numeric == 0) { letter = 'a'; }
            //if (numeric == 1) { letter = 'b'; }
            //if (numeric == 2) { letter = 'c'; }
            //if (numeric == 3) { letter = 'd'; }
            //if (numeric == 4) { letter = 'd'; }
            //if (numeric == 5) { letter = 'e'; }
            //if (numeric == 6) { letter = 'f'; }
            //if (numeric == 7) { letter = 'g'; }
            //if (numeric == 8) { letter = 'h'; }
            //if (numeric == 9) { letter = 'i'; }

            number = numeric;
            Click += OnClick;
            Text = numeric;
            Location = new Point(x,y);
            Size = new Size(width,height);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnClick(object sender, EventArgs e)
        {
            string t = _form1.ButtonLabelReplacement(Text);
            Text = t;   
            _form1.LabelTextUpdate(number);

        }
     




    }
}
