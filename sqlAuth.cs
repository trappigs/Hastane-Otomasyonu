using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_otomasyonu
{
    public class sqlAuth
    {
        public static string kisi;
        public static string tc;

        public static bool kisiGiris(string kisiBilgisi, TextBox tcTxt, TextBox sifre)
        {
            // hastalar tablosundaki tc ve sifre alanlarına göre sorgu yap
            // eğer sorgu sonucu 1 satır dönerse hasta giriş yapmış olacak
            // eğer sorgu sonucu 0 satır dönerse hasta giriş yapamamış olacak
            // şimdi kodlarını yazalım
            string checkQuery = null;
            if (kisiBilgisi == "hasta")
            {
                checkQuery = "select COUNT(*) from hastalar where hasta_tc = @kisiTc and sifre = @sifre";
            }
            else if (kisiBilgisi == "doktor")
            {
                checkQuery = "select COUNT(*) from doktorlar where doktor_tc = @kisiTc and sifre = @sifre";
            }
            else if (kisiBilgisi == "personel")
            {
                checkQuery = "select COUNT(*) from personel where personel_tc = @kisiTc and sifre = @sifre";
            }
            tc = tcTxt.Text;
            using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
            {
                connection.Open();
                int existingRecords;
                SqlCommand cmd = new SqlCommand(checkQuery, connection);
                try
                {
                    cmd.Parameters.AddWithValue("@kisiTc", tcTxt.Text);
                    cmd.Parameters.AddWithValue("@sifre", sifre.Text);

                    existingRecords = (int)cmd.ExecuteScalar();
                    connection.Close();

                    if (existingRecords == 0)
                        return false;
                    else if (existingRecords == 1)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    }
}
