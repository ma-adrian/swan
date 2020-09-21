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
    public partial class SwimmerList : Form
    {
        public Swimmer selectedSwimmer;

        public SwimmerList()
        {
            InitializeComponent();
            Load += init;
        }

        private void init(object sender, EventArgs e)
        {
            List<Swimmer> list = DbManager.GetAllSwimmers();
            if (list.Count == 0)
            {
                Label lbl = new Label
                {
                    Text = "No swimmer in database.",
                    AutoSize = true,
                };
                tableLayoutPanel1.Controls.Add(lbl);
                PictureBox pic = new PictureBox
                {
                    Image = Properties.Resources.arrow_left_small,
                };
                pic.MouseClick += new MouseEventHandler(btnBack);
                tableLayoutPanel1.Controls.Add(pic);
            }
            foreach (Swimmer sw in list)
            {

                Button btn = new Button
                {
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font(new FontFamily("Ink Free"), 18),
                    AutoSize = true,
                    Text = sw.first_name + " " + sw.last_name,
                    Tag = sw,
                };
                btn.FlatAppearance.BorderSize = 0;
                btn.MouseClick += new MouseEventHandler(btnClick);
                tableLayoutPanel1.Controls.Add(btn);
            }
        }

        private void btnClick(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            selectedSwimmer = b.Tag as Swimmer;
            Close();
        }

        private void btnBack(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
