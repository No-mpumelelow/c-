using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYMAPPLICTION
{
    public partial class program : Form
    {
        classess progr = new classess();
        DataHandler handler = new DataHandler();

        public program()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            progr.ProgramID1= int.Parse(txt_programid.Text);
            progr.Programname1 = txt_programname.Text;
            progr.Description1 = txt_programname.Text;
            progr.Instructor1 = txt_instructor.Text;
            progr.Schedule1 = txt_schedule.Text;
            progr.Capacity1 = int.Parse(txt_capacity.Text);
            progr.Duration1 =txt_capacity.Text;

            
        }

        private void BTN_UPDATES_Click(object sender, EventArgs e)
        {
            progr.ProgramID1 = int.Parse(txt_programid.Text);
            progr.Programname1 = txt_programname.Text;
            progr.Description1 = txt_programname.Text;
            progr.Instructor1 = txt_instructor.Text;
            progr.Schedule1 = txt_schedule.Text;
            progr.Capacity1 = int.Parse(txt_capacity.Text);
            progr.Duration1 = txt_capacity.Text;


        }
    }
}
