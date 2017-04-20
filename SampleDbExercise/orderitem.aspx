<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/index.Master" CodeBehind="orderitem.aspx.cs" Inherits="SampleDbExercise.orderitem" %>

<asp:content id="Content1" contentplaceholderid="title" runat="server">
    <title>OrderItem</title>
</asp:content>

<asp:content id="bodyContainer" contentplaceholderid="body" runat="server">
     <form id="customerForm" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12 text-center">
                    <p class="lead"></p>
                </div>
                <div class="col-md-12 filterContainer">
                    <div class="col-md-3">
                        <label for="txtOrdNum" class="label">Num. Ordine</label>
                        <asp:TextBox ID="txtOrdNum" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="txtProdName" class="label">Nome Prodotto</label>
                        <asp:TextBox ID="txtProdName" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="txtUnitPrice" class="label">Prezzo Unitario</label>
                        <asp:TextBox ID="txtUnitPrice" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="txtQnt" class="label">Quantità</label>
                        <asp:TextBox ID="txtQnt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-12 text-center">
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
                    <asp:GridView ID="grdOrderItem" AutoGenerateColumns="false" AllowPaging="true" OnPageIndexChanging="grdOrderItem_PageIndexChanging"
                        CssClass="table table-striped table-responsive"
                        ItemType="SampleDbExercise.Data.OrderItem" runat="server">
                        <Columns>
                            <asp:BoundField HeaderText="Order" DataField="OrderNumber" />
                            <asp:BoundField HeaderText="Nome Prodotto" DataField="ProductName" />
                            <asp:BoundField HeaderText="Prezzo Unitario" DataField="UnitPrice" />
                            <asp:BoundField HeaderText="Quantità" DataField="Quantity" />
                        </Columns>
                        <PagerStyle ForeColor="#333" BorderWidth="0" BorderColor="Transparent" BorderStyle="None" CssClass="text-center pagination-container" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</asp:content>