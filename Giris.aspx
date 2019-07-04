<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="CFZiyaretciDefteri.Giris" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="girisFormu">
        <%if (hataVarMi){ %>
        <div class="alert alert-danger">
            Giriş başarısız.
        </div>
        <%} %>
        <div class="form-group">
            <asp:TextBox ID="Eposta" runat="server" placeholder="E-posta adresiniz" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:TextBox ID="Sifre" runat="server" placeholder="Şifreniz" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Giriş Yap" OnClick="Button1_Click" CssClass="btn btn-primary" />
    </div>
</asp:Content>
