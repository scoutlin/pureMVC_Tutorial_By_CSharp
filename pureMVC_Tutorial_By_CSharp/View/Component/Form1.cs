using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pureMVC_Tutorial_By_CSharp
{
    public partial class Form1 : Form
    {
        public EventHandler EventHandler_button1_Click;

        public TextBox GetTextBox_Path
        {
            get
            {
                return textBox1;
            }
        }

        public RichTextBox GetRichTextBox_Content
        {
            get
            {
                return richTextBox1;
            }
        }

        public Button GetButton_Read
        {
            get
            {
                return button1;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(EventHandler_button1_Click != null)
            {
                EventHandler_button1_Click(this, e);
            }
        }
    }
}
