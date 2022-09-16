using LoggerUtilities;
using LoggerUtilities.Logger;
using LoggerUtilities.Message;

namespace Logger
{
    public partial class Form1 : Form
    {
        private LoggerServer LoggerServer;
        private List<string> Applications = new List<string>();
        private List<LoggerUtilities.Message.Message> messages = new List<LoggerUtilities.Message.Message>();
        MessageType currentFilter = MessageType.MessageType_Unset;
        private string currentApplication = null;

        // Play button icons
        private Bitmap PlayButtonRed = null;
        private Bitmap PlayButtonGreen = null;

        public Form1()
        {
            InitializeComponent();

            // Prepare GUI
            foreach (string s in LoggerUtilities.Message.Message.GetMessagesTypesAsStrings())
            {
                comboTypesFilter.Items.Add(s);
            }
            btnControlTimer.Enabled = false;

            PlayButtonRed = new Bitmap("res/play-red.png");
            PlayButtonGreen = new Bitmap("res/play-green.png");

            LoggerServer = new LoggerServer(10020);
            LoggerServer.Run();
        }

        private void UpdateGui()
        {
            listBox1.Items.Clear();
            listApplicazioni.Items.Clear();

            int numInfo = 0;
            int numWarnings = 0;
            int numErrors = 0;
            int numPositive = 0;

            foreach (LoggerUtilities.Message.Message message in messages)
            {
                if (!Applications.Contains(message.Application))
                {
                    if (currentApplication == null)
                    {
                        currentApplication = message.Application;
                        btnControlTimer.Enabled = true;
                    }

                    Applications.Add(message.Application);
                }

                if (((currentFilter == message.MessageType) || (currentFilter == MessageType.MessageType_Unset)) &&
                    message.Application == currentApplication)
                {
                    listBox1.Items.Add(message.ToString());

                    if (message.MessageType == MessageType.MessageType_Info) numInfo++;
                    else if (message.MessageType == MessageType.MessageType_Warning) numWarnings++;
                    else if (message.MessageType == MessageType.MessageType_Error) numErrors++;
                    else if (message.MessageType == MessageType.MessageType_Positive) numPositive++;
                }
            }
            if (listBox1.Items.Count == 0) return;

            lblInfo.Text = ((numInfo * 100) / listBox1.Items.Count).ToString() + "%";
            lblWarings.Text = ((numWarnings * 100) / listBox1.Items.Count).ToString() + "%";
            lblErrors.Text = ((numErrors * 100) / listBox1.Items.Count).ToString() + "%";
            lblPositive.Text = ((numPositive * 100) / listBox1.Items.Count).ToString() + "%";
        }

        private void timerMessages_Tick(object sender, EventArgs e)
        {
            messages = LoggerServer.GetMessages();

            UpdateGui();

            label1.Text = "Applicazioni Collegate (" + Applications.Count + ")";
            foreach (string s in Applications)
            {
                listApplicazioni.Items.Add(s);
            }
        }

        private void listApplicazioni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listApplicazioni.SelectedItem != null)
                currentApplication = listApplicazioni.SelectedItem as string;

            UpdateGui();
            foreach (string s in Applications)
            {
                listApplicazioni.Items.Add(s);
            }
        }

        private void tXTFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentApplication != null)
            {
                timerMessages.Stop();
                listApplicazioni.SelectedIndex = listApplicazioni.Items.IndexOf(currentApplication);

                // Open file dialog
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Save";
                dialog.Filter = "Txt File (*.txt)|*.txt|All files (*.*)|*.*";
                dialog.ShowDialog();
                string f = dialog.FileName;

                TXTLogger logger = new TXTLogger(f, messages);
                logger.Use();

                timerMessages.Start();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoggerServer.Close();
        }

        private void btnControlTimer_Click(object sender, EventArgs e)
        {
            if (currentApplication == null) return;
            if (timerMessages.Enabled)
            {
                btnControlTimer.Image = PlayButtonGreen;
                btnControlTimer.Text = "Play";
                timerMessages.Stop();
            }
            else
            {
                btnControlTimer.Image = PlayButtonRed;
                btnControlTimer.Text = "Pause";
                timerMessages.Start();
            }
        }

        private void comboTypesFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (currentApplication != null && comboTypesFilter.SelectedIndex != -1)
            {
                timerMessages.Stop();

                currentFilter = MessageType.MessageType_Unset;
                try
                {
                    currentFilter = (MessageType)comboTypesFilter.SelectedIndex;
                }
                catch { }

                listBox1.Items.Clear();

                foreach (LoggerUtilities.Message.Message message in messages)
                {
                    if ((currentFilter == message.MessageType) || (currentFilter == MessageType.MessageType_Unset))
                    {
                        listBox1.Items.Add(message.ToString());
                    }
                }

                timerMessages.Start();
            }
        }
    }
}
