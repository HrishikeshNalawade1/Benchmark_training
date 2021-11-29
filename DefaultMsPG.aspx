<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
        <div>
            </div>
            &nbsp;
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CompanyConnectionString %>" SelectCommand="SELECT * FROM [Employe]"></asp:SqlDataSource>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                <HeaderTemplate>Department data
                <br/>
                <table>
                    <thead>
                        <th>Employe </th>
                        <th>Employe Name </th>
                        <th>Employe Salary</th>
                        <th>Employe Designation</th>
                        <th>Employe DepNo</th>
                    </thead>
            </HeaderTemplate>
            <ItemTemplate>
                <tr style="background-color:blanchedalmond">
                       <td><asp:Label ID="Label1" runat="server" Text='<%#Bind("Eno")%>'></asp:Label></td>
                       <td><asp:Label ID="Label2" runat="server" Text='<%#Bind("Ename")%>'></asp:Label></td>
                       <td><asp:Label ID="Label3" runat="server" Text='<%#Bind("Salary")%>'></asp:Label></td>
                       <td><asp:Label ID="Label4" runat="server" Text='<%#Bind("Designation")%>'></asp:Label></td>
                       <td><asp:Label ID="Label5" runat="server" Text='<%#Bind("Depno")%>'></asp:Label></td>
                </tr>
            </ItemTemplate>
           <AlternatingItemTemplate>
                <tr style="background-color:aqua">
                       <td><asp:Label ID="Label1" runat="server" Text='<%#Bind("Eno")%>'></asp:Label></td>
                       <td><asp:Label ID="Label2" runat="server" Text='<%#Bind("Ename")%>'></asp:Label></td>
                       <td><asp:Label ID="Label3" runat="server" Text='<%#Bind("Salary")%>'></asp:Label></td>
                       <td><asp:Label ID="Label4" runat="server" Text='<%#Bind("Designation")%>'></asp:Label></td>
                       <td><asp:Label ID="Label5" runat="server" Text='<%#Bind("Depno")%>'></asp:Label></td>
                </tr>
            </AlternatingItemTemplate>
            <FooterTemplate>
                <td colspan="4">
                    End Of Report
                </td>
                </table>
            </FooterTemplate>
            </asp:Repeater>
        
    </asp:Content>
   
