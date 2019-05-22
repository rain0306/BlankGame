using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlankGame_190521
{
    public partial class Form1 : Form
    {
        private int cont = 0;
        Task task;
        Task task2;
        public Form1()
        {
            InitializeComponent();
            Thread.Sleep(1000);
            //loop();
        }

        private void loop()
        {
            if (this.count.InvokeRequired)
            {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        count.Text = cont++.ToString();
                    });
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (task == null)
            {
                task = Task.Run(() =>
                {
                    while (true)
                    {
                        loop();
                    }

                });
            }

        }
    }

}
