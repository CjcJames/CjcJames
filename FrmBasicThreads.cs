using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBasicThread
{
    public partial class Form1 : Form
    {
        private Thread ThreadA, ThreadB;
        
        MyThreadClass classthread = new MyThreadClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void btbRun_Click(object sender, EventArgs e)
        {
            ThreadA = new Thread(MyThreadClass.Thread1);
            ThreadA.Name = "Thread A";
            ThreadB = new Thread(MyThreadClass.Thread1);
            ThreadB.Name = "Thread B";
            ThreadA.Start();
            ThreadB.Start();

            lblThreadStats.Text = "-Threads is Running-";

            ThreadA.Join();
            ThreadB.Join();

            lblThreadStats.Text = "-End of Threads-";

        }
    }
}
