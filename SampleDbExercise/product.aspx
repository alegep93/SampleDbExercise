<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/index.Master" CodeBehind="product.aspx.cs" Inherits="SampleDbExercise.product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    <title>Product</title>
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
                        <label for="txtSuppName" class="label">Nome Supplier</label>
                        <asp:TextBox ID="txtSuppName" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-2">
                        <label for="txtProdName" class="label">Nome Prodotto</label>
                        <asp:TextBox ID="txtProdName" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-2">
                        <label for="txtPack" class="label">Package</label>
                        <asp:TextBox ID="txtPack" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-2">
                        <label for="txtUnitPrice" class="label">Prezzo Unitario</label>
                        <asp:TextBox ID="txtUnitPrice" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-2">
                        <label for="txtDiscont" class="label">Discontinuo [0-1]</label>
                        <asp:TextBox ID="txtDiscont" CssClass="form-control" runat="server"></asp:TextBox>
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
                    <asp:GridView ID="grdProduct" AutoGenerateColumns="false" AllowPaging="true" OnPageIndexChanging="grdProduct_PageIndexChanging"
                        CssClass="table table-striped table-responsive"
                        ItemType="SampleDbExercise.Data.Product" runat="server">
                        <Columns>
                            <asp:BoundField HeaderText="Nome Supplier" DataField="SupplierName" />
                            <asp:BoundField HeaderText="Nome Prodotto" DataField="ProductName" />
                            <asp:BoundField HeaderText="Package" DataField="Package" />
                            <asp:BoundField HeaderText="Prezzo Unitario" DataField="UnitPrice" />
                            <%--<asp:BoundField HeaderText="Discontinuo" DataField="IsDiscontinued"  />--%>
                            <asp:TemplateField HeaderText="Discontinuo">
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkCheckBox" runat="server" Checked='<%# ((bool)Eval("IsDiscontinued")) %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <PagerStyle ForeColor="#333" BorderWidth="0" BorderColor="Transparent" BorderStyle="None" CssClass="text-center pagination-container" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
