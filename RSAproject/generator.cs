using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAproject
{
    public partial class generator : Form
    {
        public string ReturnValue1 { get; set; }
        public string ReturnValue2 { get; set; }
        public generator()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            long p = helper.largePrimeGenerator(
                Int64.Parse(tbLLp.Text),
                Int64.Parse(tbULp.Text)
                ) ;
            long q = helper.largePrimeGenerator(
                Int64.Parse(tbLLq.Text),
                Int64.Parse(tbULq.Text)
                );
            tbResp.Text = p.ToString();
            tbResq.Text = q.ToString();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.ReturnValue1 = tbResp.Text;
            this.ReturnValue2 = tbResq.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
