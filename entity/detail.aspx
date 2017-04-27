<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="detail.aspx.cs" Inherits="entity_detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
        <%
            var id = "string";
            if( RouteData.Values["id"] != null)
            {
                id = "no nulo";
            }
            else
            {
                id = "nulo";
            }


            %>
        ENTITY > DETAIL <%= id %>
</asp:Content>