<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Master.Master" CodeBehind="Lista.aspx.cs" Inherits="LibaryFinal.Lista" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <section>
        <div>
            <asp:GridView runat="server" class="GrdView" ID="GVList" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Imię" DataField="Imie" />
                    <asp:BoundField HeaderText="Nazwisko" DataField="Nazwisko" />
                    <asp:BoundField HeaderText="NrAlbumu" DataField="NrAlbumu" />
                    <asp:BoundField HeaderText="Tytul" DataField="Tytul" />
                    <asp:BoundField HeaderText="Termin Zwrotu" DataField="TerminZwrotu" />
                    <asp:BoundField HeaderText="Data Wypozyczenia" DataField="DataWypozyczenia" />
                    <asp:BoundField HeaderText="Gatunek" DataField="Gatunek" />
                </Columns>
            </asp:GridView>
        </div>
    </section>
</asp:Content>