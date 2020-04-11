<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/ParkingMaster.Master" CodeBehind="VehicalParking.aspx.cs" Inherits="ParkingApplication1.VehicalParking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 727px;
    }
    .auto-style2 {
        width: 570px;
    }
    .auto-style3 {
        width: 571px;
    }
    .auto-style4 {
        width: 1088px;
    }
</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <table class="auto-style1" style="background-color: #FFCCCC; border-style: inset; height: 209px;">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td style="font-size: 21px; font-weight: bold; font-style: normal; font-variant: small-caps; color: #000000" class="auto-style4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Vehical Parking Informtaion<br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Vehical No</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtVeNO0" runat="server" style="margin-left: 110px" Width="322px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Vehical Type</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="drpdVtype" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="drpdVtype_SelectedIndexChanged" Width="327px" style="margin-left: 111px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Avilable Slot</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="drpAviSlot" runat="server" AutoPostBack="True" Width="328px" Height="16px" style="margin-left: 111px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    </td>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 307px;" Text="Submit" BorderColor="White" Width="129px" />
                    </td>
            </tr>
        </table>
        <asp:Label ID="Label1" runat="server" Text="Search"></asp:Label>
        <asp:TextBox ID="txtserch" runat="server" Height="24px" style="margin-left: 37px" Width="208px"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server"  style="margin-left: 307px;" Text="Search" BorderColor="White" Width="129px" OnClick="Button2_Click" />
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="true" PageSize="10" OnRowCommand="GridView1_RowCommand" BackColor="#999999" OnSelectedIndexChanged="GridView1_SelectedIndexChanged2" style="margin-top: 48px" Width="1308px" >
    <Columns>
         <asp:BoundField ItemStyle-Width="150px" DataField="ParkingId" HeaderText="ParkingId"/>
        <asp:BoundField ItemStyle-Width="150px" DataField="VehicleNo" HeaderText="Vehical No" />
        <asp:BoundField ItemStyle-Width="150px" DataField="Vehicletype" HeaderText="Vehical Type" />
        <asp:BoundField ItemStyle-Width="150px" DataField="AllotedSlot" HeaderText="Parking Slot" />
       <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton Text="Exit" runat="server" CommandName="Select" CommandArgument="<%# Container.DataItemIndex %>" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>

    <div>
    
    </div>
   

</asp:Content>
