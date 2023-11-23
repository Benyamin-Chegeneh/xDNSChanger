using System;
using System.Windows.Forms;

namespace xDNSChanger
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
        }
        private void btn_connect_Click(object sender, EventArgs e)
        {
            string DNS1 = txt_primary.Text;
            string DNS2 = txt_secondary.Text;
            if (!string.IsNullOrWhiteSpace(DNS1) && !string.IsNullOrWhiteSpace(DNS2))
            {
                try
                {
                    if (btn_connect.Text == "Disconnect")
                    {
                        UnsetDNS.Unset();
                        btn_connect.ForeColor = System.Drawing.Color.FromArgb(15, 131, 48);
                        btn_connect.Text = "Connect";
                        txt_primary.Enabled = true;
                        txt_secondary.Enabled = true;
                    }
                    else
                    {
                        SetDNS.Set(DNS1, DNS2);

                        txt_primary.Enabled = false;
                        txt_secondary.Enabled = false;

                        btn_connect.ForeColor = System.Drawing.Color.Red;

                        btn_connect.Text = "Disconnect";
                    }
                }
                catch (Exception)
                {
                    if (MessageBox.Show("Exception Error\n\ris your DNS is incorrect\n\rPlease Try Again or Get Support", "xDNSChanger - Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.Retry)
                    {
                        btn_connect_Click(sender, e);
                    }
                    else { }
                }

            }
            else
            {
                if (MessageBox.Show("DNS TextBox is Empty.\n\rPlease Fill the DNS TextBox\n\rPlease Try Again or Get Support", "xDNSChanger - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.OK) { }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void pic_telegram_MouseHover(object sender, EventArgs e)
        {
            this.pic_telegram.Image = global::xDNSChanger.Properties.Resources.tel_icon_2;
        }

        private void pic_github_MouseHover(object sender, EventArgs e)
        {
            this.pic_github.Image = global::xDNSChanger.Properties.Resources.gh_icon_2;
        }

        private void pic_telegram_MouseLeave(object sender, EventArgs e)
        {
            this.pic_telegram.Image = global::xDNSChanger.Properties.Resources.tel_icon_1;
        }
        private void pic_github_MouseLeave(object sender, EventArgs e)
        {
            this.pic_github.Image = global::xDNSChanger.Properties.Resources.gh_icon_1;
        }

        private void txt_primary_Click(object sender, EventArgs e)
        {
            if (txt_primary.Text == "8.8.8.8")
            {
                txt_primary.Text = string.Empty;
            }
        }

        private void txt_secondary_Click(object sender, EventArgs e)
        {
            if (txt_secondary.Text == "8.8.4.4")
            {
                txt_secondary.Text = string.Empty;
            }
        }

        private void pic_telegram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://t.me/Benyamin_Chegeneh");
        }

        private void pic_github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Benyamin-Chegeneh");
        }
    }
}
