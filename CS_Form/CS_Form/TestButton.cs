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
        int number;
        public TestButton(Form1 form1,int x,int y,int width, int height,int numeric)
        {
            _form1 = form1;
            number = numeric;
            Click += OnClick;
            Text =""+ numeric;
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
            _form1.LabelTextUpdate(""+number);
        }

    }
}
