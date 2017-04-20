<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/index.Master" CodeBehind="order.aspx.cs" Inherits="SampleDbExercise.order" %>

<asp:content id="Content1" contentplaceholderid="title" runat="server">
    <title>Order</title>
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
                        <label for="txtCustomer" class="label">Customer</label>
                        <asp:TextBox ID="txtCustomer" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="txtData" class="label">Data</label>
                        <asp:TextBox ID="txtData" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="txtNumOrdine" class="label">Num. Ordine</label>
                        <asp:TextBox ID="txtNumOrdine" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="txtAmount" class="label">Totale</label>
                        <asp:TextBox ID="txtAmount" CssClass="form-control" runat="server"></asp:TextBox>
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
                    <asp:GridView ID="grdOrder" AutoGenerateColumns="false" AllowPaging="true" OnPageIndexChanging="grdOrder_PageIndexChanging"
                        CssClass="table table-striped table-responsive"
                        ItemType="SampleDbExercise.Data.Order" runat="server">
                        <Columns>
                            <asp:BoundField HeaderText="Customer" DataField="CustomerName" />
                            <asp:BoundField HeaderText="Data di ordine" DataField="OrderDate" DataFormatString="{0:yyyy/MM/dd}" />
                            <asp:BoundField HeaderText="Ordine N." DataField="OrderNumber" />
                            <asp:BoundField HeaderText="Totale" DataField="TotalAmount" />
                        </Columns>
                        <PagerStyle ForeColor="#333" BorderWidth="0" BorderColor="Transparent" BorderStyle="None" CssClass="text-center pagination-container" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</asp:content>