using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AC22005Assignment3
{
    public partial class ATMForm : Form
    {
        public delegate void PrintDelegate(string output);

        private Main mainForm;

        public ATMForm(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            mainForm.ATMList.AddLast(this);
            mainForm.BeginInvoke(new PrintDelegate(mainForm.printToOutputWindow), Thread.CurrentThread.ManagedThreadId.ToString());
            Application.Run(this);
        }
    }
}
