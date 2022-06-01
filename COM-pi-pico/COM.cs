using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace COM_pi_pico
{
    public partial class COM : Form
    {
        public COM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }




        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kill_child_Click(object sender, EventArgs e)
        {

            string strCmdText;
            strCmdText = "/C taskkill /f /im putty.exe";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Process p = Process.Start("notepad.exe");
            var p = new Process();
            p.StartInfo.FileName = "putty.exe";
            p.StartInfo.Arguments = "-serial COM1";
            p.Start();
            Thread.Sleep(500); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, panel1.Handle);
            //Change the docked windows size to match its parent's size. 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Process p = Process.Start("notepad.exe");
            var p = new Process();
            p.StartInfo.FileName = "putty.exe";
            p.StartInfo.Arguments = "-serial COM2";
            p.Start();
            Thread.Sleep(500); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, panel1.Handle);
            //Change the docked windows size to match its parent's size. 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Process p = Process.Start("notepad.exe");
            var p = new Process();
            p.StartInfo.FileName = "putty.exe";
            p.StartInfo.Arguments = "-serial COM3";
            p.Start();
            Thread.Sleep(500); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, panel1.Handle);
            //Change the docked windows size to match its parent's size. 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Process p = Process.Start("notepad.exe");
            var p = new Process();
            p.StartInfo.FileName = "putty.exe";
            p.StartInfo.Arguments = "-serial COM4";
            p.Start();
            Thread.Sleep(500); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, panel1.Handle);
            //Change the docked windows size to match its parent's size. 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Process p = Process.Start("notepad.exe");
            var p = new Process();
            p.StartInfo.FileName = "putty.exe";
            p.StartInfo.Arguments = "-serial COM5";
            p.Start();
            Thread.Sleep(500); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, panel1.Handle);
            //Change the docked windows size to match its parent's size. 
        }
    }
}
