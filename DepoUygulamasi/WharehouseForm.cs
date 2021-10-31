using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoUygulamasi
{
    public partial class WharehouseForm : Form
    {
        public WharehouseForm()
        {
            InitializeComponent();
        }

        //Ana formu buraya göndereceğiz
        public MainForm mainForm { get; set; } //property

        private void WharehouseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string wharehouse = txtWharehouse.Text;
                mainForm.WharehouseAdd(wharehouse);
                MessageBox.Show("Kayıt işlemi başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
