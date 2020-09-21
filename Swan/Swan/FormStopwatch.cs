using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Swan
{
    public partial class FormStopwatch : Form
    {
        public FormStopwatch()
        {
            InitializeComponent();
            tableLayoutPanel1.Controls.Add(btnAddPanel);
            btnAddPanel.Visible = true;
        }

        private void btnAddPanel_Click(object sender, EventArgs e)
        {
            SwimmerList frm = new SwimmerList();
            frm.FormClosed += new FormClosedEventHandler(SwimmerSelected);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            tableLayoutPanel1.Visible = false;
            Controls.Add(frm);
            frm.Show();
        }

        private void RemoveControlFromPanel(object sender, FormClosedEventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(sender as Control);
        }

        private void SwimmerSelected(object sender, FormClosedEventArgs e)
        {
            SwimmerList closingFrm = sender as SwimmerList;
            if (closingFrm.selectedSwimmer != null)
            {
                TileStopwatch frm = new TileStopwatch(closingFrm.selectedSwimmer);
                frm.FormClosed += new FormClosedEventHandler(RemoveControlFromPanel);
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                tableLayoutPanel1.Controls.Remove(btnAddPanel);
                tableLayoutPanel1.Controls.Add(frm);
                frm.Show();
                tableLayoutPanel1.Controls.Add(btnAddPanel);
            }
            tableLayoutPanel1.Visible = true;
        }
    }
}
