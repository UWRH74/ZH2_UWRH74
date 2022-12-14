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
    public partial class UserControlDelete : UserControl
    {
        Models.Cuccmánycontext context = new();
        public UserControlDelete()
        {
            InitializeComponent();

            dvg_szure();
            listakiiras();
        }

        void listakiiras()
        {
            listBox1.DataSource = (from x in context.Instructors
                                   select x).ToList();
            listBox1.DisplayMember = "Name";
        }

        void dvg_szure()
        {
            var lek = (from x in context.Instructors
                       select x).ToList();
            instructorBindingSource.DataSource = lek;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan törölni szeretné a kiválasztott elemet? Figyelem: Az Instruktorhoz tartozó összes óra is törlődni fog!", "Törlés", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var kiv = ((Models.Instructor)listBox1.SelectedItem).InstructorSk;

                var lek = (from x in context.Instructors
                           where kiv == x.InstructorSk
                           select x).FirstOrDefault();
                var tör = from x in context.Lessons
                          where x.InstructorFk == kiv
                          select x;

                while (tör.Count() > 0)
                {
                    context.Lessons.Remove(tör.FirstOrDefault());
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                context.Instructors.Remove(lek);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dvg_szure();
                listakiiras();

            }
        }
    }
}
