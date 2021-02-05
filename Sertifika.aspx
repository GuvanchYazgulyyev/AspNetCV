﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Sertifika.aspx.cs" Inherits="AspCV.Sertifika" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <form id="Form1" runat="server">
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>SERTIFIKA</th>
                <th>İŞLEMLER</th>
            </tr>

            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <itemtemplate>
                        <tr>
                            <th><%#Eval("ID") %></th>
                            <td><%#Eval("SERTIFIKA") %></td>
                       
                         <td>
                                <asp:HyperLink NavigateUrl='<%# "SertifikaSil.aspx?ID="+Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-primary">SİL</asp:HyperLink>
                              
                                <asp:HyperLink NavigateUrl='<%# "SertifikaGuncelle.aspx?ID="+Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-danger">GÜNCELLE</asp:HyperLink>
                            </td>
                        </tr>
                    </itemtemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <asp:HyperLink NavigateUrl="~/SertifikaEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-default">SERTİFİKA EKLE</asp:HyperLink>
    </form>


</asp:Content>
