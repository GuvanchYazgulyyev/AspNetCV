<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitim.aspx.cs" Inherits="AspCV.AdminEgitim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>BAŞLIK</th>
                <th>ALTBASLIK</th>
                <th>ACIKLAMA</th>
                <th>GENEL NOT</th>
                <th>TARIH</th>
                <th>İŞLEMLER</th>
            </tr>

            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th><%#Eval("ID") %></th>
                            <td><%#Eval("BASLIK") %></td>
                            <td><%#Eval("ALTBASLIK") %></td>
                            <td><%#Eval("ACIKLAMA") %></td>
                            <td><%#Eval("GNOT") %></td>
                            <td><%#Eval("TARIH") %></td>
                         <td>
                                <asp:HyperLink NavigateUrl='<%# "AdminEgitimSil.aspx?ID="+Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-primary">SİL</asp:HyperLink>
                                <br />
                                <asp:HyperLink NavigateUrl='<%# "AdminEgitimGuncelle.aspx?ID="+Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-danger">GÜNCELLE</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <asp:HyperLink NavigateUrl="~/AdminEgitimEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-default">EĞİTİM BAŞLIGI EKLE</asp:HyperLink>
    </form>

</asp:Content>
