using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace hastane_otomasyonu
{
    public class sqlKisi
    {
        // doktor ekle
        // TC, ad, soyad
        // tel, mail
        // poliklinik, brans
        // il, ilce, mahalle, sokak, bina_no, daire_no

        public static void KisiEkle(string kisiBilgisi, string tc, string ad, string soyad, string tel, string mail, DateTimePicker dogum_tarihi, string cinsiyet, string brans, string sifre)
        {
            string query = null;
            string dogumTarihiStr = sqlGenel.DateTimePickerToDateString(dogum_tarihi);

            if (kisiBilgisi == "doktor")
            {
                query = "INSERT INTO doktorlar (doktor_tc, ad, soyad, tel, email, dogum_tar, cinsiyet, brans, sifre) VALUES (@tc, @adi, @soyadi, @tel, @email, @dogum_tarihi, @cinsiyet, @brans, @sifre)";
            }
            else if (kisiBilgisi == "hasta")
            {
                query = "INSERT INTO hastalar (hasta_tc, ad, soyad, tel, email, dogum_tar, cinsiyet, sifre) VALUES (@tc, @adi, @soyadi, @tel, @email, @dogum_tarihi, @cinsiyet, @sifre)";
            }
            else if (kisiBilgisi == "personel")
            {
                query = "INSERT INTO personel (personel_tc, ad, soyad, tel, email, dogum_tar, cinsiyet, sifre) VALUES (@tc, @adi, @soyadi, @tel, @email, @dogum_tarihi, @cinsiyet, @sifre)";
            }

            
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
                        command.Parameters.AddWithValue("@tc", tc);
                        command.Parameters.AddWithValue("@adi", ad);
                        command.Parameters.AddWithValue("@soyadi", soyad);
                        command.Parameters.AddWithValue("@tel", tel);
                        command.Parameters.AddWithValue("@email", mail);
                        if (brans != "")
                        {
                            command.Parameters.AddWithValue("@brans", brans);
                        }
                        command.Parameters.AddWithValue("@dogum_tarihi", dogumTarihiStr);
                        command.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        command.Parameters.AddWithValue("@sifre", sifre);

                        // Komutu çalıştır
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    connection.Close();
                    MessageBox.Show("Kişi bilgisi başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void AdresEkle(string kisiBilgisi, string il, string ilce, string mahalle, string sokak, string bina_no, string daire_no, string acik_adres, string tc)
        {
            string query = "INSERT INTO adres (il_adi, ilce_adi, mahalle_adi, sokak_adi, bina_no, daire_no, acik_adres, " + kisiBilgisi + "_tc) VALUES (@il, @ilce, @mahalle, @sokak, @bina_no, @daire_no, @acikAdres, @tc)";

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
                        command.Parameters.AddWithValue("@il", il);
                        command.Parameters.AddWithValue("@ilce", ilce);
                        command.Parameters.AddWithValue("@mahalle", mahalle);
                        command.Parameters.AddWithValue("@sokak", sokak);
                        command.Parameters.AddWithValue("@bina_no", bina_no);
                        command.Parameters.AddWithValue("@daire_no", daire_no);
                        command.Parameters.AddWithValue("@acikAdres", acik_adres);
                        command.Parameters.AddWithValue("@tc", tc);

                        // Komutu çalıştır
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    connection.Close();
                    MessageBox.Show("Adres bilgisi başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public static DataTable KisiGetir(string kisiBilgisi)
        {
            DataTable table = new DataTable();
            string query = null;

            if (kisiBilgisi == "doktor")
            {
                query = "select * from doktorlar, adres where doktorlar.doktor_tc = adres.doktor_tc";
            }
            else if (kisiBilgisi == "hasta")
            {
                query = "select * from hastalar, adres where hastalar.hasta_tc = adres.hasta_tc";
            }
            else if (kisiBilgisi == "personel")
            {
                query = "select * from personel, adres where personel.personel_tc = adres.personel_tc";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return table;
        }

        public static DataTable KisiGetir(string kisiBilgisi, List<Control> componentsForKisi)
        {
            DataTable table = new DataTable();
            string query = null;


            if (kisiBilgisi == "doktor")
            {
                query = "select * from doktorlar, adres where doktorlar.doktor_tc = adres.doktor_tc ";
            }
            else if (kisiBilgisi == "hasta")
            {
                query = "select * from hastalar, adres where hastalar.hasta_tc = adres.hasta_tc ";
            }
            else if (kisiBilgisi == "personel")
            {
                query = "select * from personel, adres where personel.personel_tc = adres.personel_tc ";
            }


            foreach (var ctrl in componentsForKisi)
            {
                if (ctrl is TextBox && !string.IsNullOrEmpty(((TextBox)ctrl).Text))
                {
                    TextBox txtBox = (TextBox)ctrl;
                    query += "AND " + txtBox.Name + " LIKE N'%" + txtBox.Text + "%' ";
                }

                if (ctrl is ComboBox && !string.IsNullOrEmpty(((ComboBox)ctrl).Text))
                {
                    ComboBox cmbBox = (ComboBox)ctrl;
                    query += "AND " + cmbBox.Name + " = N'" + cmbBox.Text + "' ";
                }

                if (ctrl is RadioButton && !string.IsNullOrEmpty(((RadioButton)ctrl).Text))
                {
                    RadioButton radio = (RadioButton)ctrl;
                    query += "AND cinsiyet = N'" + radio.Text + "' ";
                }
            }

            MessageBox.Show(query);

            try
            {
                using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return table;
        }



        // doktor düzenle
        // TC, ad, soyad
        // tel, mail
        // poliklinik, brans
        // il, ilce, mahalle, sokak, bina_no, daire_no
        public static void DataGridViewToCellList(DataGridView dataGridView, string kisiBilgisi)
        {
            List<string> cellValues = new List<string>();
            string queryKisi = null;

            if (kisiBilgisi == "doktor")
            {
                queryKisi = "UPDATE doktorlar SET ";
            }
            if (kisiBilgisi == "hasta")
            {
                queryKisi = "UPDATE hastalar SET ";
            }
            if (kisiBilgisi == "personel")
            {
                queryKisi = "UPDATE personel SET ";
            }
            string queryAdres = "UPDATE adres SET ";

            int sayac = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cellValues.Add(cell.Value?.ToString());
                }

                bool sayac2 = true;
                string tc = "";
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    string kolonAdi = column.HeaderText;
                    if (column.HeaderText == "il_adi" || sayac2 == false && kolonAdi != "doktor_tc1" && kolonAdi != "hasta_tc1" && kolonAdi != "personel_tc1")
                    {
                        queryAdres += kolonAdi + " = '" + cellValues[sayac] + "', ";
                        sayac++;
                        sayac2 = false;
                    }
                    else if (sayac2 == true)
                    {
                        if (kolonAdi != "adres_id")
                        {
                            if (kolonAdi == "dogum_tar")
                            {
                                string dateChanged = sqlGenel.DateForSqlConvert(cellValues[sayac]);
                                queryKisi += kolonAdi + " = '" + dateChanged + "', ";
                            }
                            else
                            {
                                queryKisi += kolonAdi + " = '" + cellValues[sayac] + "', ";
                            }

                            if (kolonAdi == "doktor_tc" || kolonAdi == "hasta_tc" || kolonAdi == "personel_tc")
                            {
                                tc = cellValues[sayac];
                            }
                        }
                        sayac++;
                    }
                    else
                    {
                        sayac++;
                    }
                }

                queryKisi = queryKisi.Substring(0, queryKisi.Length - 2);
                queryKisi += " WHERE " + kisiBilgisi + "_tc = '" + tc + "'";

                // TO-DO: doktor mu hasta mı personel mi koşulunu yapıcam
                queryAdres = queryAdres.Substring(0, queryAdres.Length - 2);
                queryAdres += " WHERE " + kisiBilgisi + "_tc = '" + tc + "'";

                MessageBox.Show(queryKisi);
                MessageBox.Show(queryAdres);

                using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        using (SqlCommand command = new SqlCommand(queryKisi, connection, transaction))
                        {
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
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

                using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        using (SqlCommand command = new SqlCommand(queryAdres, connection, transaction))
                        {
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
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
                if (kisiBilgisi == "doktor")
                {
                    queryKisi = "UPDATE doktorlar SET ";
                }
                if (kisiBilgisi == "hasta")
                {
                    queryKisi = "UPDATE hastalar SET ";
                }
                if (kisiBilgisi == "personel")
                {
                    queryKisi = "UPDATE personel SET ";
                }

                queryAdres = "UPDATE adres SET ";
            }
        }


        public static void KisiGuncelle(string kisiBilgisi, List<Control> componentsForKisi, List<Control> componentsForAdres)
        {
            DataTable table = new DataTable();
            string queryKisi = null;
            string queryAdres = null;


            if (kisiBilgisi == "doktor")
            {
                queryKisi = "select * from doktorlar, adres where doktorlar.doktor_tc = adres.doktor_tc ";
                queryKisi = "UPDATE doktorlar SET ";
                queryAdres = "UPDATE adres SET ";
            }
            else if (kisiBilgisi == "hasta")
            {
                queryKisi = "select * from hastalar, adres where hastalar.hasta_tc = adres.hasta_tc ";
                queryAdres = "UPDATE adres SET ";
            }
            else if (kisiBilgisi == "personel")
            {
                queryKisi = "select * from personel, adres where personel.personel_tc = adres.personel_tc ";
                queryAdres = "UPDATE adres SET ";
            }


            foreach (var ctrl in componentsForKisi)
            {
                if (ctrl is TextBox && !string.IsNullOrEmpty(((TextBox)ctrl).Text))
                {
                    TextBox txtBox = (TextBox)ctrl;
                    queryKisi += "AND " + txtBox.Name + " LIKE N'%" + txtBox.Text + "%' ";
                    queryKisi += txtBox.Name + " = " + txtBox.Text + "', ";
                }

                if (ctrl is ComboBox && !string.IsNullOrEmpty(((ComboBox)ctrl).Text))
                {
                    ComboBox cmbBox = (ComboBox)ctrl;
                    queryKisi += cmbBox.Name + " = " + cmbBox.Text + "', ";
                }

                if (ctrl is RadioButton && !string.IsNullOrEmpty(((RadioButton)ctrl).Text))
                {
                    RadioButton radio = (RadioButton)ctrl;
                    queryKisi += "cinsiyet = N'" + radio.Text + "', ";
                }
            }


            foreach (var ctrl in componentsForAdres)
            {
                if (ctrl is TextBox && !string.IsNullOrEmpty(((TextBox)ctrl).Text))
                {
                    TextBox txtBox = (TextBox)ctrl;
                    queryAdres += "AND " + txtBox.Name + " LIKE N'%" + txtBox.Text + "%' ";
                    queryAdres += txtBox.Name + " = " + txtBox.Text + "', ";
                }

                if (ctrl is ComboBox && !string.IsNullOrEmpty(((ComboBox)ctrl).Text))
                {
                    ComboBox cmbBox = (ComboBox)ctrl;
                    queryAdres += cmbBox.Name + " = " + cmbBox.Text + "', ";
                }

                if (ctrl is RadioButton && !string.IsNullOrEmpty(((RadioButton)ctrl).Text))
                {
                    RadioButton radio = (RadioButton)ctrl;
                    queryAdres += "cinsiyet = N'" + radio.Text + "', ";
                }
            }


            queryKisi = queryKisi.TrimEnd(',');
            queryKisi += "WHERE kisi_tc = ''";

            // TO-DO: doktor mu hasta mı personel mi koşulunu yapıcam
            queryAdres = queryAdres.TrimEnd(',');
            queryAdres += "WHERE kisi_tc = ''";

            MessageBox.Show(queryKisi);


            using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    using (SqlCommand command = new SqlCommand(queryKisi, connection, transaction))
                    {
                        command.ExecuteNonQuery();
                        transaction.Commit();
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }

    }
}
