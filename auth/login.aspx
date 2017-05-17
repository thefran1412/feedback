<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <div class="modal-body">
        <div class="wrapper">     
            <form id="form1" runat="server">
                <h2>Login</h2>
                <table>
                  <tr>
                    <td>
                      E-mail address:</td>
                    <td>
                      <asp:TextBox ID="UserEmail" runat="server" class="input"/></td>
                    <td>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                        ControlToValidate="UserEmail"
                        Display="Dynamic" 
                        ErrorMessage="Cannot be empty." 
                        runat="server"/>
                    </td>
                  </tr>
                  <tr>
                    <td>
                      Password:</td>
                    <td>
                      <asp:TextBox ID="UserPass" TextMode="Password" 
                         runat="server" class="input"/>
                    </td>
                    <td>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                        ControlToValidate="UserPass"
                        ErrorMessage="Cannot be empty." 
                        runat="server" />
                    </td>
                  </tr>
                </table>
                <asp:Button ID="Button1" OnClick="Logon_Click" Text="Log In" 
                   runat="server" CssClass="submit" />
                <p>
                  <asp:Label ID="Msg" ForeColor="red" runat="server" />
                </p>
              </form>
        </div>
        </div>
</asp:Content>


