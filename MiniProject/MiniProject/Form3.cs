using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Form3 : Form
    {

        Student student = new Student();
        List<Student> students = new List<Student>();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            students = student.initList();

            students.ForEach(x =>
            {
                ListViewItem item = new ListViewItem(x.ID);
                item.SubItems.Add(x.MatricNo.ToString());
                item.SubItems.Add(x.Name);

                listView1.Items.Add(item);
            });

            
        }
    }
}
