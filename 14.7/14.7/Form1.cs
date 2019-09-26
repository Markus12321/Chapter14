using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._7
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Resize_Form(object sender, EventArgs e)
        {
            int formWidth = this.Width;

            colorGroupBox.Left = sizeGroupBox.Left = (int)(formWidth * 0.03);
            colorGroupBox.Width = sizeGroupBox.Width = (int)(formWidth * 0.14);

            drawingPanel.Left = (int)(formWidth * 0.2);
            drawingPanel.Width = (int)(formWidth*0.73);
        }

    }
}
