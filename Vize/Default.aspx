<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="Stylesheet" type="text/css" href="StyleSheet.css" />
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;700&display=swap" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="my-form">
        <div>
            <h2>Üyelik Formu</h2>
            <div class="container">
                <div class="input-box">
                    <div class="input">
                        <asp:Label class="label" ID="Label1" runat="server" Text="Ad"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </div>
                    <div class="message">
                         <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
                    </div>
                </div>

                <hr />  

                <div class="input-box">
                     <div class="input">
                        <asp:Label class="label" ID="Label2" runat="server" Text="Soyad"></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </div>
                    <div class="message">
                          <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
                    </div>
                </div>

                <hr />

                <div class="input-box">
                     <div class="input">
                        <asp:Label class="label" ID="Label3" runat="server" Text="Tc No"></asp:Label>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </div>
                    <div class="message">
                          <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
                    </div>
                </div>

                <hr />

                <div class="input-box">
                     <div class="input">
                         <asp:Label class="label" ID="Label4" runat="server" Text="Doğum Yeri"></asp:Label>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </div>
                    <div class="message">
                           <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
                    </div>
                </div>

                <hr />

                <div class="input-box">
                     <div class="input">
                        <asp:Label class="label" ID="Label5" runat="server" Text="Doğum Tarihi"></asp:Label>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </div>
                    <div class="message">
                          <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator"></asp:RangeValidator>
                    </div>
                </div>

                <hr />

                <div class="input-box">
                     <div class="input">
                        <asp:Label class="label" ID="Label6" runat="server" Text="Yaş"></asp:Label>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </div>
                    <div class="message">
                          <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="RangeValidator"></asp:RangeValidator>
                    </div>
                </div>

                <hr />

                <div class="input-box">
                     <div class="input">
                    <asp:Label class="label" ID="Label7" runat="server" Text="Cinsiyet"></asp:Label>&nbsp;
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </div>
                    <div class="message">
                          <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
                    </div>
                </div>

                <hr />

                <div class="input-box">
                     <div class="input">
                    <asp:Label class="label" ID="Label8" runat="server" Text="Uyruk"></asp:Label>&nbsp;
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </div>
                    <div class="message">
                          <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
                    </div>
                </div>

                <hr />

                <div class="input-box">
                     <div class="input">
                        <asp:Label class="label" ID="Label9" runat="server" Text="E-Mail"></asp:Label>
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    </div>
                </div>

                <hr />

                <div class="input-box">
                     <div class="input">
                         <asp:Label class="label" ID="Label10" runat="server" Text="E-Mail Tekrar"></asp:Label>
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    </div>
                    <div class="message">
                          <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator"></asp:CompareValidator>
                    </div>
                </div>

                <hr />

                <div class="input-box">
                     <div class="input">
                         <asp:Label class="label" ID="Label11" runat="server" Text="Cep Telefonu"></asp:Label>
                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                    </div>
                    <div class="message">
                         <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
                    </div>
                </div>

                <hr />

                <div class="input-box">
                     <div class="input">
                         <asp:Label class="label" ID="Label12" runat="server" Text="Şifre"></asp:Label>
                        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                    </div>
                    <div class="message">
                         <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
                    </div>
                </div>

                <hr />

                <div class="input-box">
                     <div class="input">
                        <asp:Label class="label" ID="Label13" runat="server" Text="Şifre Tekrar"></asp:Label>
                        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                    </div>
                    <div class="message">
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="CompareValidator"></asp:CompareValidator>
                    </div>
                </div>

                <hr />
                <div class="footer">
                    <asp:Button ID="Button1" runat="server" Text="Kayıt" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Şifre Üret" CausesValidation="false"/>
                   <div class="your-password">
                       <span>Random Şifreniz:</span>
                        <asp:Label ID="Label14" runat="server" Text="xxxxxxxx"></asp:Label>
                   </div>
                </div>
                <asp:Panel ID="Panel1" runat="server" Height="258px" Width="153px">
                </asp:Panel>
             </div>
                <div>
                    <asp:ListBox ID="ListBox1" runat="server">
                        <asp:ListItem>Ad ---------------- Soyad ---------------- Tc No ---------------- Doğum Yeri ---------------- Doğum Tarihi ---------------- Yaş ---------------- Cinsiyet ---------------- Uyruk ---------------- Email ---------------- Cep No ---------------- Şifre </asp:ListItem>
                    </asp:ListBox>
                </div>
        </div>
    </form>
</body>
</html>