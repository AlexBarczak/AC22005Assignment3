using System.Collections.Generic;

namespace AC22005Assignment3
{
    public partial class Main : Form
    {
        Queue<string> OutputWindowBuffer = new Queue<string>();
        const int OutputWindowCharWidth = 42;
        const int OutputWindowCharHeight = 14;

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
        }

        private void btn_CreateATM_Click(object sender, EventArgs e)
        {

        }
    }
}