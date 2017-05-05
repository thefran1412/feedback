<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="entity_index" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    ENTITY > VIEW ALL 
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
        <ItemTemplate>
            <div class="folder">
                
                <asp:Label ID="data" runat="server" Text='<%#Eval("name") %>'></asp:Label>

                
            </div>
        </ItemTemplate>
     </asp:Repeater>

     <asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:connection %>" ID="SqlDataSource1" runat="server" SelectCommand="SELECT f.* FROM users_folders uf, folders f WHERE uf.folder_id = f.id AND uf.user_id = <%$Request.QueryString["id"]%>">
      </asp:SqlDataSource>
</asp:Content>

