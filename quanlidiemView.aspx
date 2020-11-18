<%@ Page Title="" Language="C#" MasterPageFile="~/trangchu.Master" AutoEventWireup="true" CodeBehind="quanlidiemView.aspx.cs" Inherits="Doanbaove.quanlidiemView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" CssClass="w3-table-all w3-hoverable w3-bordered w3-card-4 w3-small" BorderStyle="None" EnableTheming="True" OnPageIndexChanging="GridView1_PageIndexChanging" ShowHeaderWhenEmpty="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <HeaderStyle CssClass="w3-blue" />
                        <Columns>
                                <asp:TemplateField HeaderText="STT">
                                   <ItemTemplate>
                                       <asp:Label ID="numberrow" Text=" <%# Container.DataItemIndex + 1 %>" runat="server"></asp:Label>
                        
                                    </ItemTemplate>
                              </asp:TemplateField>
                        </Columns>
    </asp:GridView>
</asp:Content>
