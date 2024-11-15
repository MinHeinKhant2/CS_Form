using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        TestLabel _testLabel;
        TestTextBox _testTextBox;
        public Form1()
            
        {
            //int x = 0;
            //int y = 0;
            //int width = 100;
            //int height = 100;
            //    InitializeComponent();
            //for (int i = 0; i < 10; i++)
            //{
            //    x = (x % 3) * 100;
            //    y = (y / 3) * 100;

            //    TestButton testButton = new TestButton(x, y, width, height);
            //    Controls.Add(testButton);



            //}
            InitializeComponent();
            for (int i = 0; i < 10; i++)

            {
                TestButton testButton = new TestButton(this,(i % 3) * 100, (i / 3) * 100, 100, 100,i);
                Controls.Add(testButton);
            }
           
              _testLabel = new TestLabel(10, 400, 500, 100, "it's label");
            Controls.Add(_testLabel);
            _testTextBox = new TestTextBox(10, 500, 500, 100, "it's textbox");
            Controls.Add(_testTextBox);
            //Label label = new Label();
            //label.Location = new Point(0, 400);
            //label.Text = "label";
            //Controls.Add(label);


        }
        /// <summary>
        /// label の文字を更新する
        /// </summary>
        /// <param name="str"></param>
        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }
    }
}
