<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Lunch_Orders.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>
        <div class="form-group">
            <label class="form-label">Username</label>
            <asp:TextBox ID="txtUsername" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="form-label">Password</label>
            <asp:TextBox ID="txtPassword" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
        </div>

        <asp:Button ID="btnSubmit" CssClass="btn btn-primary mt-4" runat="server" Text="Login" OnClick="btnSubmit_Click"/>

        <asp:Label ID="lblError" runat="server" ForeColor="red" Text=""></asp:Label>
    </div>

</asp:Content>
