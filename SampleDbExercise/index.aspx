<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/index.Master" CodeBehind="index.aspx.cs" Inherits="SampleDbExercise._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    <title>Home Page</title>
</asp:Content>

<asp:Content ID="bodyContainer" ContentPlaceHolderID="body" runat="server">
    <div id="main-container" class="container-fluid">
        <!-- Row 1 -->
        <div class="row text-center">
            <div class="col-md-offset-3 col-md-2">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title"><a href="customer.aspx">Customer</a></h3>
                    </div>
                    <div class="panel-body">
                        Search for content in Customer table
                    </div>
                </div>
            </div>

            <div class="col-md-2">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title"><a href="order.aspx">Order</a></h3>
                    </div>
                    <div class="panel-body">
                        Search for content in Order table
                    </div>
                </div>
            </div>

            <div class="col-md-2">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title"><a href="orderitem.aspx">Order Items</a></h3>
                    </div>
                    <div class="panel-body">
                        Search for content in OrderItem table
                    </div>
                </div>
            </div>
        </div>

        <!-- Row 2 -->
        <div class="row text-center">
            <div class="col-md-offset-4 col-md-2">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title"><a href="product.aspx">Product</a></h3>
                    </div>
                    <div class="panel-body">
                        Search for content in Product table
                    </div>
                </div>
            </div>

            <div class="col-md-2">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title"><a href="supplier.aspx">Supplier</a></h3>
                    </div>
                    <div class="panel-body">
                        Search for content in Supplier table
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- End main-container -->
</asp:Content>