<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <table>
              <tr>
                  <td>
                      <asp:Label ID="lblFnme" runat="server" Text="First Name"></asp:Label>

                  </td>
                  <td colspan="2">
                      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                  </td>
                  </tr>
               <tr>
                  <td>
                      <asp:Label ID="lblLnme" runat="server" Text="Last Name"></asp:Label>
                  </td>
                  <td colspan="2">
                      <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                  </td>
                  </tr>
               <tr>
                  <td>
                      <asp:Label ID="lblUnme" runat="server" Text="UserName"></asp:Label>
                  </td>
                  <td colspan="2">
                      <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                  </td>
                  </tr>
               <tr>
                  <td>
                      <asp:Label ID="lblPwd" runat="server" Text="Password"></asp:Label>
                  </td>
                  <td colspan="2">
                      <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
                  </td>
                  </tr>
               <tr>
                  <td>
                      <asp:Label ID="label" runat="server" Text="Confirm Password"></asp:Label>
                  </td>
                  <td colspan="2">
                      <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
                  </td>
                  </tr>
               <tr>
                  <td>
                      <asp:Label ID="lblAdrs" runat="server" Text="Adress"></asp:Label>
                  </td>
                  <td colspan="2">
                      <asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine"></asp:TextBox>
                  </td>
                  </tr>
               <tr>
                  <td>
                      <asp:Label ID="lblSta" runat="server" Text="State"></asp:Label>
                  </td>
                  <td colspan="2">
                      <asp:DropDownList ID="DropDownList1" runat="server">
                          <asp:ListItem>Select</asp:ListItem>
                          <asp:ListItem>Maharastra</asp:ListItem>
                          <asp:ListItem>Goa</asp:ListItem>
                          <asp:ListItem>Gujrat</asp:ListItem>
                      </asp:DropDownList>
                  </td>
                  </tr>
             
              <tr>
                  <td>
                      <asp:Label ID="lblDob" runat="server" Text="Date of Birth"></asp:Label>
                  </td>
                  <td colspan="2">
                      <asp:TextBox ID="TextBox9" runat="server" TextMode="Date"></asp:TextBox>
                  </td>
                  </tr>
              <tr>
                  <td>
                      <asp:Label ID="lblRmk" runat="server" Text="Remark"></asp:Label>
                  </td>
                  <td colspan="2">
                      <asp:TextBox ID="TextBox10" runat="server" OnTextChanged="TextBox10_TextChanged"></asp:TextBox>
                  </td>
                  </tr>
              <tr>
                  <td></td>
                  <td colspan="2">
                      <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                  </td>
                  </tr>              
              <tr>
                  <td></td>
                  <td colspan="2">
                      <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
                  </td>
                  </tr>
              </table>
        </div>
     
    </form>
</body>
</html>
