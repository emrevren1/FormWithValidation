using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //ad için harf dışında girişi engellemek
        RegularExpressionValidator7.ControlToValidate = TextBox1.ClientID;
        RegularExpressionValidator7.ValidationExpression = "^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$";
        RegularExpressionValidator7.ErrorMessage = "Sadece harf girişi yapabilirsiniz!";
        
        //soyad için harf dışında girişi engellemek
        RegularExpressionValidator8.ControlToValidate = TextBox2.ClientID;
        RegularExpressionValidator8.ValidationExpression = "^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$";
        RegularExpressionValidator8.ErrorMessage = "Sadece harf girişi yapabilirsiniz!";

        //Doğum yeri için harf dışında girişi engellemek
        RegularExpressionValidator9.ControlToValidate = TextBox4.ClientID;
        RegularExpressionValidator9.ValidationExpression = "^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$";
        RegularExpressionValidator9.ErrorMessage = "Sadece harf girişi yapabilirsiniz!";

        //Tc kimlik numarasını istenilen format dışında girişi engellemek
        RegularExpressionValidator5.ControlToValidate = TextBox3.ClientID;
        RegularExpressionValidator5.ValidationExpression = @"\d{3}\-\d{3}\-\d{2}\-\d{3}$";
        RegularExpressionValidator5.Text = "T.C. Kimlik Numarası xxx xxx xx xxx Formatında Olmalıdır";
  
        //Doğum tarihini belirlenen formatta giriş 
        RangeValidator1.ControlToValidate = TextBox5.ClientID;
        RangeValidator1.Type = ValidationDataType.Date;
        DateTime today = DateTime.Now;
        DateTime minDate = today.AddYears(-25);
        DateTime maxDate = today.AddYears(-18);
        RangeValidator1.MinimumValue = minDate.ToShortDateString();
        RangeValidator1.MaximumValue = maxDate.ToShortDateString();
        RangeValidator1.Text = "Yaşı yeterli değil (18-25 yaş arası olmalı örnek: 01.01.2000)";

        //Yaş 18-25 arası olması 
        RangeValidator2.ControlToValidate = TextBox6.ClientID;
        RangeValidator2.Type = ValidationDataType.Integer;
        RangeValidator2.MinimumValue = "18";
        RangeValidator2.MaximumValue = "25";
        RangeValidator2.Text = "18-25 Yaş Arasında Olmalı.";

        //cinsiyeti k-e dışında girişi engellemek
        RegularExpressionValidator4.ControlToValidate = TextBox7.ClientID;
        RegularExpressionValidator4.ValidationExpression = @"^(K|E|e|k)$";
        RegularExpressionValidator4.ErrorMessage = "Lütfen 'K', 'k' veya 'E', 'e' değerlerinden birini giriniz.";

        //uyruğu t.c ve y.u dışıdna girşi engellemek 
        RegularExpressionValidator6.ControlToValidate = TextBox8.ClientID;
        RegularExpressionValidator6.ValidationExpression = @"^(T.C|Y.U|t.c|y.u)$";
        RegularExpressionValidator6.ErrorMessage = "Lütfen 'T.C', 't.c' veya 'Y.U', 'y.u' değerlerinden birini giriniz.";

        //e-mail adresini üstteki adresle aynı olup olmadığının kontrolü
        CompareValidator1.ControlToValidate = TextBox10.ClientID;
        CompareValidator1.ControlToCompare = TextBox9.ClientID;
        CompareValidator1.Text = "E-Mail Adresleri Aynı Değil.";
        CompareValidator1.Operator = ValidationCompareOperator.Equal;
        
        //cep telefon numarasını istenilen format dışında girişi engellemek
        RegularExpressionValidator2.ControlToValidate = TextBox11.ClientID;
        RegularExpressionValidator2.ValidationExpression = @"^0\s[5-5]{1}\d{2}\s\d{3}\s\d{2}\s\d{2}$";
        RegularExpressionValidator2.Text = "Telefon Numarası Bu Formatta Olmalı 0 5xx xxx xx xx";

        //rastgele oluşan şifrenin istenilen özellikler dışında girişi engellemek
        RegularExpressionValidator3.ControlToValidate = TextBox12.ClientID;
        RegularExpressionValidator3.ValidationExpression = "^.*(?=.{8,})(?=.*)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
        RegularExpressionValidator3.Text = "Şifrende A-Z a-z özel karakter ve 0-9 gerekli. Türkçe karakter kullanılmamalıdır.";

        //üstteki şifre ile aynı olup olmadığının kontrolü
        CompareValidator2.ControlToValidate = TextBox13.ClientID;
        CompareValidator2.ControlToCompare = TextBox12.ClientID;
        CompareValidator2.Text = "Şifreler Aynı Değil.";
        CompareValidator2.Operator = ValidationCompareOperator.Equal;
        

        //eğer bir input boş ise orayı doldurmak için uyarı kodu
        foreach (Control Item in Page.Form.Controls)
        {
            if (Item.ClientID.StartsWith("TextBox"))
            {
                RequiredFieldValidator requiredFieldValidator = new RequiredFieldValidator();
                requiredFieldValidator.ID = "req" + Item.ClientID;
                requiredFieldValidator.ControlToValidate = Item.ClientID;
                requiredFieldValidator.Text = Item.ClientID + " Doldur. " + " ";
                requiredFieldValidator.InitialValue = "";
                Panel1.Controls.Add(requiredFieldValidator);
            }
        }

    }



    //buton 1 tıklandığında listbox1 içine veri girşi
    //buton 1 tıklandığında aynı kişinin kaydının engellenmesi
    //buton 1 tıklandığı zaman formun temizlenmesi
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool tcmevcudiyet = false;
        string yeniVeri = TextBox1.Text + "--------------" + TextBox2.Text + "--------------" + TextBox3.Text + "------------" + TextBox4.Text + "--------------------------" + TextBox5.Text + "-------------------" + TextBox6.Text + "-----------------------" + TextBox7.Text + "------------------------" + TextBox8.Text + "--------" + TextBox9.Text + "------" + TextBox11.Text + "---------" + TextBox12.Text;

        foreach (ListItem item in ListBox1.Items)
        {
            if (item.Text.Contains(TextBox3.Text))
            {
                tcmevcudiyet = true;
                break;
            }
        }

        if (tcmevcudiyet)
        {

            Label14.Text = "Bu veri zaten kayıtlı!";
        }
        else
        {
            ListBox1.Items.Add(yeniVeri);
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            Label14.Text = "";
        }
    }


    //buton 2 tıklandığında rastgele şifrenin label14ün textine yazdırılması
    //buton 2 tıklandığında rastgele şifrenin textbox12nin textine yazdırılması
    protected void Button2_Click(object sender, EventArgs e)
    {

        string alfabe = "abcdefghijklmnopqrstuvwxyz";
        string ozelkarakter = "$£*-_&%+#";
        Random rand = new Random();
        int sayi = rand.Next(9);

        string harf = alfabe.Substring(rand.Next(1, 26), 1);
        string harf1 = alfabe.Substring(rand.Next(1, 26), 1);

        int sayi1 = rand.Next(9);

        string buyukharf = alfabe.Substring(rand.Next(1, 26), 1).ToUpper();
        string buyukharf1 = alfabe.Substring(rand.Next(1, 26), 1).ToUpper();

        string ozel = ozelkarakter.Substring(rand.Next(1, 9), 1).ToUpper();
        string ozel1 = ozelkarakter.Substring(rand.Next(1, 9), 1).ToUpper();

        Label14.Text = buyukharf + buyukharf1 + sayi.ToString() + sayi1.ToString() + harf + harf1 + ozel1 + ozel;
        TextBox12.Text = buyukharf + buyukharf1 + sayi.ToString() + sayi1.ToString() + harf + harf1 + ozel1 + ozel;
    }
}
