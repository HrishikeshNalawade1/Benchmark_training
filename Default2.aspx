<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Depno" DataSourceID="SqlDataSource1">
    <Columns>
        <asp:BoundField DataField="Depno" HeaderText="Depno" ReadOnly="True" SortExpression="Depno" />
        <asp:BoundField DataField="Dname" HeaderText="Dname" SortExpression="Dname" />
        <asp:BoundField DataField="Dloc" HeaderText="Dloc" SortExpression="Dloc" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CompanyConnectionString2 %>" SelectCommand="SELECT * FROM [Department]"></asp:SqlDataSource>
</asp:Content>

