<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekEkle.aspx.cs" Inherits="AspCV.YetenekEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
                <asp:TextBox ID="TxtID" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label2" runat="server" Text="YETENEK"></asp:Label>
                <asp:TextBox ID="TxtYetenek" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
           
       
            <asp:Button ID="Button1" runat="server" Text="YETENEK EKLE" CssClass="btn btn-info" OnClick="Button1_Click" />
        </div>
    </form>

</asp:Content>
