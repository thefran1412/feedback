<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="form_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" type="text/css" href="/css/forms.css">
    <script src="/js/jquery-3.2.1.min.js"></script>
    <script src="/js/jqColorPicker.min.js"></script>
    <script src="/js/forms.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    add new form
    <form runat="server">
        <table>
            <tr>
                <td>What do you want to be evaluated?
                </td>
                <td>
                    <asp:TextBox ID="question" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="question" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Add a Description:
                </td>
                <td>
                    <asp:TextBox ID="Description" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                </td>
                <td>
                    <asp:Label ID="DescriptionLabel" ForeColor="Red" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Choose main Color:
                </td>
                <td>
                    <asp:TextBox CssClass="color" ID="color1" value="#89CAFF" runat="server" />
                </td>
                <td>
                    <asp:Label ID="Label1" ForeColor="Red" runat="server"></asp:Label>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="color1" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Choose Secondary Color:
                </td>
                <td>
                    <asp:TextBox CssClass="color" value="#FFFFFF" ID="color2" runat="server" />
                </td>
                <td>
                    <asp:Label ID="color2Label" ForeColor="Red" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="submit" OnClick="Create" Text="Create"
                        runat="server" />
                </td>
                <td></td>
            </tr>
            <tr>
                <td></td>
            </tr>

        </table>
    </form>
</asp:Content>

