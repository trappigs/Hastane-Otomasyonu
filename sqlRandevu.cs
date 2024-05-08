using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace hastane_otomasyonu
{
    public class sqlRandevu
    {
        public static void RandevuGetir(DataGridView dgv, List<Control> parametreler)
        {
            string query = "select doktorlar.doktor_tc, brans, aktiflik, randevu_gun, randevu_saat FROM randevu, doktorlar WHERE hasta_tc = '" + sqlAuth.tc + "' AND randevu.doktor_tc = doktorlar.doktor_tc ";

            foreach (var ctrl in parametreler)
            {
                if (ctrl is ComboBox && !string.IsNullOrEmpty(((ComboBox)ctrl).Text))
                {
                    ComboBox cmbBox = (ComboBox)ctrl;
                    if (cmbBox.Name == "doktor_tc")
                    {
                        if (cmbBox.SelectedValue != null)
                        {
                            query += "AND doktorlar.doktor_tc = '" + cmbBox.SelectedValue.ToString() + "' ";
                        }
                    }
                    else
                    {
                        query += "AND " + cmbBox.Name + " = '" + cmbBox.Text + "' ";
                    }
                }
            }
            MessageBox.Show(query);
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@hastaTc", sqlAuth.tc);

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        dt = new DataTable();
                        dt.Load(reader);
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                dgv.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
            //foreach (DataGridViewRow row in dataGridView.Rows)
            //{
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        cellValues.Add(cell.Value?.ToString());
            //    }

            //    bool sayac2 = true;
            //    string tc = "";
            //    foreach (DataGridViewColumn column in dataGridView.Columns)
            //    {
            //        string kolonAdi = column.HeaderText;
            //        if (column.HeaderText == "il_adi" || sayac2 == false && kolonAdi != "doktor_tc1" && kolonAdi != "hasta_tc1" && kolonAdi != "personel_tc1")
            //        {
            //            queryAdres += kolonAdi + " = '" + cellValues[sayac] + "', ";
            //            sayac++;
            //            sayac2 = false;
            //        }
            //        else if (sayac2 == true)
            //        {
            //            if (kolonAdi != "adres_id")
            //            {
            //                if (kolonAdi == "dogum_tar")
            //                {
            //                    string dateChanged = sqlGenel.DateForSqlConvert(cellValues[sayac]);
            //                    queryKisi += kolonAdi + " = '" + dateChanged + "', ";
            //                }
            //                else
            //                {
            //                    queryKisi += kolonAdi + " = '" + cellValues[sayac] + "', ";
            //                }

            //                if (kolonAdi == "doktor_tc" || kolonAdi == "hasta_tc" || kolonAdi == "personel_tc")
            //                {
            //                    tc = cellValues[sayac];
            //                }
            //            }
            //            sayac++;
            //        }
            //        else
            //        {
            //            sayac++;
            //        }
            //    }

            //    queryKisi = queryKisi.Substring(0, queryKisi.Length - 2);
            //    queryKisi += " WHERE " + kisiBilgisi + "_tc = '" + tc + "'";

            //    // TO-DO: doktor mu hasta mı personel mi koşulunu yapıcam
            //    queryAdres = queryAdres.Substring(0, queryAdres.Length - 2);
            //    queryAdres += " WHERE " + kisiBilgisi + "_tc = '" + tc + "'";

            //    MessageBox.Show(queryKisi);
            //    MessageBox.Show(queryAdres);

            //    using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
            //    {
            //        connection.Open();
            //        SqlTransaction transaction = connection.BeginTransaction();
            //        try
            //        {
            //            using (SqlCommand command = new SqlCommand(queryKisi, connection, transaction))
            //            {
            //                command.ExecuteNonQuery();
            //            }
            //            transaction.Commit();
            //        }
            //        catch (Exception ex)
            //        {
            //            transaction.Rollback();
            //            MessageBox.Show(ex.Message);
            //        }
            //        finally
            //        {
            //            connection.Close();
            //        }
            //    }

            //    using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
            //    {
            //        connection.Open();
            //        SqlTransaction transaction = connection.BeginTransaction();
            //        try
            //        {
            //            using (SqlCommand command = new SqlCommand(queryAdres, connection, transaction))
            //            {
            //                command.ExecuteNonQuery();
            //            }
            //            transaction.Commit();
            //        }
            //        catch (Exception ex)
            //        {
            //            transaction.Rollback();
            //            MessageBox.Show(ex.Message);
            //        }
            //        finally
            //        {
            //            connection.Close();
            //        }
            //    }
            //    if (kisiBilgisi == "doktor")
            //    {
            //        queryKisi = "UPDATE doktorlar SET ";
            //    }
            //    if (kisiBilgisi == "hasta")
            //    {
            //        queryKisi = "UPDATE hastalar SET ";
            //    }
            //    if (kisiBilgisi == "personel")
            //    {
            //        queryKisi = "UPDATE personel SET ";
            //    }

            //    queryAdres = "UPDATE adres SET ";
            //}
        }

        public static void RandevuGetir(ComboBox doktor, ComboBox randevuCmb)
        {
            try
            {
                string query = "select randevu_saat from randevu WHERE hasta_tc = @hastaTc and doktor_tc = @doktorTc and aktiflik = 1";

                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (doktor.SelectedValue == null)
                    {
                        MessageBox.Show("Doktor seçilmedi.");
                        return;
                    }
                    cmd.Parameters.AddWithValue("@doktorTc", doktor.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@hastaTc", sqlAuth.tc);

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        dt = new DataTable();
                        dt.Load(reader);
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                randevuCmb.DataSource = dt;
                randevuCmb.DisplayMember = "randevu_saat";
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static void RandevuAl(ComboBox doktor, DateTimePicker secilenRandevuTarihi, ComboBox secilenSaat, string hasta_tc)
        {
            // TO-DO: randevu tablosundaki aktiflik satırını değiştireceğim
            DateTime secilenTarih = secilenRandevuTarihi.Value;
            string secilenTarihString = secilenTarih.ToString("yyyy-MM-dd");

            string query = "UPDATE randevu SET aktiflik = 1, hasta_tc = @hastaTc WHERE doktor_tc = @doktorTc AND randevu_gun = @randevuGun AND randevu_saat = @randevuSaat and aktiflik = 0";

            using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
            {
                SqlTransaction transaction = null;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    using (SqlCommand command = new SqlCommand(query, connection, transaction))
                    {
                        // Parametreler oluştur
                        if (doktor.SelectedValue == null)
                        {
                            MessageBox.Show("Doktor seçilmedi.");
                            return;
                        }
                        command.Parameters.AddWithValue("@doktorTc", doktor.SelectedValue.ToString());
                        command.Parameters.AddWithValue("@randevuGun", secilenTarihString);
                        command.Parameters.AddWithValue("@randevuSaat", secilenSaat.Text);
                        command.Parameters.AddWithValue("@hastaTc", hasta_tc);
                        // Komutu çalıştır
                        command.ExecuteNonQuery();
                        MessageBox.Show("Randevu başarıyla alındı.");
                    }
                    transaction.Commit();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }


        }



        public static void ComboBoxaRandevuGetir(ComboBox randevuSaatleri, ComboBox doktor, DateTimePicker secilenRandevuTarihi)
        {
            try
            {
                DateTime secilenTarih = secilenRandevuTarihi.Value;
                string secilenTarihString = secilenTarih.ToString("yyyy-MM-dd");
                string doktorTcleriQuery = "SELECT randevu_saat from RANDEVU where doktor_tc = @doktorTc and randevu_gun = @secilenTarih and aktiflik != 1";

                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(doktorTcleriQuery, connection);
                    if (doktor.SelectedValue == null)
                    {
                        MessageBox.Show("Doktor seçilmedi.");
                        return;
                    }
                    cmd.Parameters.AddWithValue("@doktorTc", doktor.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@secilenTarih", secilenTarihString);
                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        dt = new DataTable();
                        dt.Load(reader);
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                randevuSaatleri.DataSource = dt;
                randevuSaatleri.DisplayMember = "randevu_saat";
                randevuSaatleri.ValueMember = "randevu_saat";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void RandevuDoldurGenel()
        {
            List<string> doktorTcList = new List<string>();
            doktorTcList = DoktorTcleri();

            List<string> randevuSaatleri = new List<string>();
            randevuSaatleri = RandevuVakitleri();

            List<string> randevuGunleri = new List<string>();
            randevuGunleri = RandevuGunleri();


            // TO-DO:
            // foreach doktorlar
            // foreach randevu günleri
            // foreach randevu saatleri
            foreach (var doktorTc in doktorTcList)
            {
                foreach (var randevuGun in randevuGunleri)
                {
                    foreach (var randevuSaat in randevuSaatleri)
                    {
                        int? recordCount = CheckRecordsCount(doktorTc, randevuGun, randevuSaat);
                        if (recordCount != null && recordCount == 0)
                        {
                            RandevuDoldur(doktorTc, randevuGun, randevuSaat);
                        }
                    }
                }
            }
        }

        public static void RandevuDoldur(string doktorTc, string randevuGun, string randevuSaat)
        {
            string query = "INSERT INTO randevu (doktor_tc, aktiflik, randevu_gun, randevu_saat) " +
                "VALUES (@doktor_tc, 0, @randevu_gun, @randevu_saat)";


            using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
            {
                // Bağlantıyı aç
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection, transaction))
                    {
                        // Parametreler oluştur
                        cmd.Parameters.AddWithValue("@doktor_tc", doktorTc);
                        cmd.Parameters.AddWithValue("@randevu_gun", randevuGun);
                        cmd.Parameters.AddWithValue("@randevu_saat", randevuSaat);


                        // Komutu çalıştır
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        public static int? CheckRecordsCount(string doktorTc, string randevuGun, string randevuSaat)
        {
            // sonuç 0 olmalı
            string checkQuery = "SELECT COUNT(*) FROM randevu WHERE doktor_tc = @doktor_tc AND randevu_gun = @randevu_gun" +
                " AND randevu_saat = @randevu_saat AND aktiflik = 0";

            using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
            {
                connection.Open();
                int existingRecords = 0;
                SqlCommand cmd = new SqlCommand(checkQuery, connection);
                try
                {

                    cmd.Parameters.AddWithValue("@doktor_tc", doktorTc);
                    cmd.Parameters.AddWithValue("@randevu_gun", randevuGun);
                    cmd.Parameters.AddWithValue("@randevu_saat", randevuSaat);

                    existingRecords = (int)cmd.ExecuteScalar();
                    connection.Close();
                    return existingRecords;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

        public static List<string> DoktorTcleri()
        {
            // doktor-tc: distinct, count
            // doktortclerini bir listeye dolduracağız
            string doktorTcleriQuery = "SELECT DISTINCT doktor_tc from doktorlar";
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(doktorTcleriQuery, connection);
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(reader);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    connection.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            List<string> doktorList = new List<string>();
            // doktor tc leri doktorList listesine dolduruldu
            foreach (DataRow item in dt.Rows)
            {
                doktorList.Add(item["doktor_tc"].ToString());
            }
            return doktorList;
        }


        public static List<string> RandevuGunleri()
        {
            DateTime baslangicTarihi = DateTime.Today;
            DateTime bitisTarihi = baslangicTarihi.AddDays(7);

            List<string> randevuTarihi = new List<string>();

            for (DateTime date = baslangicTarihi; date <= bitisTarihi; date = date.AddDays(1))
            {
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (int.Parse(date.Month.ToString()) < 10)
                    {
                        randevuTarihi.Add(date.Year.ToString() + "-0" + date.Month.ToString() + "-" + date.Day.ToString());
                    }
                    else
                    {
                        randevuTarihi.Add(date.Year.ToString() + "-" + date.Month.ToString() + "-" + date.Day.ToString());
                    }
                }
            }

            return randevuTarihi;
        }


        public static List<string> RandevuVakitleri()
        {
            List<string> saatList = new List<string>
            {
                "09",
                "10",
                "11",
                "13",
                "14",
                "15",
                "16"
            };

            List<string> dakikaList = new List<string>
            {
                "00",
                "30"
            };

            List<string> vakit = new List<string>();

            foreach (var item in saatList)
            {
                foreach (var item2 in dakikaList)
                {
                    vakit.Add(item + ":" + item2 + ":00");
                }
            }

            return vakit;
        }

    }
}
