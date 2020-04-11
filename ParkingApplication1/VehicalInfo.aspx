<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehicalInfo.aspx.cs" MasterPageFile="~/ParkingMaster.Master" Inherits="ParkingApplication1.VehicalInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
    
        <table class="auto-style1" style="background-color: #C0C0C0">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <h3><strong>Vehical Information</strong></h3>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">VehicalType</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropdwnVtype" runat="server" Height="16px" Width="181px" AutoPostBack="True" OnSelectedIndexChanged="DropdwnVtype_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">Aloted Slot&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; From</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtFrom" runat="server" style="margin-left: 0px" Width="117px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; to&nbsp;</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtTo" runat="server" style="margin-left: 0px"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 0px; " Text="Submit" Width="82px" Height="41px" />
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            </table>
    
    </div>
    </asp:Content>
