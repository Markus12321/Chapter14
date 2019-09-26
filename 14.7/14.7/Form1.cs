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
        public bool CanDraw { get; set; } = false;
        public Color Color { get; set; } = Color.Black;
        public int DrawingSize { get; set; } = 4;

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

            int effectiveFormHeight = this.ClientSize.Height;

            drawingPanel.Top = (int)(effectiveFormHeight * 0.05);
            drawingPanel.Height = (int)(effectiveFormHeight * 0.9);
            
    
        }


        private void MouseDownDraw(object sender, MouseEventArgs e)
        {
            CanDraw = true;
        }

        private void MouseUpNoDraw(object sender, MouseEventArgs e)
        {
            CanDraw = false;
        }

        private void Draw(object sender, MouseEventArgs e)
        {
            if (CanDraw)
            {
                using (Graphics graphics = (sender as Control).CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(Color), e.X, e.Y, DrawingSize, DrawingSize);
                }
            }
        }

        private void ColorCheckChanged(object sender, EventArgs e)
        {
            if(sender == redButton)
            {
                Color = Color.Red;
            }else if(sender == blueButton){
                Color = Color.Blue;
            }else if(sender == greenButton)
            {
                Color = Color.Green;
            }else if(sender == blackButton)
            {
                Color = Color.Black;
            }
        }

      

        private void SizeCheckChanged(object sender, EventArgs e)
        {
            if(sender == smallButton)
            {
                DrawingSize = 4;
            }else if(sender == mediumButton)
            {
                DrawingSize = 16;
            }else if(sender == largeButton)
            {
                DrawingSize = 32;
            }
        }
    }
}
