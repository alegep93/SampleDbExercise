<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/index.Master" CodeBehind="supplier.aspx.cs" Inherits="SampleDbExercise.supplier" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    <title>Supplier</title>
</asp:Content>

<asp:Content ID="bodyContainer" ContentPlaceHolderID="body" runat="server">
    <form id="customerForm" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12 text-center">
                    <p class="lead"></p>
                </div>
                <div class="col-md-12 filterContainer">
                    <div class="col-md-3">
                        <label for="txtSuppName" class="label">Nome</label>
                        <asp:TextBox ID="txtSuppName" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="txtCompany" class="label">Compagnia</label>
                        <asp:TextBox ID="txtCompany" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="txtTitle" class="label">Titolo</label>
                        <asp:TextBox ID="txtTitle" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="txtCity" class="label">Città</label>
                        <asp:TextBox ID="txtCity" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="txtCountry" class="label">Paese</label>
                        <asp:TextBox ID="txtCountry" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="txtPhone" class="label">Telefono</label>
                        <asp:TextBox ID="txtPhone" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="txtFax" class="label">Fax</label>
                        <asp:TextBox ID="txtFax" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3 text-center">
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
                    <asp:GridView ID="grdSupplier" AutoGenerateColumns="false" AllowPaging="true" OnPageIndexChanging="grdSupplier_PageIndexChanging"
                        CssClass="table table-striped table-responsive"
                        ItemType="SampleDbExercise.Data.Supplier" runat="server">
                        <Columns>
                            <asp:BoundField HeaderText="Nome" DataField="ContactName" />
                            <asp:BoundField HeaderText="Compagnia" DataField="CompanyName" />
                            <asp:BoundField HeaderText="Titolo" DataField="ContactTitle" />
                            <asp:BoundField HeaderText="Città" DataField="City" />
                            <asp:BoundField HeaderText="Paese" DataField="Country" />
                            <asp:BoundField HeaderText="Telefono" DataField="Phone" />
                            <asp:BoundField HeaderText="Fax" DataField="Fax" />
                        </Columns>
                        <PagerStyle ForeColor="#333" BorderWidth="0" BorderColor="Transparent" BorderStyle="None" CssClass="text-center pagination-container" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</asp:Content>