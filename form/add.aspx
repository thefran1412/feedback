<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="form_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <div class="title">
        <a class="back" id="back" runat="server" href="/folder/index/">
            <img src="/img/back.png"/>
        </a>
        <asp:Label ID="title" runat="server" Text="CREATE FORM"></asp:Label>
    </div>
    <form runat="server">
        <table class="inputs">
            <tr>
                <td>What do you want to be evaluated?
                </td>
                <td>
                    <asp:TextBox ID="question" runat="server" class="input" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="question" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Add a Description:
                </td>
                <td>
                    <asp:TextBox ID="Description" TextMode="multiline" Columns="50" Rows="5" runat="server" class="input"/>
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
                    <asp:Label ID="color1Label" ForeColor="Red" runat="server"></asp:Label>
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

