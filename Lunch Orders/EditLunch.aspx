<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditLunch.aspx.cs" Inherits="Lunch_Orders.EditLunch" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <main class="w-75 m-auto">
        <div class="row mb-2">

            <div class="col">
                <label class="form-label">First Name</label>
                <asp:TextBox ID="txtFirstName" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvFirstName" ControlToValidate="txtFirstName" ErrorMessage="First Name is required." runat="server" ValidationGroup="lunchValidation" CssClass="text-danger" />
            </div>
            
            <div class="col">
                <label class="form-label">Last Name</label>
                <asp:TextBox ID="txtLastName" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvLastName" ControlToValidate="txtLastName" ErrorMessage="Last Name is required." runat="server" ValidationGroup="lunchValidation" CssClass="text-danger" />
            </div>

        </div>

        <div class="row mb-2">

            <div class="col">
                <label class="form-label">Program</label>
               
                <asp:DropDownList ID="ddlProgram" CssClass="form-control" runat="server">

                    <asp:ListItem Text="--Select Option--" Value=""></asp:ListItem>
                    <asp:ListItem Text="Web Development" Value="Web Development"></asp:ListItem>
                    <asp:ListItem Text="CyberSecurity" Value="CyberSecurity"></asp:ListItem>
                    <asp:ListItem Text="Data Science" Value="Data Science"></asp:ListItem>
                    <asp:ListItem Text="Mobile App Development" Value="Mobile App Development"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvProgram" ControlToValidate="ddlProgram" InitialValue="" ErrorMessage="Program selection is required." runat="server" ValidationGroup="lunchValidation" CssClass="text-danger" />

            </div>
            
          
        </div>
        
        <h3 class="text-sm-center pr-5">Lunch Details</h3>

        <div class="row mb-2">

            <div class="col">
                <label class="form-label">Starch</label>
               
                <asp:DropDownList ID="ddlStarch" CssClass="form-control" runat="server">
                    <asp:ListItem Text="--Select Option--" Value=""></asp:ListItem>
                    <asp:ListItem Text="Plain Rice" Value="Plain Rice"></asp:ListItem>
                    <asp:ListItem Text="Spanish Rice" Value="Spanish Rice"></asp:ListItem>
                    <asp:ListItem Text="Boiled Food" Value="Boiled Food"></asp:ListItem>
                    <asp:ListItem Text="Rice and Peas" Value="Rice and Peas"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvStarch" ControlToValidate="ddlStarch" InitialValue="" ErrorMessage="Starch selection is required." runat="server" ValidationGroup="lunchValidation" CssClass="text-danger"/>

            </div>

            <div class="col">
                <label class="form-label">Meat</label>
               
                <asp:DropDownList ID="ddlMeat" CssClass="form-control" runat="server">
                    <asp:ListItem Text="--Select Option--" Value=""></asp:ListItem>
                    <asp:ListItem Text="Curry Goat" Value="Curry Goat"></asp:ListItem>
                    <asp:ListItem Text="Fry Chicken" Value="Fry Chicken"></asp:ListItem>
                    <asp:ListItem Text="Roasted Pork" Value="Roasted Pork"></asp:ListItem>
                    <asp:ListItem Text="Fish" Value="Fish"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvMeat" ControlToValidate="ddlMeat" InitialValue="" ErrorMessage="Meat selection is required." runat="server" ValidationGroup="lunchValidation" CssClass="text-danger" />

            </div>
        </div>

        <div class="row">

            <div class="col">
                <label class="form-label">Side Dish</label>
               
                <asp:DropDownList ID="ddlSideDish" CssClass="form-control" runat="server">
                    <asp:ListItem Text="--Select Option--" Value=""></asp:ListItem>
                    <asp:ListItem Text="Vegetable" Value="Vegetable"></asp:ListItem>
                    <asp:ListItem Text="Pasta" Value="Pasta"></asp:ListItem>
                    <asp:ListItem Text="Fry Plantain" Value="Fry Plantain"></asp:ListItem>
                    <asp:ListItem Text="Sweet Corn" Value="Sweet Corn"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvSideDish" ControlToValidate="ddlSideDish" InitialValue="" ErrorMessage="Side Dish selection is required." runat="server" ValidationGroup="lunchValidation" CssClass="text-danger" />

            </div>

            <div class="col">
                <label class="form-label">Beverage</label>
               
                <asp:DropDownList ID="ddlBeverage" CssClass="form-control" runat="server">
                    <asp:ListItem Text="--Select Option--" Value=""></asp:ListItem>
                    <asp:ListItem Text="Water" Value="Water"></asp:ListItem>
                    <asp:ListItem Text="Orange Juice" Value="Orange Juice"></asp:ListItem>
                    <asp:ListItem Text="Fruit Juice" Value="Fruit Juice"></asp:ListItem>
                    <asp:ListItem Text="None" Value="None"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvBeverage" ControlToValidate="ddlBeverage" InitialValue="" ErrorMessage="Beverage selection is required." runat="server" ValidationGroup="lunchValidation" CssClass="text-danger" />

            </div>
        </div>

        <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label> <br />

        <asp:Button ID="btnEditLunch" CssClass="btn btn-primary mt-4" runat="server" Text="Update" OnClick="btnEditLunch_Click" ValidationGroup="lunchValidation" />
    </main>

</asp:Content>
