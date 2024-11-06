using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    internal class TestLabel:Label
    {
        string number;
        public TestLabel(int x, int y, int width, int height,string str)
        { 
            Text =str;
            Location = new Point(x, y);
            Size = new Size(width, height);
        }

        /// <summary>
        /// label の文字更新関数
        /// </summary>
        /// <param name="str"></param>

        public void TextUpdate(string str)
        {
            number = number +str;
            Text = number;
        }


      
    }
}
