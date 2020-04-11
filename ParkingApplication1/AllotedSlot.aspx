<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllotedSlot.aspx.cs" Inherits="ParkingApplication1.AllotedSlot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 221px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Vehicle Type</td>
                <td>
                    <asp:DropDownList ID="DrpdwnVEType" runat="server" Height="16px" Width="201px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Vehicle No</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="183px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Avilable Slot</td>
                <td>
                    <asp:DropDownList ID="drpDwnAvilabelSlot" runat="server" Height="16px" Width="201px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Date </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="190px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnsubmit" runat="server" Text="Submit" Width="92px" OnClick="btnsubmit_Click" />
                    <asp:Button ID="btnUpdate" runat="server" Style="margin-left: 29px" Text="Update" Width="85px" />
                    <asp:Button ID="btnDelete" runat="server" style="margin-left: 27px" Text="Delete" Width="83px" />
                    <asp:Button ID="btnClose" runat="server" style="margin-left: 24px" Text="Close" Width="83px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
