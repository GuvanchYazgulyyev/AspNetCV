<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yetenek.aspx.cs" Inherits="AspCV.Yetenek" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>YETENEK</th>
                <th>İŞLEMLER</th>
            </tr>

            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th><%#Eval("ID") %></th>
                            <td><%#Eval("YETENEK") %></td>
                       
                         <td>
                                <asp:HyperLink NavigateUrl='<%# "YetenekSil.aspx?ID="+Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-primary">SİL</asp:HyperLink>
                              
                                <asp:HyperLink NavigateUrl='<%# "YetenekGuncelle.aspx?ID="+Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-danger">GÜNCELLE</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <asp:HyperLink NavigateUrl="~/YetenekEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-default">YETENEK EKLE</asp:HyperLink>
    </form>

</asp:Content>
