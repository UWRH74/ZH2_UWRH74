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
    public partial class FormLesson : Form
    {
        Models.Cuccmánycontext context = new();
        public FormLesson()
        {
            InitializeComponent();

            listBox1.DataSource = (from x in context.Courses
                                   select x).ToList();
            listBox1.DisplayMember = "Name";
            listBox2.DataSource = (from x in context.Instructors
                                   select x).ToList();
            listBox2.DisplayMember = "Name";
            listBox3.DataSource = (from x in context.Days
                                   select x).ToList();
            listBox3.DisplayMember = "Name";
            listBox4.DataSource = (from x in context.Times
                                   select x).ToList();
            listBox4.DisplayMember = "Name";
            listBox5.DataSource = (from x in context.Rooms
                                   select x).ToList();
            listBox5.DisplayMember = "Name";

            dvg_szure();
        }

        void dvg_szure()
        {
            var lek = (from x in context.Lessons
                       select x).ToList();
            lessonBindingSource.DataSource = lek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Models.Lesson r = new();

            r.CourseFk = ((Models.Course)listBox1.SelectedItem).CourseSk;
            r.InstructorFk = ((Models.Instructor)listBox2.SelectedItem).InstructorSk;
            r.DayFk = ((Models.Day)listBox3.SelectedItem).DayId;
            r.TimeFk = ((Models.Time)listBox4.SelectedItem).TimeId;
            r.RoomFk = ((Models.Room)listBox5.SelectedItem).RoomSk;

            context.Lessons.Add(r);
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
}
