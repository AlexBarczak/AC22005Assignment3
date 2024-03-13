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
        /**
        The buttons down either side of the atm display
        **/
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
            sendMessageToComputer(Environment.CurrentManagedThreadId.ToString());
            UpdateDisplay();

            Application.Run(this);
        }

        private void sendMessageToComputer(string message)
        {
            mainForm.BeginInvoke(new PrintDelegate(mainForm.printToOutputWindow), message);
        }

        public void UpdateDisplay(string errorMessage = "")
        {
            string[] lines = new string[8];

            foreach (Button button in denominationButtons) //Setting each button text to blank string
            {
                button.Text = "";
            }

            switch (state) //Depending what the state of the ATM is, sets the respective button and prompt.
            {
                case State.EnteringAccountNumber: //Entering account number
                    lines[2] = "Enter Your account number:";
                    lines[3] = currentUserInput;
                    break;
                case State.EnteringPin: //entering card pin number
                    lines[2] = "Enter Your pin number:";
                    lines[3] = currentUserInput;
                    break;
                case State.LoggedIn: //main home screen showing all availiable actions
                    lines[2] = "welcome, user";
                    lines[3] = "select an action:";
                    lines[4] = "B to check balance";
                    lines[5] = "W to withdraw money";
                    denominationButtons[0].Text = "B";
                    denominationButtons[1].Text = "W";
                    break;
                case State.WithdrawingCash: //using the amounts defined at the top of the program, sets the ammounts to withdraw selectable by the user. 
                    for(int i = 0; i < denominationButtons.Length; i++){
                        denominationButtons[i].Text = withdrawAmount[i];
                    }
                    lines[2] = "please select the amount";
                    lines[3] = "to withdraw";
                    break;
                case State.CheckingBalance: //displays ballance
                    lines[2] = "Your current balance is: ";
                    lines[3] = currentAccount.getBalance().ToString();
                    break;
            }

            lines[7] = errorMessage;

            displayBox.Lines = lines;
        }

        private void NumpadClicked(object sender, EventArgs e)
        /**
        depending on state, will either set entry length of 6 ot 4 for account number and pin respectivly.
        will exit if input length is greater than allowed length.
        **/
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
        /**
        If on or before logged in page, then exits back to enter account number. Otherwise will go back to the logged in page.
        **/
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
                    //entering the account number, if it matches an account then it will ask for pin. Otherwise, displays error message.
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
                    // entering pin number, if correct then goes to logged in page. Otherwise, displays error message.
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
        /**
        The process of clicking a side button. When the program is on the logged in page, if the button is labelled with "B" then the program will display the balance of that account.
        Otherwise the program will take the user to the withdraw cash screen.
        When the program is on the withdraw cash then each button will ask to withdraw it's designated amount. 
        **/
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
