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

namespace doYouWantSomeCoffe
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

    private static extern IntPtr CreateRoundRectRgn
     (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
     );
        public Form1()
        {
            InitializeComponent();
           
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            txtlatte.Text = "0";
            txtes.Text = "0";
            txticelatte.Text = "0";
            txtcap.Text = "0";
            txtaf.Text = "0";
            txtamerican.Text = "0";
            txtvale.Text = "0";
            txticecap.Text = "0";
            txtcake.Text = "0";
            txtred.Text = "0";
            txtblack.Text = "0";
            txtboston.Text = "0";
            txtlagos.Text = "0";
            txtkilburn.Text = "0";
            txtcarlton.Text = "0";
            txtqueen.Text = "0";

            lblcostOFcake.Text = "0";
            lblcostOFdrink.Text = "0";
            lblservice.Text = "0";

            txtlatte.Enabled = false;
            txtes.Enabled = false;
            txticelatte.Enabled = false;
            txtcap.Enabled = false;
            txtaf.Enabled = false;
            txtamerican.Enabled = false;
            txtvale.Enabled = false;
            txticecap.Enabled = false;
            txtcake.Enabled = false;
            txtred.Enabled = false;
            txtblack.Enabled = false;
            txtboston.Enabled = false;
            txtlagos.Enabled = false;
            txtkilburn.Enabled = false;
            txtcarlton.Enabled = false;
            txtqueen.Enabled = false;

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
             
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
             
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_latte.Checked == true)
            {
                txtlatte.Enabled = true;
            }
            if (check_latte.Checked == false)
            {
                txtlatte.Enabled = false;
                txtlatte.Text = "0";
            }

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtlatte.Text = "0";
            txtes.Text = "0";
            txticelatte.Text = "0";
            txtcap.Text = "0";
            txtaf.Text = "0";
            txtamerican.Text = "0";
            txtvale.Text = "0";
            txticecap.Text = "0";
            txtcake.Text = "0";
            txtred.Text = "0";
            txtblack.Text = "0";
            txtboston.Text = "0";
            txtlagos.Text = "0";
            txtkilburn.Text = "0";
            txtcarlton.Text = "0";
            txtqueen.Text = "0";

            lblcostOFcake.Text = "0";
            lblcostOFdrink.Text = "0";
            lblservice.Text = "0";
            lbltax.Text = "0";
            lbltotal.Text = "0";
            lblTotalSub.Text = "0";

            //txtlatte.Enabled = false;
            //txtes.Enabled = false;
            //txticelatte.Enabled = false;
            //txtcap.Enabled = false;
            //txtaf.Enabled = false;
            //txtamerican.Enabled = false;
            //txtvale.Enabled = false;
            //txticecap.Enabled = false;
            //txtcake.Enabled = false;
            //txtred.Enabled = false;
            //txtblack.Enabled = false;
            //txtboston.Enabled = false;
            //txtlagos.Enabled = false;
            //txtkilburn.Enabled = false;
            //txtcarlton.Enabled = false;
            //txtqueen.Enabled = false;

            check_latte.Checked = false;
            check_es.Checked = false;
            check_icelatte.Checked = false;
            check_cap.Checked = false;
            check_af.Checked = false;
            check_american.Checked = false;
            check_vale.Checked = false;
            check_icecap.Checked = false;
            check_cake.Checked = false;
            check_red.Checked = false;
            check_black.Checked = false;
            check_boston.Checked = false;
            check_lagos.Checked = false;
            check_kilburn.Checked = false;
            check_carlton.Checked = false;
            check_queen.Checked = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

       
        private void txtlatte_Click(object sender, EventArgs e)
        {
            txtlatte.Text = "";
            txtlatte.Focus();

        }

        private void txtes_Click(object sender, EventArgs e)
        {
            txtes.Text = "";
            txtes.Focus();
        }

        private void check_es_CheckedChanged(object sender, EventArgs e)
        {
            if (check_es.Checked == true)
            {
                txtes.Enabled = true;
            }
            if (check_es.Checked == false)
            {
                txtes.Enabled = false;
                txtes.Text = "0";
            }
        }

        private void txticelatte_Click(object sender, EventArgs e)
        {
            txticelatte.Text = "";
            txticelatte.Focus();
        }

        private void check_icelatte_CheckedChanged(object sender, EventArgs e)
        {
            if (check_icelatte.Checked == true)
            {
                txticelatte.Enabled = true;
            }
            if (check_icelatte.Checked == false)
            {
                txticelatte.Enabled = false;
                txticelatte.Text = "0";
            }
        }

        private void txtcap_Click(object sender, EventArgs e)
        {
            txtcap.Text = "";
            txtcap.Focus();
        }

        private void check_cap_CheckedChanged(object sender, EventArgs e)
        {
            if (check_cap.Checked == true)
            {
                txtcap.Enabled = true;
            }
            if (check_cap.Checked == false)
            {
                txtcap.Enabled = false;
                txtcap.Text = "0";
            }
        }

        private void txtaf_Click(object sender, EventArgs e)
        {
            txtaf.Text = "";
            txtaf.Focus();
        }

        private void check_af_CheckedChanged(object sender, EventArgs e)
        {
            if (check_af.Checked == true)
            {
                txtaf.Enabled = true;
            }
            if (check_af.Checked == false)
            {
                txtaf.Enabled = false;
                txtaf.Text = "0";
            }
        }

        private void txtamerican_Click(object sender, EventArgs e)
        {
            txtamerican.Text = "";
            txtamerican.Focus();
        }

        private void check_american_CheckedChanged(object sender, EventArgs e)
        {
            if (check_american.Checked == true)
            {
                txtamerican.Enabled = true;
            }
            if (check_american.Checked == false)
            {
                txtamerican.Enabled = false;
                txtamerican.Text = "0";
            }
        }

        private void txtvale_Click(object sender, EventArgs e)
        {
            txtvale.Text = "";
            txtvale.Focus();
        }

        private void check_vale_CheckedChanged(object sender, EventArgs e)
        {
            if (check_vale.Checked == true)
            {
                txtvale.Enabled = true;
            }
            if (check_vale.Checked == false)
            {
                txtvale.Enabled = false;
                txtvale.Text = "0";
            }
        }

        private void txticecap_Click(object sender, EventArgs e)
        {
            txticecap.Text = "";
            txticecap.Focus();
        }

        private void check_icecap_CheckedChanged(object sender, EventArgs e)
        {
            if (check_icecap.Checked == true)
            {
                txticecap.Enabled = true;
            }
            if (check_icecap.Checked == false)
            {
                txticecap.Enabled = false;
                txticecap.Text = "0";
            }
        }

        private void txtcake_Click(object sender, EventArgs e)
        {
            txtcake.Text = "";
            txtcake.Focus();
        }

        private void check_cake_CheckedChanged(object sender, EventArgs e)
        {
            if (check_cake.Checked == true)
            {
                txtcake.Enabled = true;
            }
            if (check_cake.Checked == false)
            {
                txtcake.Enabled = false;
                txtcake.Text = "0";
            }
        }

        private void txtred_Click(object sender, EventArgs e)
        {
            txtred.Text = "";
            txtred.Focus();
        }

        private void check_red_CheckedChanged(object sender, EventArgs e)
        {
            if (check_red.Checked == true)
            {
                txtred.Enabled = true;
            }
            if (check_red.Checked == false)
            {
                txtred.Enabled = false;
                txtred.Text = "0";
            }
        }

        private void txtblack_Click(object sender, EventArgs e)
        {
            txtblack.Text = "";
            txtblack.Focus();
        }

        private void check_black_CheckedChanged(object sender, EventArgs e)
        {
            if (check_black.Checked == true)
            {
                txtblack.Enabled = true;
            }
            if (check_black.Checked == false)
            {
                txtblack.Enabled = false;
                txtblack.Text = "0";
            }
        }

        private void txtboston_Click(object sender, EventArgs e)
        {
            txtboston.Text = "";
            txtboston.Focus();
        }

        private void check_boston_CheckedChanged(object sender, EventArgs e)
        {
            if (check_boston.Checked == true)
            {
                txtboston.Enabled = true;
            }
            if (check_boston.Checked == false)
            {
                txtboston.Enabled = false;
                txtboston.Text = "0";
            }
        }

        private void txtlagos_Click(object sender, EventArgs e)
        {
            txtlagos.Text = "";
            txtlagos.Focus();
        }

        private void check_lagos_CheckedChanged(object sender, EventArgs e)
        {
            if (check_lagos.Checked == true)
            {
                txtlagos.Enabled = true;
            }
            if (check_lagos.Checked == false)
            {
                txtlagos.Enabled = false;
                txtlagos.Text = "0";
            }
        }

        private void txtkilburn_Click(object sender, EventArgs e)
        {
            txtkilburn.Text = "";
            txtkilburn.Focus();
        }

        private void check_kilburn_CheckedChanged(object sender, EventArgs e)
        {
            if (check_kilburn.Checked == true)
            {
                txtkilburn.Enabled = true;
            }
            if (check_kilburn.Checked == false)
            {
                txtkilburn.Enabled = false;
                txtkilburn.Text = "0";
            }
        }

        private void txtcarlton_Click(object sender, EventArgs e)
        {
            txtcarlton.Text = "";
            txtcarlton.Focus();
        }

        private void check_carlton_CheckedChanged(object sender, EventArgs e)
        {
            if (check_carlton.Checked == true)
            {
                txtcarlton.Enabled = true;
            }
            if (check_carlton.Checked == false)
            {
                txtcarlton.Enabled = false;
                txtcarlton.Text = "0";
            }
        }

        private void txtqueen_Click(object sender, EventArgs e)
        {
            txtqueen.Text = "";
            txtqueen.Focus();
        }

        private void check_queen_CheckedChanged(object sender, EventArgs e)
        {
            if (check_queen.Checked == true)
            {
                txtqueen.Enabled = true;
            }
            if (check_queen.Checked == false)
            {
                txtqueen.Enabled = false;
                txtqueen.Text = "0";
            }
        } 

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
           rtfReceipt.Paste();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveflie = new SaveFileDialog();

            saveflie.FileName = "Notepade Text";
            saveflie.Filter = "Text(*.txt)|*.txt|all file (*.*)|*.*";

            if(saveflie.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveflie.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text(*.txt)|*.txt|all file (*.*)|*.*";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openFile.FileName;
                MessageBox.Show(strfilename);
            }
        }

        private void rtfReceipt_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnreceipt_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
            rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("\t\t\t" + "Thiraphat" + Environment.NewLine);

            rtfReceipt.AppendText("----------------------------------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Latte"+"\t\t\t\t\t\t\t" + txtlatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Espresso" + "\t\t\t\t\t\t" + txtes.Text + Environment.NewLine);
            rtfReceipt.AppendText("Ice Latte" + "\t\t\t\t\t\t\t" + txticelatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Capuccino" + "\t\t\t\t\t\t" + txtcap.Text + Environment.NewLine);
            rtfReceipt.AppendText("Afican Coffee" + "\t\t\t\t\t\t" + txtaf.Text + Environment.NewLine);
            rtfReceipt.AppendText("American Coffee" + "\t\t\t\t\t\t" + txtamerican.Text + Environment.NewLine);
            rtfReceipt.AppendText("Vale Coffee" + "\t\t\t\t\t\t" + txtvale.Text + Environment.NewLine);
            rtfReceipt.AppendText("Ice Capuccino" + "\t\t\t\t\t\t" + txticecap.Text + Environment.NewLine);
            rtfReceipt.AppendText("Coffee Cake" + "\t\t\t\t\t\t" + txtcake.Text + Environment.NewLine);
            rtfReceipt.AppendText("Red Velvet" + "\t\t\t\t\t\t" + txtred.Text + Environment.NewLine);
            rtfReceipt.AppendText("Black Forest" + "\t\t\t\t\t\t" + txtblack.Text + Environment.NewLine);
            rtfReceipt.AppendText("Boston Cream" + "\t\t\t\t\t\t" + txtboston.Text + Environment.NewLine);
            rtfReceipt.AppendText("Lagos Chocolate" + "\t\t\t\t\t\t" + txtlagos.Text + Environment.NewLine);
            rtfReceipt.AppendText("Kilburn Chocolate" + "\t\t\t\t\t" + txtkilburn.Text + Environment.NewLine);
            rtfReceipt.AppendText("Carlton Hill Chocolate" + "\t\t\t\t\t" + txtcarlton.Text + Environment.NewLine);
            rtfReceipt.AppendText("Queen's Park Chocolate" + "\t\t\t\t\t" + txtqueen.Text + Environment.NewLine);

            //---------------------------------------------------------------------------------------------------------------------------------------------

            rtfReceipt.AppendText("----------------------------------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Tax \t\t\t\t" + lbltax.Text + Environment.NewLine);
            rtfReceipt.AppendText("Subtotal\t\t\t\t" + lblTotalSub.Text + Environment.NewLine);
            rtfReceipt.AppendText("Total Cost\t\t\t" + lbltotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("----------------------------------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lbldate.Text + "\t\t\t" + lbltime.Text);

        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            double tax;
            tax = 7;
            double latte, es, icelatte, vale, af, american, cap, icecap;
            double coffcake, red, black, boston, lagos, kilburn, carlton, queen;
            
            latte = 45;
            es = 70;
            icelatte = 55;
            vale = 40;
            af = 35;
            american = 50;
            cap = 65;
            icecap = 60;
            double latte_coff = Convert.ToDouble(txtlatte.Text);
            double es_coff = Convert.ToDouble(txtes.Text);
            double icelatte_coff = Convert.ToDouble(txticelatte.Text);
            double vale_coff = Convert.ToDouble(txtvale.Text);
            double af_coff = Convert.ToDouble(txtaf.Text);
            double american_coff = Convert.ToDouble(txtamerican.Text);
            double cap_coff = Convert.ToDouble(txtcap.Text);
            double icecap_coff = Convert.ToDouble(txticecap.Text);

            coffcake = 75;
            red = 80;
            black = 65;
            boston = 70;
            lagos = 85;
            kilburn = 70;
            carlton = 60;
            queen = 90;
            double coff_cake = Convert.ToDouble(txtcake.Text);
            double red_cake = Convert.ToDouble(txtred.Text);
            double black_cake = Convert.ToDouble(txtblack.Text);
            double boston_cake = Convert.ToDouble(txtboston.Text);
            double lagos_cake = Convert.ToDouble(txtlagos.Text);
            double kilburn_cake = Convert.ToDouble(txtkilburn.Text);
            double carlton_cake = Convert.ToDouble(txtcarlton.Text);
            double queen_cake = Convert.ToDouble(txtqueen.Text);

            Class1 eat_in_cafe = new Class1(latte_coff, es_coff, icelatte, cap_coff, af_coff, american_coff, vale_coff, icecap_coff, coff_cake, red_cake, black_cake, boston_cake, lagos_cake, kilburn_cake, carlton_cake, queen_cake);
            double cost_OFdrink = (latte_coff * latte) + (es_coff * es) + (icelatte_coff * icelatte) + (cap_coff * cap) + (american_coff * american) + (vale_coff * vale) + (icecap_coff * icecap);
            lblcostOFdrink.Text = Convert.ToString(cost_OFdrink);

            double cost_OFcake = (coff_cake * coffcake) + (red_cake * red) + (black_cake * black) + (boston_cake * boston) + (lagos_cake * lagos) + (kilburn_cake * kilburn) + (carlton_cake * carlton) + (queen_cake * queen);
            lblcostOFcake.Text = Convert.ToString(cost_OFcake);

            double service_chg = Convert.ToDouble(lblservice.Text);
            lblTotalSub.Text = Convert.ToString(cost_OFcake + cost_OFdrink + service_chg);
            lbltax.Text = Convert.ToString(((cost_OFcake + cost_OFdrink + service_chg) * tax)/100);
            double itax = Convert.ToDouble(lbltax.Text);
            lbltotal.Text = Convert.ToString(cost_OFcake + cost_OFdrink + service_chg);

            //lblcostOFcake.Text = String.Format("{0.00}", cost_OFcake);
            //lblcostOFdrink.Text = String.Format("{0.00}", cost_OFdrink);
            //lblservice.Text = String.Format("{0.00}", service_chg);
            //lblTotalSub.Text = String.Format("{0.00}", (cost_OFcake + cost_OFdrink + service_chg));
            //lbltax.Text = String.Format("{0.00}", itax);
            //lbltotal.Text = String.Format("{0.00}", (lbltotal.Text));
        }

        private void lbltime_Click(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongDateString();
        }
    }
}
