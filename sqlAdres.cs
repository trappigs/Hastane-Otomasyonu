using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_otomasyonu
{
    public class sqlAdres
    {
        // sorgu yazacağız, gönderilen comboboxa il, ilce ve mahalleleri dolduracak
        static public void VeriDoldur(string query, string adSutun, string idSutun, string tabloAdi, ComboBox comboBox)
        {
            // Veritabanı bağlantısı oluştur
            using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
            {
                // Veri adaptörü oluştur
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    // DataSet oluştur
                    DataSet dataSet = new DataSet();
                    // Verileri doldur
                    adapter.Fill(dataSet, tabloAdi);

                    // ComboBox'ı doldur
                    comboBox.DisplayMember = adSutun; // Görüntülenecek değer
                    comboBox.ValueMember = idSutun;    // Arkaplanda saklanacak değer
                    comboBox.DataSource = dataSet.Tables[tabloAdi];
                }
            }
        }

        // ilk başta illeri doldurmak için form_load metodunda kullanıcam
        static public void ilListele(ComboBox ilComboBox)
        {
            VeriDoldur("select il_id, il_adi from iller", "il_adi", "il_id", "iller", ilComboBox);
        }


        // ilIndexChanged'e yazacağım kod
        static public void ilceListele(ComboBox ilComboBox, ComboBox ilceComboBox)
        {
            VeriDoldur("select ilce_id, ilce_adi from ilceler where il_id = " + ilComboBox.SelectedValue.ToString(), "ilce_adi", "ilce_id", "ilceler", ilceComboBox);
        }


        // ilceIndexChanged'e yazacağım kod
        static public void mahalleListele(ComboBox ilceComboBox, ComboBox mahalleComboBox)
        {
            VeriDoldur("select mahalle_adi, mahalle_id from mahalle where ilce_id = " + ilceComboBox.SelectedValue.ToString(), "mahalle_adi", "mahalle_id", "mahalle", mahalleComboBox);
        }

    }
}
