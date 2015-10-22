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
using System.Media;
using System.Diagnostics;
namespace MyAlarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern void LockWorkStation();

        private int seconds; // Seconds.
        private int minutes; // Minutes.
        private int hours;   // Hours.
        private bool paused; // State of the timer [PAUSED/WORKING].

        private void btn_Sleep_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Suspend, true, true);
        }

        private void btn_Lock_Click(object sender, EventArgs e)
        {
            LockWorkStation();
        }

        private void btn_Hibr_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Hibernate, true, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_hr.Text = "00";
            cmb_min.Text = "00";
            cmb_sec.Text = "00";
            cmb_act.Text = " ----- Select -----";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Verify if the time didn't pass.
            if ((minutes == 00) && (hours == 00) && (seconds == 00))
            {
                // If the time is over, clear all settings and fields.
                // Also, show the message, notifying that the time is over.
                timer1.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = false;
                button2.Enabled = true;
                cmb_hr.Enabled = true;
                cmb_sec.Enabled = true;
                cmb_min.Enabled = true;
                cmb_act.Enabled = true;
                lblHr.Text = "--";
                lblMin.Text = "--";
                lblSec.Text = "--";


                cmb_hr.Text = "--";
                cmb_min.Text = "--";
                cmb_sec.Text = "--";

                if (cmb_act.Text=="Lock")
                {
                    LockWorkStation();
                }
                else if (cmb_act.Text == "Sleep")
                {
                    Application.SetSuspendState(PowerState.Suspend, true, true);
                }
                else if (cmb_act.Text == "Hibernate")
                {
                    Application.SetSuspendState(PowerState.Hibernate, true, true);
                }
                else if (cmb_act.Text == "Shut Down")
                {
                    Process.Start("shutdown", "/s /t 0");
                }
                else if (cmb_act.Text == "Restart")
                {
                    Process.Start("shutdown", "/r /t 0");
                }
                else if (cmb_act.Text == "Alarm")
                {
                    Alarm();
                }
                else
                {
                    MessageBox.Show("Invalid Settings", "Incomplete Settings!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                // Else continue counting.
                if (seconds < 1)
                {
                    seconds = 59;
                    if (minutes == 0)
                    {
                        minutes = 59;
                        if (hours != 0)
                            hours -= 1;

                    }
                    else
                    {
                        minutes -= 1;
                    }
                }
                else
                    seconds -= 1;
                // Display the current values of hours, minutes and seconds in
                // the corresponding fields.
                lblHr.Text = hours.ToString();
                lblMin.Text = minutes.ToString();
                lblSec.Text = seconds.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmb_act.Text == " ----- Select -----")
            {
                MessageBox.Show("Select an action", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_act.Focus();
            }

            else if (paused != true)
            {
                if ((cmb_hr.Text == "00") && (cmb_min.Text == "00") && (cmb_sec.Text == "00") && (cmb_act.Text == ""))
                {
                    MessageBox.Show("Invalid Settings!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ((cmb_hr.Text != "") && (cmb_min.Text != "") && (cmb_sec.Text != "") && (cmb_act.Text != ""))
                {
                    timer1.Enabled = true;
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button3.Enabled = true;
                    cmb_hr.Enabled = false;
                    cmb_min.Enabled = false;
                    cmb_sec.Enabled = false;
                    cmb_act.Enabled = false;

                    try
                    {
                        minutes = System.Convert.ToInt32(cmb_min.Text);
                        seconds = System.Convert.ToInt32(cmb_sec.Text);
                        hours = System.Convert.ToInt32(cmb_hr.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Settings","Incomplete settings!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                timer1.Enabled = true;
                paused = false;
                button2.Enabled = false;
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pause the timer.
            timer1.Enabled = false;
            paused = true;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Stop the timer.
            paused = false;
            timer1.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = true;
            
            cmb_hr.Enabled = true;
            cmb_min.Enabled = true;
            cmb_sec.Enabled = true;
            cmb_act.Enabled = true;

            lblHr.Text = "00";
            lblMin.Text = "00";
            lblSec.Text = "00";

            cmb_hr.Text = "00";
            cmb_min.Text = "00";
            cmb_sec.Text = "00";

            cmb_act.Text = " ----- Select -----";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                mynotifyicon.Visible = true;
                mynotifyicon.ShowBalloonTip(500);
                this.Hide();
                ShowInTaskbar = false;
                

            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                ShowInTaskbar = true;
                mynotifyicon.Visible = false;
                this.Show();

            }
        }

        private void mynotifyicon_Click(object sender, EventArgs e)
        {
            Show(); //shows the program on task bar

            this.WindowState = FormWindowState.Normal; //undoes the minimized state of the form

            ShowInTaskbar = true;
        }

        private void mynotifyicon_DoubleClick(object sender, EventArgs e)
        {
            Show(); //shows the program on task bar

            this.WindowState = FormWindowState.Normal; //undoes the minimized state of the form

            ShowInTaskbar = true;
           // mynotifyicon.Visible = false; //hides tray icon again*/
        }

        private void cmb_hr_Click(object sender, EventArgs e)
        {
            if (cmb_hr.Text == "0" || cmb_hr.Text =="00")
            {
               cmb_hr.DataSource = Enumerable.Range(00, 24).ToArray();
            }
            else
            {
                
            }
            
        }

        private void cmb_min_Click(object sender, EventArgs e)
        {
            if (cmb_min.Text == "0" || cmb_min.Text == "00")
            {
                cmb_min.DataSource = Enumerable.Range(0, 60).ToArray();
            }
            else
            { 
            
            }            
        }

        private void cmb_sec_Click(object sender, EventArgs e)
        {
            if (cmb_sec.Text == "0" || cmb_sec.Text == "00")
            {
                cmb_sec.DataSource = Enumerable.Range(0, 60).ToArray();
            }
            else
            {

            }            
        }
                
        private void button4_Click(object sender, EventArgs e)
        {
            var f1 = Application.OpenForms["About"];
            if (f1 != null)
                f1.Close();

            f1 = new About();
            f1.Show();
        }
       
        private void Alarm()
        {
           /* SoundPlayer s = new SoundPlayer("E://My Doc//Ring Tones//android_latest_2013.wav");

            s.Play();
           */

            //To be developed in the future.
        }
        
        private void btn_Shut_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
            
            // starts the shutdown application 
            // the argument /s is to shut down the computer
            // the argument /t 0 is to tell the process that the specified operation needs to be completed after 0 seconds
        }

        private void btn_Rst_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0"); 
            
            // the argument /r is to restart the computer
        }

        private void cmb_hr_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmb_hr.SelectAll();
        }

        private void cmb_hr_SelectedValueChanged(object sender, EventArgs e)
        {
            lblHr.Text = cmb_hr.Text;
        }

        private void cmb_min_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMin.Text = cmb_min.Text;
        }

        private void cmb_sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSec.Text = cmb_sec.Text;
        }
    }
}
