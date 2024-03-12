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

        enum State {
            EnteringAccountNumber,
            EnteringPin,
            LoggedIn,
            WithdrawingCash,
            CheckingBalance
        }

        State state = State.EnteringAccountNumber;
        string currentUserInput = "";

        public delegate void PrintDelegate(string output);

        private Main mainForm;

        public ATMForm(Main mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            mainForm.ATMList.AddLast(this);
            mainForm.BeginInvoke(new PrintDelegate(mainForm.printToOutputWindow), Thread.CurrentThread.ManagedThreadId.ToString());
            UpdateDisplay();

            Application.Run(this);
        }

        public void UpdateDisplay()
        {
            string[] lines = new string[8];

            switch (state)
            {
                case State.EnteringAccountNumber:
                    lines[3] = "Enter Your account number:";
                    lines[4] = currentUserInput;
                    break;
                case State.EnteringPin:
                    break;
                case State.LoggedIn:
                    break;
                case State.WithdrawingCash:
                    break;
                case State.CheckingBalance:
                    break;
            }

            displayBox.Lines = lines;
        }

        private void NumpadClicked(object sender, EventArgs e)
        {
            string input = ((Button)sender).Text;
            int maxInputLength = 0;
            if (state == State.EnteringAccountNumber)
            {
                maxInputLength = 6;
            } else if (state == State.EnteringPin)
            {
                maxInputLength = 4;
            }
            
            if (input.Length + currentUserInput.Length > maxInputLength)
            {
                return;
            }

            currentUserInput += input;
            UpdateDisplay();
        }
    }
}
