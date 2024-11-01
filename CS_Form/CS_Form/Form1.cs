using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
            
        {
            //int x = 0;
            //int y = 0;
            //int width = 100;
            //int height = 100;
            //for (int i = 0; i < 10; i++)
            //{
            //    x = (x % 3) * 100;
            //    y = (y / 3) * 100;
            //    InitializeComponent();
            //    TestButton testButton = new TestButton(x, y, width, height);
            //    Controls.Add(testButton);



            //}
                InitializeComponent();
            for (int i = 0; i < 10; i++)

            {
                TestButton testButton = new TestButton((i % 3) * 100, (i / 3) * 100, 100, 100,i);
                Controls.Add(testButton);
            }

        }
    }
}
