<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CFZiyaretciDefteri.Default1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%foreach (CFZiyaretciDefteri.Models.Mesaj msj in Mesajlar)
        { %>
            <div class="msj">
                <strong><%= msj.YazanUye.AdSoyad %></strong>
                <% if (Session["GirisYapanID"] != null && msj.UyeId == (int)Session["GirisYapanID"])
                    { %>
                <span class="sil btn btn-danger" mesajid="<%=msj.Id %>">Sil</span>
                <%} %>
                <br />
                <p><%=msj.Icerik %></p>
                <i><%=msj.YazilmaZamani %></i>
                <hr />
            </div>
          <%} %>

    <script
        src="https://code.jquery.com/jquery-3.3.1.min.js"
        integrity="sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8="
        crossorigin="anonymous"></script>
    <script>
        $(".sil").click(function () {
            var _this = $(this);
            var id = $(this).attr("mesajid");
            $.ajax({
                url: "JSYonet.ashx?silinecek=" + id,
                success: function (olduMu) {
                    if (olduMu) {
                        _this.parent().slideUp("slow");
                    } else
                        alert("Bir hata oluştu");
                }
            });
        });
    </script>

    <%if (Session["GirisYapanID"] != null)
        { %>
    <asp:TextBox ID="Mesaj" runat="server" TextMode="MultiLine" Rows="5" CssClass="form-control"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Gönder" CssClass="btn btn-success" OnClick="Button1_Click" />
    <%} %>
</asp:Content>
