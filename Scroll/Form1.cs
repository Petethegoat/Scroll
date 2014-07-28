using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using MouseKeyboardActivityMonitor.WinApi;
using MouseKeyboardActivityMonitor;

namespace Scroll
{
    public partial class Scroll : Form
    {
        #region Dll Imports
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        static extern bool ClipCursor(ref Rectangle lpRect);

        [DllImport("user32.dll")]
        static extern void ClipCursor(IntPtr rect);

        [DllImport("user32.dll")]
        static extern IntPtr WindowFromPoint(int xPoint, int yPoint);

        [DllImport("user32.dll")]
        static extern IntPtr GetActiveWindow();

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, ref Point lParam);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        enum GetAncestorFlags
        {
            /// <summary>
            /// Retrieves the parent window. This does not include the owner, as it does with the GetParent function. 
            /// </summary>
            GetParent = 1,
            /// <summary>
            /// Retrieves the root window by walking the chain of parent windows.
            /// </summary>
            GetRoot = 2,
            /// <summary>
            /// Retrieves the owned root window by walking the chain of parent and owner windows returned by GetParent. 
            /// </summary>
            GetRootOwner = 3
        }

        [DllImport("user32.dll", ExactSpelling = true)]
        static extern IntPtr GetAncestor(IntPtr hwnd, GetAncestorFlags flags);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool SetWindowText(IntPtr hwnd, String lpString);

        #endregion

        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x0101;
        private const int WM_MOUSEWHEEL = 0x020A;
        private int WHEEL_DELTA = 120;

        private Timer timer;
        private Rectangle captureRectangle;
        private Point p = new Point();
        private MouseKeyboardActivityMonitor.MouseHookListener m_MouseHookManager;

        private void HookManager_MouseWheel(object sender, MouseEventArgs e)
        {
            IntPtr activeWnd = GetForegroundWindow();
            IntPtr aimWnd = WindowFromPoint(e.X, e.Y);
            IntPtr aimWndDad = GetAncestor(aimWnd, GetAncestorFlags.GetRoot);
            if(activeWnd != aimWndDad)
            { 
                SendMessage(aimWnd, WM_MOUSEWHEEL, (WHEEL_DELTA * (e.Delta / 120)) << 16, ref p);
                //SendMessage(aimWnd, WM_KEYDOWN, e.Delta < 0 ? (int)Keys.Down : (int)Keys.Up, ref p);
            }
        }

        public Scroll()
        {
            InitializeComponent();
            Init();
            ShowInTaskbar = false;
            MaximizeBox = false;

            SizeChanged += new System.EventHandler(Form_Resize);
            notifyIcon1.DoubleClick += new System.EventHandler(Window_Show);
            toggleCaptureToolStripMenuItem.Click += new System.EventHandler(Tray_ToggleCapture);
            optionsToolStripMenuItem.Click += new System.EventHandler(Window_Show);
            exitToolStripMenuItem.Click += new System.EventHandler(Tray_Exit);
            hideTrayCheck.CheckedChanged += new System.EventHandler(Check_Tray);
            startupCheck.CheckedChanged += new System.EventHandler(Check_Startup);
            captureCheck.CheckedChanged += new System.EventHandler(Check_Capture);
            scrollCheck.CheckedChanged += new System.EventHandler(Check_Scroll);
            captureX.LostFocus += new System.EventHandler(Capture_Bounds);
            captureY.LostFocus += new System.EventHandler(Capture_Bounds);
            captureW.LostFocus += new System.EventHandler(Capture_Bounds);
            captureH.LostFocus += new System.EventHandler(Capture_Bounds);
            aboutLink.Links.Add(3, 20, "https://github.com/Petethegoat");
            aboutLink.LinkClicked += new LinkLabelLinkClickedEventHandler(aboutLink_LinkClicked);
        }

        private void Tick(object sender, EventArgs e)
        {
            GetCursorPos(out p);
            coords.Text = p.X.ToString() + ", " + p.Y.ToString();
            Update_Capture(captureCheck.Checked);
        }

        private void Init()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(Tick);
            timer.Interval = 10;
            timer.Start();

            m_MouseHookManager = new MouseKeyboardActivityMonitor.MouseHookListener(new GlobalHooker());
            m_MouseHookManager.Enabled = true;

            captureRectangle = new Rectangle((int)captureX.Value, (int)captureY.Value, (int)captureW.Value, (int)captureH.Value);
            
            //Startup
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", false);
            if(rk != null && rk.GetValue("Scroll") != null)
            {
                startupCheck.Checked = true;
            }
            //Loading
            rk = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Wow6432Node\\Scroll");
            rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Wow6432Node\\Scroll", false);
            if(rk != null)
            {
                object o = rk.GetValue("HideTrayIcon");
                if(o != null && o.ToString() == "true")
                {
                    hideTrayCheck.Checked = true;
                    notifyIcon1.Visible = !hideTrayCheck.Checked;
                }
                o = rk.GetValue("RunAsAdmin");
                if(o != null && o.ToString() == "true")
                {
                    adminCheck.Checked = true;
                }
                o = rk.GetValue("EnableScrolling");
                if(o != null && o.ToString() == "true")
                {
                    scrollCheck.Checked = true;
                    m_MouseHookManager.MouseWheel += HookManager_MouseWheel;
                }
            }
        }

        private void Update_Capture(bool capture)
        {
            if(capture)
            {
                ClipCursor(ref captureRectangle);
            }
            else
            {
                ClipCursor(IntPtr.Zero);
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void Window_Show(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            BringToFront();
        }

        private void Tray_Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void Check_Tray(object sender, EventArgs e)
        {
            notifyIcon1.Visible = !hideTrayCheck.Checked;
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Wow6432Node\\Scroll", true);
            if(rk != null)
            {
                rk.SetValue("HideTrayIcon", hideTrayCheck.Checked ? "true" : "false");
            }
        }

        private void Check_Scroll(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Wow6432Node\\Scroll", true);
            if(scrollCheck.Checked)
            {
                m_MouseHookManager.MouseWheel += HookManager_MouseWheel;
            }
            else
            {
                m_MouseHookManager.MouseWheel -= HookManager_MouseWheel;
            }

            if(rk != null)
            {
                rk.SetValue("EnableScrolling", scrollCheck.Checked ? "true" : "false");
            }
        }

        private void Check_Startup(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if(startupCheck.Checked)
                rk.SetValue("Scroll", Application.ExecutablePath.ToString());
            else
                rk.DeleteValue("Scroll", false);
        }

        private void Tray_ToggleCapture(object sender, EventArgs e)
        {
            captureCheck.Checked = !captureCheck.Checked;
        }

        private void Check_Capture(object sender, EventArgs e)
        {
            Update_Capture(captureCheck.Checked);
        }

        private void Capture_Bounds(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(((Control)captureX).Text))
                ((Control)captureX).Text = captureX.Value.ToString();

            if (string.IsNullOrEmpty(((Control)captureY).Text))
                ((Control)captureY).Text = captureY.Value.ToString();

            if (string.IsNullOrEmpty(((Control)captureW).Text))
                ((Control)captureW).Text = captureW.Value.ToString();

            if (string.IsNullOrEmpty(((Control)captureH).Text))
                ((Control)captureH).Text = captureH.Value.ToString();

            if(captureX.Value >= captureW.Value)
            {
                captureW.Value = captureX.Value + 1;
            }
            if(captureY.Value >= captureH.Value)
            {
                captureH.Value = captureY.Value + 1;
            }
            captureRectangle = new Rectangle((int)captureX.Value, (int)captureY.Value, (int)captureW.Value, (int)captureH.Value);
        }

        private void aboutLink_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
