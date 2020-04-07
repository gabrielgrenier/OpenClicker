using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Reflection;
using System.Drawing.Text;

namespace OpenAutoClick
{
    public partial class MainForm : Form {
        //keyboard hook
        private LowLevelKeyboardListener _listener;

        //Mouse actions
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        //random mouse position
        private Boolean randomMousePosition;

        //start & end key
        String startKey;
        String endKey;
        Boolean recordStartKey;
        Boolean recordEndKey;
        

        //cursor
        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string filename);

        //min time and max time
        private int minTime;
        private int maxTime;

        //running thread
        private Thread runningThread;

        //getters
        private int getMinTime() {
            return this.minTime;
        }
        private int getMaxTime() {
            return this.maxTime;
        }
        private Thread getRunningThread() {
            return this.runningThread;
        }
        private Boolean getRandomMousePosition() {
            return this.randomMousePosition;
        }
        private String getStartKey() {
            return this.startKey;
        }
        private String getEndKey() {
            return this.endKey;
        }
        private Boolean getRecordStartKey() {
            return this.recordStartKey;
        }
        private Boolean getRecordEndKey() {
            return this.recordEndKey;
        }

        //setters
        private void setMinTime(int minTime) {
            this.minTime = minTime;
        }
        private void setMaxTime(int maxTime) {
            this.maxTime = maxTime;
        }
        private void setRunningThread() {
            runningThread = new Thread(() => {
                Boolean firstClick = true;

                //original position of the mouse
                int xOg = 0;
                int yOg = 0;

                while (true) {
                    //if it's the first click, get the original position of the mouse
                    if (firstClick) {
                        xOg = Cursor.Position.X;
                        yOg = Cursor.Position.Y;
                        firstClick = false;
                    }

                    //generate a random number of ms 
                    Random rnd = new Random();
                    int sleepTime = rnd.Next(getMinTime(), getMaxTime());
                    Thread.Sleep(sleepTime);

                    //if randomMousePosition is checked
                    int xIncrement = 0;
                    int yIncrement = 0;
                    if (checkRandomMouse.Checked) {
                        Random rndMouse = new Random();
                        xIncrement = rndMouse.Next(-(int)numMaxDistance.Value, (int)numMaxDistance.Value);
                        yIncrement = rndMouse.Next(-(int)numMaxDistance.Value, (int)numMaxDistance.Value);

                        int posX = xOg + xIncrement;
                        int posY = yOg + yIncrement;
                        Cursor.Position = new Point(posX, posY);
                    }

                    //mouse clicks
                    uint X = (uint)Cursor.Position.X;
                    uint Y = (uint)Cursor.Position.Y;
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }
            });
        }
        private void setRandomMousePosition(Boolean randomMousePosition) {
            this.randomMousePosition = randomMousePosition;
        }
        private void setStartKey(String startKey) {
            this.startKey = startKey;
        }
        private void setEndKey(String endKey) {
            this.endKey = endKey;
        }
        private void setRecordStartKey(Boolean recordStartKey) {
            this.recordStartKey = recordStartKey;
        }
        private void setRecordEndKey(Boolean recordEndKey) {
            this.recordEndKey = recordEndKey;
        }

        public MainForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
            _listener = new LowLevelKeyboardListener();
            _listener.OnKeyPressed += _listener_OnKeyPressed;
            _listener.HookKeyboard();

            //Default key
            startKey = "Insert";
            endKey = "Delete";

            //cursor
            Cursor mycursor = new Cursor(Cursor.Current.Handle);
            IntPtr colorcursorhandle = LoadCursorFromFile(Directory.GetCurrentDirectory() + "\\DScim.cur");
            mycursor.GetType().InvokeMember("handle", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetField, null, mycursor, new object[] { colorcursorhandle }); 
            this.Cursor = mycursor;

            //resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //adding font
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Directory.GetCurrentDirectory() + "\\runescape_uf.ttf");

            //set font to labels
            labAQP.Font = new Font(pfc.Families[0], labAQP.Font.Size);
            labMaxDistance.Font = new Font(pfc.Families[0], labMaxDistance.Font.Size);
            labMaxTime.Font = new Font(pfc.Families[0], labMaxTime.Font.Size);
            labMinTime.Font = new Font(pfc.Families[0], labMinTime.Font.Size);
            labTitle.Font = new Font(pfc.Families[0], labTitle.Font.Size);
            labW.Font = new Font(pfc.Families[0], labW.Font.Size);
            labPressStartKey.Font = new Font(pfc.Families[0], labPressStartKey.Font.Size);
            labPressEndKey.Font = new Font(pfc.Families[0], labPressEndKey.Font.Size);
            checkRandomMouse.Font = new Font(pfc.Families[0], checkRandomMouse.Font.Size);

            //disable txt
            txtStartKey.Enabled = false;
            txtEndKey.Enabled = false;

            //hide elements
            labPressStartKey.Visible = false;
            labPressEndKey.Visible = false;
            labMaxDistance.Visible = false;
            numMaxDistance.Visible = false;

            //key recording
            recordStartKey = false;
            recordEndKey = false;
        }

        void _listener_OnKeyPressed(object sender, KeyPressedArgs e) {
            //if the user is not setting up his keybinds
            if(!recordStartKey && !recordEndKey) { 
                if (e.KeyPressed.ToString().ToUpper() == startKey.ToUpper()) {
                    if(runningThread == null){ 
                        setRunningThread();
                        runningThread.Start();
                    }
                    else if(runningThread!=null && !runningThread.IsAlive) {
                        setRunningThread();
                        runningThread.Start();
                    }
                }

                if (e.KeyPressed.ToString().ToUpper() == endKey.ToUpper() && runningThread != null) {
                    runningThread.Abort();
                }
            }
            else {
                if (recordStartKey) {
                    if (e.KeyPressed.ToString() != endKey) {
                        txtStartKey.Text = e.KeyPressed.ToString();
                        setStartKey(e.KeyPressed.ToString());
                        btnSetStartKey.Enabled = true;
                        btnSetEndKey.Enabled = true;
                        labPressStartKey.Visible = false;

                        setRecordStartKey(false);
                    }
                    else {
                        MessageBox.Show("The Start key cannot be the same as the End key.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else {
                    if (e.KeyPressed.ToString() != startKey) {
                        txtEndKey.Text = e.KeyPressed.ToString();
                        btnSetStartKey.Enabled = true;
                        btnSetEndKey.Enabled = true;
                        labPressEndKey.Visible = false;

                        setEndKey(e.KeyPressed.ToString());
                        setRecordEndKey(false);
                    }
                    else {
                        MessageBox.Show("The End key cannot be the same as the Start key.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private void btnStart_Click(object sender, EventArgs e){
            setRunningThread();
            runningThread.Start();
        }


        private void btnStop_Click(object sender, EventArgs e) {
            runningThread.Abort();
        }

        private void numMinTime_ValueChanged(object sender, EventArgs e) {
            setMinTime((int)numMinTime.Value);
            if ((int)numMinTime.Value >= (int)numMaxTime.Value) {
                setMaxTime((int)numMinTime.Value + 5);
                numMaxTime.Minimum = getMinTime() + 5;
            }
        }

        private void numMaxTime_ValueChanged(object sender, EventArgs e) {
            if((int)numMaxTime.Value > (getMinTime()+5) && (int)numMaxTime.Value > getMaxTime()) {
                setMaxTime((int)numMaxTime.Value);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            _listener.UnHookKeyboard();
            if (runningThread != null) {
                runningThread.Abort();
            }
        }

        private void checkRandomMouse_CheckedChanged(object sender, EventArgs e) {
            if (checkRandomMouse.Checked) {
                setRandomMousePosition(true);
                labMaxDistance.Visible = true;
                numMaxDistance.Visible = true;
            }
            else {
                setRandomMousePosition(false);
                labMaxDistance.Visible = false;
                numMaxDistance.Visible = false;
            }
        }

        private void txtStartKey_TextChanged(object sender, EventArgs e) {
            setStartKey(txtStartKey.Text);
        }

        private void txtEndKey_TextChanged(object sender, EventArgs e) {
            setEndKey(txtEndKey.Text);
        }

        private void btnSetStartKey_Click(object sender, EventArgs e) {
            //disable btns
            btnSetStartKey.Enabled = false;
            btnSetEndKey.Enabled = false;

            labPressStartKey.Visible = true;
            setRecordStartKey(true);
        }

        private void btnSetEndKey_Click(object sender, EventArgs e) {
            //disable btns
            btnSetStartKey.Enabled = false;
            btnSetEndKey.Enabled = false;

            labPressEndKey.Visible = true;
            setRecordEndKey(true);
        }

        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            try {
                linkGithub.LinkVisited = true;
                System.Diagnostics.Process.Start("https://github.com/gabrielgrenier/OpenClicker");

            } catch(Exception ex) {
                MessageBox.Show("Couldn't open the URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
