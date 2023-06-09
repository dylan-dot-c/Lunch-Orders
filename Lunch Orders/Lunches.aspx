<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lunches.aspx.cs" Inherits="Lunch_Orders.Lunches" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">

        <h1>Lunch Orders</h1>
        <br />
        <a href="AddLunch.aspx" class="btn btn-success">+ Add New Lunch</a>
        <br />
        <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-hover">
            <Columns>
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <asp:HyperLink NavigateUrl='<%# "EditLunch?id=" + Eval("Id") %>' runat="server"><span class="btn btn-primary">Edit</span></asp:HyperLink>
                        <asp:HyperLink NavigateUrl='<%# "OrderDetails?id=" + Eval("Id") %>' runat="server"><span class="btn border-primary border-4">View</span></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </main>
</asp:Content>
