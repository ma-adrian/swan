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

namespace Swan
{
    public partial class FormMain : Form
    {
        public static bool selected50;
        public static bool selectedTM;

        private FormAdd oFormAdd;
        private FormStopwatch oFormStopwatch;
        private bool formAddRdy = false;

        private int tolerance = 32;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        public FormMain()
        {
            InitializeComponent();
            Load += Form1_Load;
            DbManager.CreateDatabaseAndTablesIfNotExists();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.mainPanel.Region = region;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnMenuStopwatch.PerformClick();
            selected50 = check50.Checked;
            selectedTM = checkTM.Checked;
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (panelVertical.Width == 240)
            {
                panelVertical.Width = 70;
            } else {
                panelVertical.Width = 240;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnMinimize.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnMaximize.Visible = true;
            btnMinimize.Visible = false;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void AddFormToPanel(Form form)
        {
            if (panelContent.Controls.Count > 0) panelContent.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            panelContent.Tag = form;
            form.Show();
        }

        private void btnMenuAdd_Click(object sender, EventArgs e)
        {
            btnMenuAdd.BackColor = Color.FromArgb(44, 62, 80);
            btnMenuStopwatch.BackColor = Color.FromArgb(22, 160, 133);
            btnStartAllStopwatch.Visible = false;
            check50.Visible = false;
            checkTM.Visible = false;
            btnOkDisabled.Visible = !formAddRdy;
            btnOk.Visible = formAddRdy;
            if (oFormAdd == null)
            {
                oFormAdd = new FormAdd();
                oFormAdd.rdy += new InputReadyForSave(activateBtnOk);
            }
            AddFormToPanel(oFormAdd);
        }

        private void btnMenuStopwatch_Click(object sender, EventArgs e)
        {
            btnMenuStopwatch.BackColor = Color.FromArgb(44, 62, 80);
            btnMenuAdd.BackColor = Color.FromArgb(22, 160, 133);
            btnOk.Visible = false;
            btnOkDisabled.Visible = false;
            btnStartAllStopwatch.Visible = true;
            check50.Visible = true;
            checkTM.Visible = true;
            if (oFormStopwatch == null)
            {
                oFormStopwatch = new FormStopwatch();
            }
            AddFormToPanel(oFormStopwatch);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach(Control cnt in panelContent.Controls)
            {
                if(cnt.Name is "FormAdd")
                {
                    var textBoxes = cnt.Controls[1].Controls.OfType<TextBox>();
                    var dateTimePicker = cnt.Controls[1].Controls.OfType<DateTimePicker>();

                    List<string> swimmerAttr = new List<string>();
                    DateTime dob = new DateTime();
                    foreach(TextBox txt in textBoxes)
                    {
                        swimmerAttr.Add(txt.Text);
                    }
                    foreach(DateTimePicker dtp in dateTimePicker)
                    {
                        dob = dtp.Value.Date;
                    }

                    Swimmer sw = new Swimmer(0, swimmerAttr, dob);
                    bool result = DbManager.CreateSwimmer(sw);
                    if (result)
                    {
                        oFormAdd.showErrorMessage("");
                        oFormAdd.clearInput();
                    }
                    else
                    {
                        oFormAdd.showErrorMessage("Failed to create Swimmer.\nSwimmer is already in database.");
                    }
                }
            }
        }

        private void btnStartAllStopwatch_Click(object sender, EventArgs e)
        {
            foreach (Control cnt in oFormStopwatch.Controls[0].Controls.OfType<TileStopwatch>())
            {
                TileStopwatch frm = cnt as TileStopwatch;
                frm.btnStart_Click(btnStartAllStopwatch, null);
            }
        }

        private void activateBtnOk(object sender, EventArgs e, bool ready)
        {
            formAddRdy = ready;
            if (ready)
            {
                btnOkDisabled.Visible = false;
                btnOk.Visible = true;
            }
            else
            {
                btnOkDisabled.Visible = true;
                btnOk.Visible = false;
            }
        }

        private void check50_CheckedChanged(object sender, EventArgs e)
        {
            if (check50.Checked)
            {
                check50.Text = "50";
            }
            else
            {
                check50.Text = "25";
            }
            selected50 = check50.Checked;
        }

        private void checkTM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTM.Checked)
            {
                checkTM.Text = "TM";
            }
            else
            {
                checkTM.Text = "TR";
            }
            selectedTM = checkTM.Checked;
        }
    }
}
