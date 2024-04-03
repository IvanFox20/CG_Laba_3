using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CG_Laba_3
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void segment_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Segment_Form segmentForm = new Segment_Form();
            segmentForm.Show();
        }

        private void circle_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Circle_Form circleForm = new Circle_Form();
            circleForm.Show();
        }
    }
}
