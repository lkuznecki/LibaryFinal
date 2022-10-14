<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Master.Master" CodeBehind="Dodaj.aspx.cs" Inherits="LibaryFinal.Dodaj" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
        <span class="nazwapola">Gatunek Ksiazki</span>
    </div>
    <asp:DropDownList runat="server" ID="ddlGatunekKsiazki" Style="width:200px;" DataValueField="Gatunek"></asp:DropDownList>
    <div>
        <span class="nazwapola">Imie</span>
    </div>
    <div>
        <asp:TextBox CssClass="txtbClass" runat="server" ID="txtbImie"></asp:TextBox>
    </div>
    <div>
        <span class="nazwapola">Nazwisko</span>
    </div>
    <div>
        <asp:TextBox CssClass="txtbClass" runat="server" ID="txtbNazwisko"></asp:TextBox>
    </div>
    <div>
        <span class="nazwapola">Data Wypozyczenia</span>
    </div>
    <div>
        <asp:TextBox CssClass="txtbClass" runat="server" TextMode="Date" ID="txtbDataW"></asp:TextBox> 
    </div>
    <div>
        <span class="nazwapola">Termin Zwrotu</span>
    </div>
    <div>
        <asp:TextBox CssClass="txtbClass" runat="server" TextMode="Date" ID="txtbTerminZ"></asp:TextBox>
    </div>
       <div>
        <span class="nazwapola">NrAlbumu</span>
    </div>
    <div>
        <asp:TextBox CssClass="txtbClass" runat="server" TextMode="Number" ID="txtbNrAlbumu"></asp:TextBox>
    </div>
        <div>
        <span class="nazwapola">Tytuł</span>
    </div>
    <div>
        <asp:TextBox CssClass="txtbClass" runat="server" ID="txtbTytul"></asp:TextBox>
    </div>
            <div class="btnDiv">
        <asp:Button CssClass="btnAdd" runat="server" OnClick="Unnamed_Click" Text="Dodaj Wypozyczenie" />
    </div>
</asp:Content>