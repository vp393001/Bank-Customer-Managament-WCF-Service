<%@ Page Title="" Language="C#" MasterPageFile="~/Customer.Master" AutoEventWireup="true" CodeBehind="DisplayEmployeeRecord.aspx.cs" Inherits="WebApplication1.DisplayEmployeeRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   
    <asp:GridView ID="grdEmployees" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="grdEmployees_SelectedIndexChanged">  
       <AlternatingRowStyle BackColor="White" />  
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
       <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />  
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
   </asp:GridView> 
</asp:Content>
