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
        int number;
        public TestButton(int x,int y,int width, int height,int numeric)
        {
            number = numeric;
            Click += OnClick;
            Text =""+ numeric;
            Location = new Point(x,y);
            Size = new Size(width,height);
        }
        public void OnClick(object sender, EventArgs e)
        {
            MessageBox.Show(""+number);
        }

    }
}
