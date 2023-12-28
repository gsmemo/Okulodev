using OkulApp.MODEL;
using OkulAppBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okulodev
{
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {

            try
            {
                var obl = new OgretmenBL();
                bool sonuc = obl.OgretmenEkle(new Ogretmen { ad = txt_ad.Text.Trim(), soyad = txt_soyad.Text.Trim(), tc = txt_tc.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı!" : "Ekleme Başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numaralı ögretmen daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show("Veritabanı hatası");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!!");
            }
        }


    }


    interface ITransfer
    {
        int Eft(string gondericiiban, string aliciiban, double tutar);
        int Havale(string gondericiiban, string aliciiban, double tutar);

    }

    class Transfer : ITransfer
    {
        public int Eft(string gondericiiban, string aliciiban, double tutar)
        {
            throw new NotImplementedException();
        }

        public int Havale(string gondericiiban, string aliciiban, double tutar)
        {
            throw new NotImplementedException();
        }


    }
}

        
    


        