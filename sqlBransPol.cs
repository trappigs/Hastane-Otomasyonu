using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_otomasyonu
{
    public class sqlBransPol
    {
        // TO DO: poliklinik ekle
        // TO DO: branş ekle

        public static void polEkle(string poliklinikAd)
        {
            string query = "INSERT INTO poliklinikler (poliklinik) VALUES (@poliklinikAd)";

            using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
            {
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection, transaction))
                    {
                        // Parametreler oluştur
                        command.Parameters.AddWithValue("@poliklinikAd", poliklinikAd);

                        // Bağlantıyı aç
                        connection.Open();

                        // Komutu çalıştır
                        command.ExecuteNonQuery();
                        transaction.Commit();
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void polEkle(ListBox poliklinikAd)
        {
            string query = "INSERT INTO poliklinikler (poliklinik) VALUES (@poliklinikAd)";

            using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
            {
                SqlTransaction transaction = null;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();
                    foreach (var item in poliklinikAd.Items)
                    {
                        using (SqlCommand command = new SqlCommand(query, connection, transaction))
                        {
                            // Parametreler oluştur
                            command.Parameters.AddWithValue("@poliklinikAd", item.ToString());

                            // Bağlantıyı aç

                            // Komutu çalıştır
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Poliklinikler başarıyla eklendi.");
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


        public static DataTable polGetir()
        {
            using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM poliklinikler", connection);
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    connection.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

        public static void bransEkle(string bransAd, ComboBox poliklinikAd)
        {
            string query = "INSERT INTO branslar (brans, poliklinik) VALUES (@brans, @poliklinikAd)";


            using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
            {
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreler oluştur
                        command.Parameters.AddWithValue("@brans", bransAd);
                        command.Parameters.AddWithValue("@poliklinikAd", poliklinikAd);

                        // Bağlantıyı aç
                        connection.Open();

                        // Komutu çalıştır
                        command.ExecuteNonQuery();
                        transaction.Commit();
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }



        public static void bransEkle(Dictionary<string, string> bransPolCifti)
        {
            string query = "INSERT INTO branslar (brans, poliklinik) VALUES (@brans, @poliklinikAd)";

            using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
            {
                SqlTransaction transaction = null;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();
                    foreach (var item in bransPolCifti)
                    {
                        using (SqlCommand command = new SqlCommand(query, connection, transaction))
                        {
                            // Parametreler oluştur
                            command.Parameters.AddWithValue("@brans", item.Key.ToString());
                            command.Parameters.AddWithValue("@poliklinikAd", item.Value.ToString());

                            // Komutu çalıştır
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Branş/lar başarıyla eklendi.");
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




        public static void bransDuzenle(string bransAdi, string degistirilecekBransAdi)
        {
            string query = "UPDATE branslar SET brans = @brans WHERE brans = @degistirilecekBransAdi";

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
                        command.Parameters.AddWithValue("@brans", bransAdi);
                        command.Parameters.AddWithValue("@degistirilecekBransAdi", degistirilecekBransAdi);

                        // Komutu çalıştır
                        command.ExecuteNonQuery();

                    }
                    MessageBox.Show("Branş başarıyla güncellendi.");
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



        public static void polDuzenle(string eskiPolAdi, string yeniPolAdi)
        {
            string query = "UPDATE poliklinikler SET poliklinik = @yeniPolAdi WHERE poliklinik = @eskiPolAdi";
            string query2 = "UPDATE branslar SET poliklinik = @yeniPolAdi WHERE poliklinik = @eskiPolAdi";

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
                        command.Parameters.AddWithValue("@eskiPolAdi", eskiPolAdi);
                        command.Parameters.AddWithValue("@yeniPolAdi", yeniPolAdi);

                        // Komutu çalıştır
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(query2, connection, transaction))
                    {
                        // Parametreler oluştur
                        command.Parameters.AddWithValue("@eskiPolAdi", eskiPolAdi);
                        command.Parameters.AddWithValue("@yeniPolAdi", yeniPolAdi);

                        // Komutu çalıştır
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Poliklinik başarıyla güncellendi.");
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




        public static DataTable bransGetir(string poliklinikAd)
        {
            using (SqlConnection connection = new SqlConnection(sqlGenel.conString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT brans FROM branslar where poliklinik = @poliklinikAd", connection);
                try
                {
                    cmd.Parameters.AddWithValue("@poliklinikAd", poliklinikAd);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    connection.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

    }
}
