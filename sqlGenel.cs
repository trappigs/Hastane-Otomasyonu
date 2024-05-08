using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace hastane_otomasyonu
{
    public class sqlGenel
    {
        // connection string değişkeni
        public static string conString = "Data Source=BU2-C-000WY\\SQLEXPRESS;Initial Catalog=hastane;Integrated Security=True;Connect Timeout=0;Encrypt=True;TrustServerCertificate=True;";


        public static void comboBoxaDtGetir(ComboBox getir, string getirilecekSutunAdi, DataTable gonderilecekDt)
        {
            // ComboBox'a poliklinikler tablosunu bağla
            getir.DataSource = gonderilecekDt;

            // ComboBox'ta hangi sütunun görüntüleneceğini belirle
            getir.DisplayMember = getirilecekSutunAdi;

            // ComboBox'ta hangi sütunun seçilen öğenin değeri olacağını belirle
            getir.ValueMember = getirilecekSutunAdi;
        }


        public static string DateTimePickerToDateString(DateTimePicker dateTimePicker)
        {
            // DateTimePicker değerini DateTime türüne dönüştür
            DateTime selectedDate = dateTimePicker.Value.Date;

            // Tarih bilgisini string olarak al ve uygun bir biçimde biçimlendir
            string dateString = selectedDate.ToString("yyyy-MM-dd");

            // Biçimlendirilmiş tarih bilgisini döndür
            return dateString;
        }

        public static string DateForSqlConvert(string tarih)
        {
            string trimmedDateTimeString = tarih.Substring(0, 10);

            return trimmedDateTimeString;
        }

    }
}
