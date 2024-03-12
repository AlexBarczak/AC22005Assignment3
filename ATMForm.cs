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

        private Account currentAccount;

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

        public void UpdateDisplay(string errorMessage = "")
        {
            string[] lines = new string[8];

            switch (state)
            {
                case State.EnteringAccountNumber:
                    lines[3] = "Enter Your account number:";
                    lines[4] = currentUserInput;
                    break;
                case State.EnteringPin:
                    lines[3] = "Enter Your pin number:";
                    lines[4] = currentUserInput;
                    break;
                case State.LoggedIn:
                    lines[3] = "welcome, user";
                    lines[4] = "select an action";
                    break;
                case State.WithdrawingCash:
                    break;
                case State.CheckingBalance:
                    break;
            }

            lines[7] = errorMessage;

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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (currentUserInput != "")
            {
                currentUserInput = "";
                UpdateDisplay();
                return;
            }

            switch (state)
            {
                case State.EnteringAccountNumber:
                    break;
                case State.EnteringPin:
                    state = State.EnteringAccountNumber;
                    break;
                case State.LoggedIn:
                    state = State.EnteringAccountNumber;
                    break;
                case State.WithdrawingCash:
                    state = State.LoggedIn;
                    break;
                case State.CheckingBalance:
                    state = State.LoggedIn;
                    break;
            }

            UpdateDisplay();
            return;
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {

            string errorMessage = "";

            switch (state)
            {
                case State.EnteringAccountNumber:

                    currentAccount = mainForm.findAccount(int.Parse(currentUserInput));
                    if (currentAccount == null)
                    { 
                        errorMessage = "invalid account number";
                    }
                    else
                    {
                        state = State.EnteringPin;
                    }
                    break;

                case State.EnteringPin:

                    if (currentAccount.checkPin(int.Parse(currentUserInput)))
                    {
                        state = State.LoggedIn;
                    }
                    else
                    {
                        errorMessage = "incorrect pin";
                    }

                    break;
            }

            currentUserInput = "";
            UpdateDisplay(errorMessage);
            return;
        }
    }
}
