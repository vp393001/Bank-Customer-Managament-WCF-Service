<%@ Page Title="" Language="C#" MasterPageFile="~/Customer.Master" AutoEventWireup="true" CodeBehind="DeleteCustomer.aspx.cs" Inherits="WebApplication1.DeleteCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="panSearch" runat="server" style="width:auto; color:Black; font-family:Segoe UI; font-size:14px; float:left; text-align:left; padding:10px; padding-bottom:20px;" >  
<tr>  
<td>Employee ID</td>  
<td><asp:TextBox ID="txtSearch" runat="server" CssClass="textBox" Placeholder="Enter employee id to delete it" ></asp:TextBox></td>  
<td><asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="button" onclick="btnDelete_Click"   
        ></asp:Button></td>  
</tr>  
<tr>  
<td colspan="3" ><asp:Label ID="lblSearchResult" runat="server" Font-Size="Medium" ></asp:Label></td></tr>  
</table>  
 <hr />  
 <div style="float:none" >  
 <asp:GridView ID="grdEmployees" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">  
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
    </div>  
</asp:Content>
