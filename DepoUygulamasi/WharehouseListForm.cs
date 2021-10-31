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
    public partial class WharehouseListForm : Form
    {
        public WharehouseListForm()
        {
            InitializeComponent();
        }

        //Ana form property
        public MainForm mainForm { get; set; }

        private void WharehouseListForm_Load(object sender, EventArgs e)
        {
            FormFill();
        }

        void FormFill()
        {
            lstWharehouseList.Items.Clear();
            string[] depolar = mainForm.GetWharehouseList();
            for (int i = 0; i < depolar.Length; i++)
            {
                lstWharehouseList.Items.Add(depolar[i]);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult deleteResult = mainForm.HowToDeleteMessage();
            if (deleteResult == DialogResult.OK)
            {
                if (lstWharehouseList.SelectedIndex > -1)
                {
                    string wharehouseName = lstWharehouseList.SelectedItem.ToString();
                    bool result = mainForm.DeleteWharehouse(wharehouseName);
                    if (result)
                    {
                        MessageBox.Show("Silme işlemi başarılı");
                        //Eğer silme işlemi başarılı ise ekradaki listbox temizleyip yeniden dolduruyorum 
                        FormFill();
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi sırasında hata meydana geldi");
                    }
                }
            }
        }
    }
}
