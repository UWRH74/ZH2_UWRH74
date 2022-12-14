using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_UWRH74
{
    public partial class FormInstructors : Form
    {
        Models.Cuccmánycontext context = new();
        public FormInstructors()
        {
            InitializeComponent();

            listBox1.DataSource = (from x in context.Statuses
                                   select x).ToList();
            listBox1.DisplayMember = "Name";
            listBox2.DataSource = (from x in context.Employements
                                   select x).ToList();
            listBox2.DisplayMember = "Name";

            dvg_szure();
        }

        void dvg_szure()
        {
            var lek = (from x in context.Instructors
                       select x).ToList();
            instructorBindingSource.DataSource = lek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Models.Instructor r = new();

                r.Salutation = textBox1.Text;
                r.Name = textBox2.Text;
                r.StatusFk = ((Models.Status)listBox1.SelectedItem).StatusId;
                r.EmployementFk = ((Models.Employement)listBox2.SelectedItem).EmployementId;

                context.Instructors.Add(r);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dvg_szure();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private bool Check(string n)
        {
            Regex r = new Regex("^[a-zA-Z.]+$");
            return r.IsMatch(n);
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !Check(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Karakter hiba!");
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Mező nem lehet üres!");
            }
            else if (!Check(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Karakter hiba!");
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, "");
        }
    }
}
