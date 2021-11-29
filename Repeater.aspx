<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CompanyConnectionString %>" SelectCommand="SELECT * FROM [Employe]"></asp:SqlDataSource>
            
         
        <div>
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
                <tr>
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
        </div>
    </form>
</body>
</html>
