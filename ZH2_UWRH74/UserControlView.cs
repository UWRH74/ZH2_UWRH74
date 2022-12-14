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
    public partial class UserControlView : UserControl
    {
        Models.Cuccmánycontext context = new();
        public UserControlView()
        {
            InitializeComponent();

            listaInstruktor();
            listaTime();
            dvg_szure();

            courseBindingSource.DataSource = context.Courses.ToList();
            dayBindingSource.DataSource = context.Days.ToList();
            roomBindingSource.DataSource= context.Rooms.ToList();

        }

        void listaInstruktor()
        {
            listBox1.DataSource = (from x in context.Instructors
                                   where x.Name.Contains(textBox1.Text)
                                   select new classInstructor
                                   {
                                       Id = x.InstructorSk,
                                       Name = x.Name
                                   }).ToList();
            listBox1.DisplayMember = "Name";
        }

        void listaTime()
        {
            listBox2.DataSource = (from x in context.Times
                                   where x.Name.Contains(textBox2.Text)
                                   select x).ToList();
            listBox2.DisplayMember = "Name";
        }

        void dvg_szure()
        {
            var kiv1 = ((classInstructor)listBox1.SelectedItem).Id;
            var kiv2 = ((Models.Time)listBox2.SelectedItem).TimeId;

            var lek = from x in context.Lessons
                      where (kiv1 == x.InstructorFk && kiv2 == x.TimeFk)
                      select new classLesson
                      {
                          Course_id = x.CourseFk,
                          Day_id = x.DayFk,
                          Room_id = x.RoomFk
                      };
            dataGridView1.DataSource = lek.ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listaInstruktor();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            listaTime();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaTime();
            dvg_szure();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dvg_szure();
        }
    }

    public class classInstructor
    { 
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class classLesson
    { 
        public int? Course_id { get; set; }
        public byte? Day_id { get; set; }
        public int? Room_id { get; set; }
    }

}
