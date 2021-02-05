<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminDeneyimGuncelle.aspx.cs" Inherits="AspCV.AdminDeneyimGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label ID="Label5" runat="server" Text="ID"></asp:Label>
                <asp:TextBox ID="TxtID" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        <br />
        <div>
            <asp:Label ID="Label1" runat="server" Text="BAŞLIK"></asp:Label>
            <asp:TextBox ID="TxtBaslik" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="ALT BAŞLIK"></asp:Label>
            <asp:TextBox ID="TxtAltBas" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label3" runat="server" Text="AÇIKLAMA"></asp:Label>
            <asp:TextBox ID="TxtAciklama" runat="server" CssClass="form-control" TextMode="MultiLine" Height="150"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label4" runat="server" Text="TARİH"></asp:Label>
            <asp:TextBox ID="TxtTarih" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="BtnGuncelle" runat="server" Text="GÜNCELLE" CssClass="btn btn-info" OnClick="BtnGuncelle_Click" />
        </div>
    </form>


</asp:Content>
