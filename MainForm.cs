using System.Collections.Generic;

namespace AC22005Assignment3
{
    public partial class Main : Form
    {
        public delegate void CloseDelegate();

        public LinkedList<ATMForm> ATMList = new LinkedList<ATMForm>();

        private Account[] ac = new Account[3];
        private bool raceConditionFixed = false;

        private Queue<string> OutputWindowBuffer = new Queue<string>();
        const int OutputWindowCharWidth = 42;
        const int OutputWindowCharHeight = 14;

        public bool raceConditionIsFixed()
        {
            return raceConditionFixed;
        }

        private void UpdateOutputWindow()
        {
            string windowString = "";
            while (OutputWindowBuffer.Count > OutputWindowCharHeight)
            {
                OutputWindowBuffer.Dequeue();
            }

            string[] strings = OutputWindowBuffer.ToArray();

            for (int i = 0; i < strings.Length; i++)
            {
                windowString += strings[i] + '\n';
            }

            OutputWindow.Text = windowString;
        }

        public void printToOutputWindow(string output)
        {
            output = new string(output.Chunk(OutputWindowCharWidth).First());
            OutputWindowBuffer.Enqueue(output);
            UpdateOutputWindow();
        }

        public Main()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Main_FormClosing);

            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);
        }

        private void btn_CreateATM_Click(object sender, EventArgs e)
        {
            Thread newATMThread = new Thread(new ThreadStart(CreateATM));
            newATMThread.Start();
        }

        private void CreateATM()
        {
            ATMForm newATM = new ATMForm(this);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (ATMForm ATM in ATMList)
            {
                if (!ATM.Created) continue;
                ATM.BeginInvoke(new CloseDelegate(ATM.Close));
            }
        }

        public Account? findAccount(int AccountNumber)
        {
            for (int i = 0; i < this.ac.Length; i++)
            {
                if (ac[i].getAccountNum() == AccountNumber)
                {
                    return ac[i];
                }
            }

            return null;
        }

        private void btn_raceConditionToggle_Click(object sender, EventArgs e)
        {
            if (raceConditionFixed)
            {
                raceConditionFixed = false;
                printToOutputWindow("race condition fix disabled");
                btn_raceConditionToggle.Text = "enable race condition fix";
            }
            else
            {
                raceConditionFixed = true;
                printToOutputWindow("race condition fix enabled");
                btn_raceConditionToggle.Text = "disable race condition fix";
            }
        }
    }
}