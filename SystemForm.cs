using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamCollege_SystemApp.DAL;
using static ExamCollege_SystemApp.Config.Services;

namespace ExamCollege_SystemApp
{
    public partial class SystemForm : Form
    {
        DBContext db;
        public SystemForm()
        {
            InitializeComponent();
            db = new DBContext(GetConnectionString());
        }

        private void get_all_courses(object sender, EventArgs e)
        {
            DataTable tb = db.ExecuteQuery("select * from Courses", null);
            table.DataSource = tb;
        }

        private void how_much_students(object sender, EventArgs e)
        {
            DataTable tb = db.ExecuteQuery(@"select c.id,c.Name, c.Starts , count(*) as quant from Enroll e
join Courses c on e.CourseID = c.ID
group by c.id, c.Name, c.Starts", null);
            table.DataSource = tb;
        }

        private void sum_for_lecturers(object sender, EventArgs e)
        {
            DataTable tb = db.ExecuteQuery(@"
select c.ID, c.Name, c.starts, sum(t.Hours * l.Rate) from Courses c
join Enroll e on c.ID = e.CourseID
join Topics t on c.ID = t.CourseID
join Lecturer l on t.LecturerID = l.ID
group by c.ID, c.name, c.starts", null);
            table.DataSource = tb;
        }

        private void all_payments(object sender, EventArgs e)
        {
            DataTable tb = db.ExecuteQuery(@"
select s.Name, p.Sum, p.Time from Payments p
join Students s on p.StudentID = s.id", null);
            table.DataSource = tb;
        }

        private void all_students(object sender, EventArgs e)
        {
            DataTable tb = db.ExecuteQuery("select * from Students", null);
            table.DataSource = tb;
        }
    }
}
