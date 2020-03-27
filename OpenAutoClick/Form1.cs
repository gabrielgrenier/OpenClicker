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
using System.Runtime.InteropServices;
using System.Reflection;
using System.Drawing;

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

        //setters
        private void setMinTime(int minTime) {
            this.minTime = minTime;
        }
        private void setMaxTime(int maxTime) {
            this.maxTime = maxTime;
        }
        public void setRunningThread() {
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


                    //mouse click
                    uint X = (uint)Cursor.Position.X;
                    uint Y = (uint)Cursor.Position.Y;
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }
            });
        }
        public void setRandomMousePosition(Boolean randomMousePosition) {
            this.randomMousePosition = randomMousePosition;
        }

        public MainForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
            _listener = new LowLevelKeyboardListener();
            _listener.OnKeyPressed += _listener_OnKeyPressed;
            _listener.HookKeyboard();

            //this.Cursor = new Cursor(Directory.GetCurrentDirectory() + "\\DScim.cur");

            Cursor mycursor = new Cursor(Cursor.Current.Handle);
            IntPtr colorcursorhandle = LoadCursorFromFile(Directory.GetCurrentDirectory() + "\\DScim.cur");
            mycursor.GetType().InvokeMember("handle", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetField, null, mycursor, new object[] { colorcursorhandle });
            this.Cursor = mycursor;

            randomMousePosition = false;
            labMaxDistance.Visible = false;
            numMaxDistance.Visible = false;

        }

        void _listener_OnKeyPressed(object sender, KeyPressedArgs e) {
            //MessageBox.Show(e.KeyPressed.ToString());

            if (e.KeyPressed.ToString() == "Insert") {
                if(runningThread == null){ 
                    setRunningThread();
                    runningThread.Start();
                }
                else if(runningThread!=null && !runningThread.IsAlive) {
                    setRunningThread();
                    runningThread.Start();
                }
            }

            if (e.KeyPressed.ToString() == "Delete" && runningThread != null) {
                runningThread.Abort();
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
    }
}
