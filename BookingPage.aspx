<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookingPage.aspx.cs" Inherits="myproject.BookingPage" %>



<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url(../images/assignment1.jpg)">
     
    <form id="form1" runat="server">
        <center>
            <h1>Movie Ticket Booking</h1>
    <center>
        <br />
        <br />
       
        <table height="400px" width="500px" style="background-color: #808080">
          
                



               <tr>
                    <td align="center">Name</td>
                    <td align="center">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>



               <tr>
                    <td align="center">Movie Name</td>
                    <td align="center">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center">Theatre</td>
                    <td align="center">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>



               <tr>
                    <td align="center">Timings</td>
                    <td align="center">
                       <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td align="center">Number of Seats</td>
                    <td align="center">
                       <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
            
                <tr>
                    <td align="center" colspan="2">
                         <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />



                   </td>
                </tr>
            
            </table>
        
        <br />
        <br />
    </center>
</center>
    </form>
</body>
</html>