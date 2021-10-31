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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        //Sadece bu form üzerinden gözükmesi için private dedim
        private string[] depolar = new string[0];
        //public genel anlamında diğer formlardan da görünmesi için
        public void WharehouseAdd(string wharehuse)
        {
            if (!depolar.Contains(wharehuse)) //aynı depo tekrar eklenmesin diye kontrol yapıyoruz
            {
                Array.Resize(ref depolar, depolar.Length + 1);
                depolar[depolar.Length - 1] = wharehuse;
            }
            else
            {
                throw new Exception("Bu depo daha önce eklenmiş");
            }
        }

        /// <summary>
        /// Depo Listesini döner
        /// </summary>
        /// <returns></returns>
        public string[] GetWharehouseList()
        {
            return this.depolar;
        }

        public bool DeleteWharehouse(string wharehouse)
        {
            int index = Array.IndexOf(depolar, wharehouse); //gönderilen string dizi içerisinde hangi index yer alıyor.
            if (index > -1)
            {
                Array.Clear(depolar, index, 1);
                depolar = ArrayNullClear(depolar);
                return true;
            }
            else
            {
                return false;
            }
        }
        private string[] ArrayNullClear(string[] array)
        {
            string[] temp = new string[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (!string.IsNullOrEmpty(array[i]))
                {
                    Array.Resize(ref temp, temp.Length + 1);
                    temp[temp.Length - 1] = array[i];
                }
            }
            return temp;
        }


        public DialogResult HowToDeleteMessage()
        {
            DialogResult result = MessageBox.Show("Kaydı silmek istiyor musunuz", "Depo Uygulaması", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return result;
        }


        private void yeniDepoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wharehouseForm = new WharehouseForm();
            wharehouseForm.mainForm = this; //Anaformu açtığımız diğer formun property kısmına gönderdik
            wharehouseForm.ShowDialog();
        }

        private void depoListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new WharehouseListForm();
            form.mainForm = this;
            form.ShowDialog();
        }
    }
}
