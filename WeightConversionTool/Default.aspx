<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Weight Converter</title>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <link href="bootstrap/css/bootstrap.css" rel="stylesheet" />
  
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color:lightblue; font-size:medium; text-align:center; vertical-align:middle">
           <table width="90%" >
               <tr>
                    <td colspan="3">
                        <asp:Label ID="Label3" Width="90%" ForeColor="RoyalBlue" Font-Bold="true" Font-Size="XX-Large" 
                            runat="server" Text="Weight Conversion Tool"></asp:Label> &nbsp;
                    </td>
               </tr>
               <tr>
                   <td>
                       <asp:Label ID="lblWord" Width="90%" ForeColor="RoyalBlue" runat="server" Text="Enter Weight for conversion:"></asp:Label> &nbsp;
                   </td>
                   <td>
                       <asp:TextBox ID="txtWord" CssClass="form-control" Width="90%" MaxLength="100" runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="rfvtxtWord" runat="server" ForeColor="Red" 
                           ControlToValidate="txtWord"  ValidationGroup="Word"
                            ErrorMessage="Please enter a word"></asp:RequiredFieldValidator>
                       
                   </td>
                   </tr>
               <tr>
                   <td>
                       <asp:Label ID="Label1" Width="90%" runat="server" ForeColor="RoyalBlue" Text="Select Unit:"></asp:Label> &nbsp;
                   </td>
                   <td>
                       <asp:DropDownList Width="90%" ID="ddlSelectUnit" CssClass="form-control" runat="server"></asp:DropDownList>
                   </td>
                </tr>
               <tr>
                   <td>
                       <asp:Label ID="Label2" Width="90%" ForeColor="RoyalBlue" runat="server" Text="Select Unit to Convert into:"></asp:Label> &nbsp;
                   </td>
                   <td>
                       <asp:DropDownList Width="90%" ID="ddlUnitForConversion" CssClass="form-control" runat="server"></asp:DropDownList>
                   </td>
                </tr>
               <tr>
                   <td></td>
                   <td>
                       
                      <asp:Button ID="btnGetReverseWord" Width="90%" runat="server" ValidationGroup="Word"
                            CssClass="form-control" BackColor="RoyalBlue" ForeColor="White"
                           Text="Get Converted Weight" onclick="btnGetReverseWord_Click" />
                   </td>
               </tr>
               <tr>
                   <td>
                   </td>
                   <td colspan="2">
                       
                       <asp:TextBox ID="txtRevWord" CssClass="alert-success" Height="50px" Width="50%" 
                           ReadOnly="true"  runat="server"></asp:TextBox>
                   </td>
               </tr>



           </table>
    </div>
        
    </form>
</body>
</html>
