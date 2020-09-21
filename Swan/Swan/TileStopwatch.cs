using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swan
{
    public partial class TileStopwatch : Form
    {
        public string selectedStyle = "";
        public int selectedDistance = 0;
        private Swimmer sw;

        public TileStopwatch(Swimmer _sw)
        {
            InitializeComponent();
            sw = _sw;
            nameLabel.Text = sw.first_name + " " + sw.last_name;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = sw.elapsedMillisecondStopwatch().ToString(@"mm\:ss\:fff");
            lapLabel.Text = "Lap:  " + sw.lastLap.ToString(@"mm\:ss\:fff");
            splitLabel.Text = "Split: " + sw.splitTime.ToString(@"mm\:ss\:fff");
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            sw.startStopwatch();
            // deactivate start, reset, close, buttons
            btnStart.Image = Properties.Resources.play_circle_lowop;
            btnReset.Image = Properties.Resources.rotate_ccw_lowop;
            btnClose.Image = Properties.Resources.x_lowop;
            btnStart.Enabled = false;
            btnReset.Enabled = false;
            btnClose.Enabled = false;
            // activate stop, lap buttons
            btnStop.Image = Properties.Resources.stop_circle;
            btnLap.Image = Properties.Resources.pie_chart;
            btnStop.Enabled = true;
            btnLap.Enabled = true;
            // check for activating save button
            checkToActivateBtnSave();
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            sw.lapStopwatch();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            sw.stopStopwatch();
            sw.lapStopwatch();
            // deavtivate stop, lap buttons
            btnStop.Image = Properties.Resources.stop_circle_lowop;
            btnLap.Image = Properties.Resources.pie_chart_lowop;
            btnStop.Enabled = false;
            btnLap.Enabled = false;
            // activate start, reset, close, buttons
            btnStart.Image = Properties.Resources.play_circle;
            btnReset.Image = Properties.Resources.rotate_ccw;
            btnClose.Image = Properties.Resources.x_black;
            btnStart.Enabled = true;
            btnReset.Enabled = true;
            btnClose.Enabled = true;
            // check for activating save button
            checkToActivateBtnSave();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            sw.resetStopwatch();
            btnReset.Image = Properties.Resources.rotate_ccw_lowop;
            btnReset.Enabled = false;
            // check for activating save button
            checkToActivateBtnSave();
        }

        CheckBox styleLastChecked;
        private void chkStyle_Click(object sender, MouseEventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != styleLastChecked && styleLastChecked != null) styleLastChecked.Checked = false;
            styleLastChecked = activeCheckBox.Checked ? activeCheckBox : null;
            if (activeCheckBox.Checked == true)
            {
                switch (activeCheckBox.Name)
                {
                    case "checkFR":
                        selectedStyle = "fr";
                        break;
                    case "checkBK":
                        selectedStyle = "bk";
                        break;
                    case "checkBR":
                        selectedStyle = "br";
                        break;
                    case "checkBU":
                        selectedStyle = "bu";
                        break;
                    case "checkIM":
                        selectedStyle = "im";
                        break;
                }
            }
            else
            {
                selectedStyle = "";
            }
            checkToActivateBtnSave();
        }

        CheckBox distanceLastChecked;
        private void chkDistance_Click(object sender, MouseEventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != distanceLastChecked && distanceLastChecked != null) distanceLastChecked.Checked = false;
            distanceLastChecked = activeCheckBox.Checked ? activeCheckBox : null;
            if (activeCheckBox.Checked == true)
            {
                switch (activeCheckBox.Name)
                {
                    case "check25":
                        selectedDistance = 25;
                        break;
                    case "check50":
                        selectedDistance = 50;
                        break;
                    case "check75":
                        selectedDistance = 75;
                        break;
                    case "check100":
                        selectedDistance = 100;
                        break;
                    case "check200":
                        selectedDistance = 200;
                        break;
                    case "check400":
                        selectedDistance = 400;
                        break;
                    case "check800":
                        selectedDistance = 800;
                        break;
                    case "check1500":
                        selectedDistance = 1500;
                        break;
                }
            }
            else
            {
                selectedDistance = 0;
            }
            checkToActivateBtnSave();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!sw.isRunningStopwatch())
            {
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DbManager.AddRecord(sw.id, selectedStyle, selectedDistance, sw.startDate, Convert.ToInt32(sw.elapsedMillisecondStopwatch().TotalMilliseconds), sw.allLaps))
            {
                btnReset_Click(btnReset, null);
            }
        }

        private void checkToActivateBtnSave()
        {
            if (selectedStyle != "" && selectedDistance != 0 && !sw.isRunningStopwatch() && sw.elapsedMillisecondStopwatch() != new TimeSpan(0))
            {
                btnSave.Image = Properties.Resources.save;
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Image = Properties.Resources.save_lowop;
                btnSave.Enabled = false;
            }
        }

        private void toggleLastLaps(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            tableLayoutPanel2.Visible = false;
            tableLayoutPanel3.Visible = false;
            tableLayoutPanel4.Visible = false;
            tableLayoutPanel6.Visible = false;

            string lastLapsString = "";
            string lastSplitsString = "";
            if (sw.allLaps.Count > 0)
            {
                foreach (Tuple<TimeSpan, TimeSpan> lap in sw.allLaps)
                {
                    lastLapsString += lap.Item1.ToString(@"mm\:ss\:ff") + "\n";
                    lastSplitsString += lap.Item2.ToString(@"mm\:ss\:ff") + "\n";
                }
            }
            else
            {
                lastLapsString += sw.lastLap.ToString(@"mm\:ss\:ff") + "\n";
                lastSplitsString += sw.splitTime.ToString(@"mm\:ss\:ff") + "\n";
            }
            lastLapsLabel.Text = lastLapsString;
            lastSplitsLabel.Text = lastSplitsString;

            string lastEventString = "";
            string lastEventSplitString = "";
            if (selectedDistance != 0 && selectedStyle != "")
            {
                Tuple<string, string, string> temp = DbManager.GetLastSameTrackText(sw.id, selectedStyle, selectedDistance);
                lastEventString = temp.Item1;
                lastEventSplitString = temp.Item2;
                seperatorLabel.Text = temp.Item3;
            }
            lastSameEventLabel.Text = lastEventString;
            lastSameEventSplitsLabel.Text = lastEventSplitString;
            tableLayoutPanel7.Visible = true;
        }

        private void toggleFullView(object sender, EventArgs e)
        {
            tableLayoutPanel7.Visible = false;

            tableLayoutPanel1.Visible = true;
            tableLayoutPanel2.Visible = true;
            tableLayoutPanel3.Visible = true;
            tableLayoutPanel4.Visible = true;
            tableLayoutPanel6.Visible = true;
        }
    }
}
