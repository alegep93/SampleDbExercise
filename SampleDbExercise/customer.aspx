<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/index.Master" CodeBehind="customer.aspx.cs" Inherits="SampleDbExercise.customer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    <title>Customer</title>
</asp:Content>
<asp:Content ID="bodyContainer" ContentPlaceHolderID="body" runat="server">
    <form id="customerForm" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12 text-center">
                    <p class="lead"></p>
                </div>
                <div class="col-md-12 filterContainer">
                    <div class="col-md-2">
                        <label for="txtCognome" class="label">Cognome</label>
                        <asp:TextBox ID="txtCognome" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-2">
                        <label for="txtNome" class="label">Nome</label>
                        <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-2">
                        <label for="txtCitta" class="label">Città</label>
                        <asp:TextBox ID="txtCitta" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-2">
                        <label for="txtPaese" class="label">Paese</label>
                        <asp:TextBox ID="txtPaese" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-2">
                        <label for="tx  tTelefono" class="label">Telefono</label>
                        <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-2 text-center">
                        <asp:Button ID="btnCerca" OnClick="btnCerca_Click" Text="Cerca" CssClass="btn btn-primary" runat="server" />
                    </div>
                </div>
            </div>
        </div>
        <div class="clearfix"></div>
        <div class="spacer"></div>
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <asp:GridView AutoGenerateColumns="false" AllowPaging="true" OnPageIndexChanging="grdCustomer_PageIndexChanging"
                        CssClass="table table-striped table-responsive"
                        ID="grdCustomer" ItemType="SampleDbExercise.Data.Customer" runat="server">
                        <Columns>
                            <asp:BoundField HeaderText="Cognome" DataField="Surname" />
                            <asp:BoundField HeaderText="Nome" DataField="Name" />
                            <asp:BoundField HeaderText="Città" DataField="City" />
                            <asp:BoundField HeaderText="Paese" DataField="Country" />
                            <asp:BoundField HeaderText="Telefono" DataField="Phone" />
                        </Columns>
                        <PagerStyle ForeColor="#333" BorderWidth="0" BorderColor="Transparent" BorderStyle="None" CssClass="text-center pagination-container" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</asp:Content>