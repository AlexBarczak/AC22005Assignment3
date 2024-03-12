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

        Button[] denominationButtons = new Button[8];

        enum State {
            EnteringAccountNumber,
            EnteringPin,
            LoggedIn,
            WithdrawingCash,
            CheckingBalance
        }
        
        string[] withdrawAmount = { "5", "10", "20", "50", "100", "200", "500", "1000"};

        private Account? currentAccount;

        State state = State.EnteringAccountNumber;
        string currentUserInput = "";

        public delegate void PrintDelegate(string output);

        private Main mainForm;

        public ATMForm(Main mainForm)
        {
            InitializeComponent();

            denominationButtons[0] = btn_left1;
            denominationButtons[1] = btn_left2;
            denominationButtons[2] = btn_left3;
            denominationButtons[3] = btn_left4;
            denominationButtons[4] = btn_right1;
            denominationButtons[5] = btn_right2;
            denominationButtons[6] = btn_right3;
            denominationButtons[7] = btn_right4;

            this.mainForm = mainForm;
            mainForm.ATMList.AddLast(this);
            mainForm.BeginInvoke(new PrintDelegate(mainForm.printToOutputWindow), Environment.CurrentManagedThreadId.ToString());
            UpdateDisplay();

            Application.Run(this);
        }

        public void UpdateDisplay(string errorMessage = "")
        {
            string[] lines = new string[8];

            foreach (Button button in denominationButtons)
            {
                button.Text = "";
            }

            switch (state)
            {
                case State.EnteringAccountNumber:
                    lines[2] = "Enter Your account number:";
                    lines[3] = currentUserInput;
                    break;
                case State.EnteringPin:
                    lines[2] = "Enter Your pin number:";
                    lines[3] = currentUserInput;
                    break;
                case State.LoggedIn:
                    lines[2] = "welcome, user";
                    lines[3] = "select an action:";
                    lines[4] = "B to check balance";
                    lines[5] = "W to withdraw money";
                    denominationButtons[0].Text = "B";
                    denominationButtons[1].Text = "W";
                    break;
                case State.WithdrawingCash:
                    for(int i = 0; i < denominationButtons.Length; i++){
                        denominationButtons[i].Text = withdrawAmount[i];
                    }
                    lines[2] = "please select the amount";
                    lines[3] = "to withdraw";
                    break;
                case State.CheckingBalance:
                    lines[2] = "Your current balance is: ";
                    lines[3] = currentAccount.getBalance().ToString();
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

            currentUserInput = "";
            UpdateDisplay();
            return;
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (currentUserInput == "")
            {
                return;
            }
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

        private void sideButtonsClicked(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Text;
            string errorMessage = "";

            if (buttonText == "")
            {
                return;
            }
            if(state == State.LoggedIn)
            {
                if(buttonText == "B")
                {
                    state = State.CheckingBalance;
                }
                else
                {
                    state = State.WithdrawingCash;
                }
            }else if(state == State.WithdrawingCash)
            {
                int amountToWithdraw = int.Parse(buttonText);
                bool transactionValid = currentAccount.decrementBalance(amountToWithdraw);
                if (!transactionValid)
                {
                    errorMessage = "not enough funds for transaction";
                }
                else
                {
                    state = State.LoggedIn;
                    errorMessage= "£" + buttonText + " withdrawn";
                }
            }
            UpdateDisplay(errorMessage);
        }
    }
}
