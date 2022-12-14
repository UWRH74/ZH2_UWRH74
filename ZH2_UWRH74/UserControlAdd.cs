using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_UWRH74
{
    public partial class UserControlAdd : UserControl
    {
        public UserControlAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInstructors f = new();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLesson f = new();
            f.ShowDialog();
        }
    }
}
