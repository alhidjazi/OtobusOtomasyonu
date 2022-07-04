using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace OtobusOtomasyon
{
    public partial class BiletAl : Form
    {
        public BiletAl()
        {
            InitializeComponent();
        }
        OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabanim.accdb");

        public void BaglantiAc()
        {
            try
            {
                Baglanti.Open();
            }

            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Bağlantı Açma Hata Pencersi");
            }
        }

        public void BiletKes()
        {
            try
            {
                BaglantiAc();
                string Komut = "Insert Into Biletler (Tc,YolcuAd,YolcuSoyad,SeferID,KoltukNo,YolcuCinsiyet,Ucret,Tel,OtoPlaka,KalkisZamani)Values(@Tc,@YolcuAd,@YolcuSoyad,@SeferID,@KoltukNo,@YolcuCinsiyet,@Ucret,@Tel,@OtoPlaka,@KalkisZamani)";
                OleDbCommand EkleKomut = new OleDbCommand(Komut, Baglanti);
                EkleKomut.Parameters.AddWithValue("@Tc", txttc.Text);
                EkleKomut.Parameters.AddWithValue("@YolcuAd", txtAd.Text);
                EkleKomut.Parameters.AddWithValue("@YolcuSoyad", txtSoyadi.Text);
                EkleKomut.Parameters.AddWithValue("@SeferID", FrmBiletIslemleri.seferid);
                EkleKomut.Parameters.AddWithValue("@KoltukNo", txtKoltukNo.Text);
                
                if (radioer.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@YolcuCinsiyet", "Erkek");
                else if (radiokadin.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@YolcuCinsiyet", "Kadın");

                EkleKomut.Parameters.AddWithValue("@Ucret", txtfiyat.Text);
                EkleKomut.Parameters.AddWithValue("@Tel", txttel.Text);
                EkleKomut.Parameters.AddWithValue("@OtoPlaka",FrmBiletIslemleri.otoplaka );
                EkleKomut.Parameters.AddWithValue("@KalkisZamani", FrmBiletIslemleri.kalkiszaman);
                
           
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Bilet Keslendi");
                Baglanti.Close();
            }

            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hatalı");
            }
        }

        public bool BoslukKontrol()
        {
            txttc.BackColor = Color.White;
            txtAd.BackColor = Color.White;
            txtSoyadi.BackColor = Color.White;
            txttel.BackColor = Color.White;
            txtKoltukNo.BackColor = Color.White;
            if (txttc.Text == "")
            {
                txttc.BackColor = Color.Red;
                txttc.Focus();
                return false;
            }
            else if (txtAd.Text == "")
            {
                txtAd.BackColor = Color.Red;
                txtAd.Focus();
                return false;
            }
            else if (txtSoyadi.Text == "")
            {
                txtSoyadi.BackColor = Color.Red;
                txtSoyadi.Focus();
                return false;
            }
            else if (radioer.Checked == false && radiokadin.Checked == false)
            {
                MessageBox.Show("Cinsiyet Seçiniz");
                return false;
            }
            else if (txttel.Text == "(    )    -")
            {
                txttel.BackColor = Color.Red;
                txttel.Focus();
                return false;
            }
            else if (txtKoltukNo.Text == "")
            {
                MessageBox.Show("Bir Koltuk Seçiniz");
                return false;
            }
           
           
            else
            {
                return true;
            }
        }

        public void BosKotlukKontrol()
        {
            if (btnk1.BackColor == Color.LightGray)
            {
                btnk1.Image = Properties.Resources.Kotlok_Bos;
            }
             if (btnk2.BackColor == Color.LightGray)
            {
                btnk2.Image = Properties.Resources.Kotlok_Bos;
            }
             if (btnk3.BackColor == Color.LightGray)
            {
                btnk3.Image = Properties.Resources.Kotlok_Bos;
            }
             if (btnk4.BackColor == Color.LightGray)
            {
                btnk4.Image = Properties.Resources.Kotlok_Bos;
            }
             if (btnk5.BackColor == Color.LightGray)
            {
                btnk5.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk6.BackColor == Color.LightGray)
            {
                btnk6.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk7.BackColor == Color.LightGray)
            {
                btnk7.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk8.BackColor == Color.LightGray)
            {
                btnk8.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk9.BackColor == Color.LightGray)
            {
                btnk9.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk10.BackColor == Color.LightGray)
            {
                btnk10.Image = Properties.Resources.Kotlok_Bos;
            } 
            if (btnk11.BackColor == Color.LightGray)
            {
                btnk11.Image = Properties.Resources.Kotlok_Bos;
            } 
            if (btnk12.BackColor == Color.LightGray)
            {
                btnk12.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk13.BackColor == Color.LightGray)
            {
                btnk13.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk14.BackColor == Color.LightGray)
            {
                btnk14.Image = Properties.Resources.Kotlok_Bos;
            } 
            if (btnk15.BackColor == Color.LightGray)
            {
                btnk15.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk16.BackColor == Color.LightGray)
            {
                btnk16.Image = Properties.Resources.Kotlok_Bos;
            } 
            if (btnk17.BackColor == Color.LightGray)
            {
                btnk17.Image = Properties.Resources.Kotlok_Bos;
            } 
            if (btnk18.BackColor == Color.LightGray)
            {
                btnk18.Image = Properties.Resources.Kotlok_Bos;
            } 
            if (btnk19.BackColor == Color.LightGray)
            {
                btnk19.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk20.BackColor == Color.LightGray)
            {
                btnk20.Image = Properties.Resources.Kotlok_Bos;
            } 
            if (btnk21.BackColor == Color.LightGray)
            {
                btnk21.Image = Properties.Resources.Kotlok_Bos;
            } 
            if (btnk22.BackColor == Color.LightGray)
            {
                btnk22.Image = Properties.Resources.Kotlok_Bos;
            } 
            if (btnk23.BackColor == Color.LightGray)
            {
                btnk23.Image = Properties.Resources.Kotlok_Bos;
            } 
            if (btnk24.BackColor == Color.LightGray)
            {
                btnk24.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk25.BackColor == Color.LightGray)
            {
                btnk25.Image = Properties.Resources.Kotlok_Bos;
            } 
            if (btnk26.BackColor == Color.LightGray)
            {
                btnk26.Image = Properties.Resources.Kotlok_Bos;
            } 
            if (btnk27.BackColor == Color.LightGray)
            {
                btnk27.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk28.BackColor == Color.LightGray)
            {
                btnk28.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk29.BackColor == Color.LightGray)
            {
                btnk29.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk30.BackColor == Color.LightGray)
            {
                btnk30.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk31.BackColor == Color.LightGray)
            {
                btnk31.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk32.BackColor == Color.LightGray)
            {
                btnk32.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk33.BackColor == Color.LightGray)
            {
                btnk33.Image = Properties.Resources.Kotlok_Bos;
            }
            if (btnk34.BackColor == Color.LightGray)
            {
                btnk34.Image = Properties.Resources.Kotlok_Bos;
            }
        }

        public void KoltukDurumu2()
        {
            Baglanti.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Biletler where SeferID=" + FrmBiletIslemleri.seferid, Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int j = 1; j <= 34; j++)
            {
                switch (j)
                {
                    case 1: bool Test=false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "1")
                            {
                                Test = true;
                            }
                        }
                        if(Test == false)
                            btnk1.BackColor = Color.LightGray;                                
                        break;
                    case 2: bool Test2 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "2")
                            {
                                Test2 = true;
                            }
                        }
                        if (Test2 == false)
                            btnk2.BackColor = Color.LightGray;
                        break;
                    case 3: bool Test3 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "3")
                            {
                                Test3 = true;
                            }
                        }
                        if (Test3 == false)
                            btnk3.BackColor = Color.LightGray;
                        break;
                    case 4: bool Test4 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "4")
                            {
                                Test4 = true;
                            }
                        }
                        if (Test4 == false)
                            btnk4.BackColor = Color.LightGray;
                        break;
                    case 5: bool Test5 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "5")
                            {
                                Test3 = true;
                            }
                        }
                        if (Test5 == false)
                            btnk5.BackColor = Color.LightGray;
                        break;
                    case 6: bool Test6 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "6")
                            {
                                Test6 = true;
                            }
                        }
                        if (Test6 == false)
                            btnk6.BackColor = Color.LightGray;
                        break;
                    case 7: bool Test7 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "7")
                            {
                                Test7 = true;
                            }
                        }
                        if (Test7 == false)
                            btnk7.BackColor = Color.LightGray;
                        break;
                    case 8: bool Test8 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "8")
                            {
                                Test8 = true;
                            }
                        }
                        if (Test8 == false)
                            btnk8.BackColor = Color.LightGray;
                        break;
                    case 9: bool Test9 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "9")
                            {
                                Test9 = true;
                            }
                        }
                        if (Test9 == false)
                            btnk9.BackColor = Color.LightGray;
                        break;
                    case 10: bool Test10 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "10")
                            {
                                Test10 = true;
                            }
                        }
                        if (Test10 == false)
                            btnk10.BackColor = Color.LightGray;
                        break;
                    case 11: bool Test11 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "11")
                            {
                                Test11 = true;
                            }
                        }
                        if (Test11 == false)
                            btnk11.BackColor = Color.LightGray;
                        break;
                    case 12: bool Test12 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "12")
                            {
                                Test12 = true;
                            }
                        }
                        if (Test12 == false)
                            btnk12.BackColor = Color.LightGray;
                        break;
                    case 13: bool Test13 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "13")
                            {
                                Test13 = true;
                            }
                        }
                        if (Test13 == false)
                            btnk13.BackColor = Color.LightGray;
                        break;
                    case 14: bool Test14 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "14")
                            {
                                Test14 = true;
                            }
                        }
                        if (Test14 == false)
                            btnk14.BackColor = Color.LightGray;
                        break;
                    case 15: bool Test15 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "15")
                            {
                                Test15 = true;
                            }
                        }
                        if (Test15 == false)
                            btnk15.BackColor = Color.LightGray;
                        break;
                    case 16: bool Test16 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "16")
                            {
                                Test16 = true;
                            }
                        }
                        if (Test16 == false)
                            btnk16.BackColor = Color.LightGray;
                        break;
                    case 17: bool Test17 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "17")
                            {
                                Test17 = true;
                            }
                        }
                        if (Test17 == false)
                            btnk17.BackColor = Color.LightGray;
                        break;
                    case 18: bool Test18 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "18")
                            {
                                Test18 = true;
                            }
                        }
                        if (Test18 == false)
                            btnk1.BackColor = Color.LightGray;
                        break;
                    case 19: bool Test19 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "19")
                            {
                                Test = true;
                            }
                        }
                        if (Test19 == false)
                            btnk19.BackColor = Color.LightGray;
                        break;
                    case 20: bool Test20 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "20")
                            {
                                Test20 = true;
                            }
                        }
                        if (Test20 == false)
                            btnk20.BackColor = Color.LightGray;
                        break;
                    case 21: bool Test21 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "21")
                            {
                                Test21 = true;
                            }
                        }
                        if (Test21 == false)
                            btnk21.BackColor = Color.LightGray;
                        break;
                    case 22: bool Test22 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "22")
                            {
                                Test22 = true;
                            }
                        }
                        if (Test22 == false)
                            btnk22.BackColor = Color.LightGray;
                        break;
                    case 23: bool Test23 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "23")
                            {
                                Test23 = true;
                            }
                        }
                        if (Test23 == false)
                            btnk23.BackColor = Color.LightGray;
                        break;
                    case 24: bool Test24 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "24")
                            {
                                Test24 = true;
                            }
                        }
                        if (Test24 == false)
                            btnk24.BackColor = Color.LightGray;
                        break;
                    case 25: bool Test25 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "25")
                            {
                                Test25 = true;
                            }
                        }
                        if (Test25 == false)
                            btnk25.BackColor = Color.LightGray;
                        break;
                    case 26: bool Test26 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "26")
                            {
                                Test26 = true;
                            }
                        }
                        if (Test26 == false)
                            btnk26.BackColor = Color.LightGray;
                        break;
                    case 27: bool Test27 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "27")
                            {
                                Test27 = true;
                            }
                        }
                        if (Test27 == false)
                            btnk27.BackColor = Color.LightGray;
                        break;
                    case 28: bool Test28 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "28")
                            {
                                Test28 = true;
                            }
                        }
                        if (Test28 == false)
                            btnk28.BackColor = Color.LightGray;
                        break;
                    case 29: bool Test29 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "29")
                            {
                                Test29 = true;
                            }
                        }
                        if (Test29 == false)
                            btnk29.BackColor = Color.LightGray;
                        break;
                    case 30: bool Test30 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "30")
                            {
                                Test30 = true;
                            }
                        }
                        if (Test30 == false)
                            btnk30.BackColor = Color.LightGray;
                        break;
                    case 31: bool Test31 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "31")
                            {
                                Test31 = true;
                            }
                        }
                        if (Test31 == false)
                            btnk31.BackColor = Color.LightGray;
                        break;
                    case 32: bool Test32 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "32")
                            {
                                Test32 = true;
                            }
                        }
                        if (Test32 == false)
                            btnk32.BackColor = Color.LightGray;
                        break;
                    case 33: bool Test33 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "33")
                            {
                                Test33 = true;
                            }
                        }
                        if (Test33 == false)
                            btnk33.BackColor = Color.LightGray;
                        break;
                    case 34: bool Test34 = false;
                        for (int i = dt.Rows.Count; i > 0; i--)
                        {
                            if (dt.Rows[i - 1][5].ToString() == "34")
                            {
                                Test34 = true;
                            }
                        }
                        if (Test34 == false)
                            btnk34.BackColor = Color.LightGray;
                        break;
                    default:break;
                }
            }
        }


        public void KoltukDurumu()
        {
            Baglanti.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Biletler where SeferID=" + FrmBiletIslemleri.seferid, Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = dt.Rows.Count; i> 0; i--)
                {
                    if (dt.Rows[i - 1][5].ToString() == "1")
                    {
                        btnk1.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk1.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk1.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "2")
                    {
                        btnk2.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk2.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk2.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "3")
                    {
                        btnk3.BackColor = Color.White;

                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk3.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk3.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "4")
                    {
                        btnk4.BackColor = Color.White;

                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk4.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk4.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                     else if (dt.Rows[i - 1][5].ToString() == "5")
                    {
                        btnk5.BackColor = Color.White;

                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk5.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk5.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "6")
                    {
                        btnk6.BackColor = Color.White;

                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk6.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk6.Image = Properties.Resources.koltuk_Kadin;

                        }
                    } 
                    else if (dt.Rows[i - 1][5].ToString() == "7")
                    {
                        btnk7.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk7.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk7.Image = Properties.Resources.koltuk_Kadin;

                        }
                    } 
                    else if (dt.Rows[i - 1][5].ToString() == "8")
                    {
                        btnk8.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk8.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk8.Image = Properties.Resources.koltuk_Kadin;

                        }
                    } 
                    else if (dt.Rows[i - 1][5].ToString() == "9")
                    {
                        btnk9.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk9.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk9.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "10")
                    {
                        btnk10.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk10.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk10.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "11")
                    {
                        btnk11.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk11.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk11.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "12")
                    {
                        btnk12.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk12.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk12.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "13")
                    {
                        btnk13.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk13.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk13.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "14")
                    {
                        btnk14.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk14.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk14.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "15")
                    {
                        btnk15.BackColor = Color.White;

                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk15.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk15.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "16")
                    {
                        btnk16.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk16.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk16.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                     else if (dt.Rows[i - 1][5].ToString() == "17")
                    {
                        btnk17.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk17.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk17.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "18")
                    {
                        btnk18.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk18.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk18.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }

                   else if (dt.Rows[i - 1][5].ToString() == "19")
                    {
                        btnk19.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk19.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk19.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "20")
                    {
                        btnk20.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk20.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk20.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "21")
                    {
                        btnk21.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk21.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk21.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "22")
                    {
                        btnk22.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk22.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk22.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "23")
                    {
                        btnk23.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk23.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk23.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "24")
                    {
                        btnk24.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk24.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk24.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "25")
                    {
                        btnk25.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk25.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk25.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "26")
                    {
                        btnk26.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk26.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk26.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "27")
                    {
                        btnk27.BackColor = Color.White;
                        if (dt.Rows[i - 1][66].ToString() == "Erkek")
                        {
                            btnk27.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk27.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "28")
                    {
                        btnk28.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk28.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk28.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "29")
                    {
                        btnk29.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk29.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk29.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "30")
                    {
                        btnk30.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk30.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk30.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "30")
                    {
                        btnk31.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk31.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk31.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "32")
                    {
                        btnk32.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk32.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk32.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "33")
                    {
                        btnk33.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk33.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk33.Image = Properties.Resources.koltuk_Kadin;

                        }
                    }
                    else if (dt.Rows[i - 1][5].ToString() == "34")
                    {
                        btnk34.BackColor = Color.White;
                        if (dt.Rows[i - 1][6].ToString() == "Erkek")
                        {
                            btnk34.Image = Properties.Resources.kotluk_Erkek;
                        }
                        else
                        {
                            btnk34.Image = Properties.Resources.koltuk_Kadin;

                        }
                    } 

                    Baglanti.Close(); 
                }
            }
        
        }

        public void MusteriAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "select * from Musteriler where TcNo ='" + txttcara.Text + "' ";
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txttc.Text = dt.Rows[0][1].ToString();
                    txtAd.Text = dt.Rows[0][2].ToString();
                    txtSoyadi.Text = dt.Rows[0][3].ToString();

                    if (dt.Rows[0][6].ToString() == "Erkek")
                    {
                        radioer.Checked = true;
                    }
                    else if (dt.Rows[0][6].ToString() == "Kadın")
                    {
                        radiokadin.Checked = true;
                    }
                    txttel.Text = dt.Rows[0][5].ToString();
                    txtpuan.Text = dt.Rows[0][8].ToString();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz TcNo Mevcüt değildir","Hata");
                }
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Benzer Hata Penceresi");

            }
        }

        public void BiletSil()
        {
            try
            {
                    BaglantiAc();
                    string Sorgu = "delete from Biletler where Kimlik=" + txtbiletid.Text;
                    OleDbCommand SilKomut = new OleDbCommand(Sorgu, Baglanti);
                    if (SilKomut.ExecuteNonQuery() == 1)
                        MessageBox.Show(txtKoltukNo.Text + " Nolu Kayıt Silindi");

                    Baglanti.Close();
   
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Silme Hata Penceresi");
            }
        }

        public void Temizle()
        {
            txtbiletid.Text = "";
            txttcara.Text = "";
            txttc.Text = "";
            txtAd.Text = "";
            txtSoyadi.Text ="";
            txttel.Text = "";
            txtpuan.Text = "";
            txtKoltukNo.Text = "";
            radiokadin.Checked = false;
            radioer.Checked = false;
 
        }

        public void BosKoltukSaysiArti()
        {
             try
            {

                BaglantiAc();
                string Sorgu = "update Seferler set BosKoltukSaysi=@BosKoltukSaysi  where SeferID=" + FrmBiletIslemleri.seferid;
                OleDbCommand Guncellekomut = new OleDbCommand(Sorgu,Baglanti);
                 FrmBiletIslemleri.BosKoltuksayi = FrmBiletIslemleri.BosKoltuksayi - 1 ;

                 Guncellekomut.Parameters.AddWithValue("@BosKoltukSaysi", FrmBiletIslemleri.BosKoltuksayi.ToString());

                 if (Guncellekomut.ExecuteNonQuery() == 1)
                     MessageBox.Show("boş koltuk saysı Eksiklendi");
                 Baglanti.Close();

            }
             catch (Exception Hata)
             {

                 MessageBox.Show(Hata.Message, "Kayıt BosKoltukSaysı Hata Penceresi");
             }

        }

        public void BosKoltukSaysiEksi()
        {
            try
            {

                BaglantiAc();
                string Sorgu = "update Seferler set BosKoltukSaysi=@BosKoltukSaysi  where SeferID=" + FrmBiletIslemleri.seferid;
                OleDbCommand Guncellekomut = new OleDbCommand(Sorgu, Baglanti);
                FrmBiletIslemleri.BosKoltuksayi = FrmBiletIslemleri.BosKoltuksayi + 1;

                Guncellekomut.Parameters.AddWithValue("@BosKoltukSaysi", FrmBiletIslemleri.BosKoltuksayi);

                if (Guncellekomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("boş koltuk saysı Artı");
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt BosKoltukSaysı Hata Penceresi");
            }

        }
        
        private void BiletAl_Load(object sender, EventArgs e)
        {
            KoltukDurumu();
            txtfiyat.Text = FrmBiletIslemleri.fiyat;
        }

        private void btnk1_Click(object sender, EventArgs e)
        {
            if (btnk1.BackColor == Color.LightGray)
            {
                Temizle();
                BosKotlukKontrol();
                btnk1.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "1";
                btnBiletKes.Enabled = true;
                btnvazgec.Enabled = false;

            }
            else
            {
                BosKotlukKontrol();
                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='1' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
               
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else 
                  radiokadin.Checked = true;
                txtKoltukNo.Text = "1";
                btnBiletKes.Enabled = false;
                btnvazgec.Enabled = true;
            }
        }

        private void btnk5_Click(object sender, EventArgs e)
        {
            if (btnk5.BackColor == Color.LightGray)
            {
                Temizle();

                BosKotlukKontrol();
                btnk5.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "5";
                btnBiletKes.Enabled = true;
                btnvazgec.Enabled = false;
            }
            else
            {
                BosKotlukKontrol();
                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='5' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "5";
                btnBiletKes.Enabled = false;
                btnvazgec.Enabled = true;
            }
        }
        public static string koltukno;
        private void btnBiletKes_Click(object sender, EventArgs e)
        {
            koltukno = txtKoltukNo.Text;
            if (BoslukKontrol() == true)
            {
                BiletKes();
                BosKoltukSaysiArti();
                KoltukDurumu();
                BiletKesRaporuFormu bkrf = new BiletKesRaporuFormu();
                bkrf.ShowDialog();
            }

        }

        private void btnk6_Click(object sender, EventArgs e)
        {
            if (btnk6.BackColor == Color.White)
            {
                BosKotlukKontrol();
                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='6' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "6";
                btnBiletKes.Enabled = false;
                btnvazgec.Enabled = true;
            }
            else
            {
                Temizle();

                BosKotlukKontrol();
                btnk6.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "6";
                btnBiletKes.Enabled = true;
                btnvazgec.Enabled = false;
            }
        }

        private void btnk7_Click(object sender, EventArgs e)
        {
            if (btnk7.BackColor == Color.White)
            {
                BosKotlukKontrol();
                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='7' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "7";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();

                BosKotlukKontrol();
                btnk7.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "7";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk8_Click(object sender, EventArgs e)
        {
            if (btnk8.BackColor == Color.White)
            {
                BosKotlukKontrol();
                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='8' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "8";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();

                BosKotlukKontrol();
                btnk8.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "8";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk9_Click(object sender, EventArgs e)
        {
            if (btnk9.BackColor == Color.White)
            {
                BosKotlukKontrol();
                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='9' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "9";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk9.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "9";
                btnBiletKes.Enabled = true;

            }
        }

        private void btnk2_Click(object sender, EventArgs e)
        {
            if (btnk2.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='2' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "2";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk2.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "2";
                btnBiletKes.Enabled = true;

            }
        }

        private void btnk3_Click(object sender, EventArgs e)
        {
            if (btnk3.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='3' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "3";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();

                BosKotlukKontrol();
                btnk3.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "3";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk4_Click(object sender, EventArgs e)
        {
            if (btnk4.BackColor == Color.LightGray )
            {
                Temizle();

                BosKotlukKontrol();
                btnk4.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "4";
                btnBiletKes.Enabled = true;
            }
            else
            {
                BosKotlukKontrol();
                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='4' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "4";
                btnBiletKes.Enabled = false;
            }
        }

        private void btnk10_Click(object sender, EventArgs e)
        {
            if (btnk10.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='10' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "10";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk10.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "10";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk11_Click(object sender, EventArgs e)
        {

            if (btnk11.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='11' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "11";
                btnBiletKes.Enabled = false;
                

            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk11.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "11";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk12_Click(object sender, EventArgs e)
        {
            if (btnk12.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='12' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "12";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk12.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "12";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk13_Click(object sender, EventArgs e)
        {
            if (btnk13.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='13' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "13";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk13.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "13";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk14_Click(object sender, EventArgs e)
        {
            if (btnk14.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='14' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();

                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "14";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk14.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "14";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk15_Click(object sender, EventArgs e)
        {
            if (btnk15.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='15' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();

                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "15";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk15.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "15";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk16_Click(object sender, EventArgs e)
        {
            if (btnk16.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='16' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();

                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "16";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk16.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "16";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk17_Click(object sender, EventArgs e)
        {
            if (btnk17.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='17' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();

                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "17";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();

                BosKotlukKontrol();
                btnk17.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "17";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk18_Click(object sender, EventArgs e)
        {
            if (btnk18.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='18' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();

                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "18";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();

                BosKotlukKontrol();
                btnk18.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "18";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk19_Click(object sender, EventArgs e)
        {
            if (btnk19.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='19' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "19";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();

                BosKotlukKontrol();
                btnk19.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "19";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk20_Click(object sender, EventArgs e)
        {
            if (btnk20.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='20' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "20";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();

                BosKotlukKontrol();
                btnk20.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "20";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk21_Click(object sender, EventArgs e)
        {
            if (btnk21.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='21' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "21";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();

                BosKotlukKontrol();
                btnk21.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "21";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk22_Click(object sender, EventArgs e)
        {
            if (btnk22.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='22' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "22";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk22.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "22";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk23_Click(object sender, EventArgs e)
        {
            if (btnk23.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='23' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "23";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk23.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "23";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk24_Click(object sender, EventArgs e)
        {
            if (btnk24.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='24' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "24";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk24.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "24";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk25_Click(object sender, EventArgs e)
        {
            if (btnk25.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='25' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "25";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk25.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "25";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk26_Click(object sender, EventArgs e)
        {
            if (btnk26.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='26' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "26";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk26.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "26";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk27_Click(object sender, EventArgs e)
        {
            if (btnk27.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='27' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "27";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk27.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "27";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk28_Click(object sender, EventArgs e)
        {
            if (btnk28.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='28' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "28";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk28.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "28";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk29_Click(object sender, EventArgs e)
        {
            if (btnk29.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='29' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "29";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk29.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "29";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk30_Click(object sender, EventArgs e)
        {
            if (btnk30.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='30' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "30";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk30.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "30";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk31_Click(object sender, EventArgs e)
        {
            if (btnk31.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='31' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "31";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk31.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "31";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk32_Click(object sender, EventArgs e)
        {
            if (btnk32.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='32' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "32";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk32.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "32";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk33_Click(object sender, EventArgs e)
        {
            if (btnk33.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='33' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                if (dt.Rows[0][6].ToString() == "Erkek")
                    radioer.Checked = true;
                else
                    radiokadin.Checked = true;
                txtKoltukNo.Text = "33";
                btnBiletKes.Enabled = false;
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk33.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "33";
                btnBiletKes.Enabled = true;
            }
        }

        private void btnk34_Click(object sender, EventArgs e)
        {
            if (btnk34.BackColor == Color.White)
            {
                BosKotlukKontrol();

                DataSet ds = new DataSet();
                string sorgu = "select * from Biletler where KoltukNo='34' and SeferID =" + FrmBiletIslemleri.seferid;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbiletid.Text = dt.Rows[0][0].ToString();
                txttc.Text = dt.Rows[0][1].ToString();
                txtAd.Text = dt.Rows[0][2].ToString();
                txtSoyadi.Text = dt.Rows[0][3].ToString();
                txttel.Text = dt.Rows[0][8].ToString();
                txtKoltukNo.Text = "34";
            }
            else
            {
                Temizle();
                BosKotlukKontrol();
                btnk34.Image = Properties.Resources.kotluk_click;
                txtKoltukNo.Text = "34";
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (txttcara.Text == "")
            {
                txttcara.BackColor = Color.Red;
                txttcara.Focus();
            }
            else
            {
                txttcara.BackColor = Color.White;
                MusteriAra();
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txttcara.Enabled = true;
                btngoster.Enabled = true;
            }
            else
            {
                txttcara.Text = "";
                txttcara.Enabled = false;
                btngoster.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(txtAd.Text + "ismli yolcu silinecek \n onaylıyor musunuz?", "Kullancı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {

                BiletSil();
                BosKoltukSaysiEksi();
                KoltukDurumu2();
                BosKotlukKontrol();

            }
        }

        private void BiletAl_Activated(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            KoltukDurumu();
        }

        private void txtbiletid_TextChanged(object sender, EventArgs e)
        {
            if (txtbiletid.Text == "")
            {
                btnvazgec.Enabled = false;
                btnBiletKes.Enabled = true;
            }
            else
            {
                btnvazgec.Enabled = true;
                btnBiletKes.Enabled = false;
            }
        }
    }
}
