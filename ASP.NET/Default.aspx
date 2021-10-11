<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Q09_1_ASP.NET._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
    .row {
        margin-bottom:5px;
    }
</style>
    <div class="jumbotron">
        <%--<h3 style="align-content: center">Reservation Details</h3>--%>
    </div>
    
    <hr />

    <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">Reservation Details</h3>
        </div>
        <div class="panel-body">
            <div class="row">
                <div class="col-md-2">
                    <div>Number of Seats</div>
                </div>
                <div class="col-md-8">
                    <asp:DropDownList ID="ddlNumberOfSeats" runat="server" Class="form-control">
                        <asp:ListItem Value="0">Please Select</asp:ListItem>
                        <asp:ListItem Value="1">Table for One</asp:ListItem>
                        <asp:ListItem Value="2">Table for Two</asp:ListItem>
                        <asp:ListItem Value="3">Table for Three</asp:ListItem>
                        <asp:ListItem Value="5">Table for Five</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="row">
            </div>
            <div class="row">
                <div class="col-md-2">
                    <div>Price per Seat</div>
                </div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtSeatPrice" runat="server" Class="form-control"></asp:TextBox>
                </div>
                <div class="col-md-2">
                    <div></div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <asp:Button ID="btnReserve" runat="server" Text="Place Reservation" Width="140px" class="btn btn-primary" />
                </div>
            </div>
        </div>
    </div>


</asp:Content>
