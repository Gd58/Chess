<%@ Page Title="主页" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="chess._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
   <div style="height: 391px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Start" runat="server" Height="42px" 
           onclick="Start_Click" Text="Start" Width="81px" />
       &nbsp;<asp:Button ID="Button2" runat="server" Height="42px" 
           onclick="Button2_Click" style="margin-top: 0px" Text="PAUSE" Width="81px" />
       &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Height="42px" 
           onclick="Button3_Click" Text="HELP" Width="81px" />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button4" 
           runat="server" Height="42px" onclick="Button4_Click" Text="Regret" 
           Width="81px" />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
           ID="Button5" runat="server" Height="42px" onclick="Button5_Click" Text="About" 
           Width="81px" />
       <asp:Button ID="Btn_1" runat="server" Height="42px" onclick="Btn1_Click" 
           Text="RebotPlayer1" Width="123px" />
&nbsp;<asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Larger" 
           Height="59px" style="margin-left: 0px" 
           Text="SOMEONE WIN or The CHART HAS SELECTED PLEASE SELECT CHARTS AGAIN or NEW GAME" 
           Width="923px"></asp:Label>
       &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Label ID="Lbel1" runat="server" BackColor="#33CC33" BorderStyle="Solid" 
           Font-Bold="True" Font-Size="Medium" Height="37px"  Text="     PLAYER1 WIN" 
           Width="145px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Label ID="Lbel2" runat="server" BackColor="#33CC33" BorderStyle="Solid" 
           Font-Bold="True" Font-Names="Khmer UI" Font-Overline="True" Height="37px" 
           Text="PLAAYER2 WIN" Width="145px"></asp:Label>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Label ID="Label4" runat="server" BackColor="#33CC33" BorderColor="#999966" 
           BorderStyle="Solid" Font-Bold="True" Height="37px" Text="NO WINNER" 
           Width="145px"></asp:Label>
&nbsp;
       <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Button ID="btn1" runat="server" Height="50px" onclick="btn1_Click" 
           Text="1" Width="70px" />
       <asp:Button ID="btn2" runat="server" Height="50px" onclick="btn2_Click" Text="2" Width="70px" />
       <asp:Button ID="btn3" runat="server" Height="50px" onclick="btn3_Click" Text="3" Width="70px" />
       <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Button ID="btn4" runat="server" Height="50px" OnClick="btn4_Click" Text="4" Width="70px" />
       <asp:Button ID="btn5" runat="server" Height="50px" onclick="btn5_Click" 
           Text="5" Width="70px" />
       <asp:Button ID="btn6" runat="server" Height="50px" onclick="btn6_Click" Text="6" Width="70px" />
       <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Button ID="btn7" runat="server" Height="50px" onClick="btn7_Click" Text="7" Width="70px" />
       <asp:Button ID="btn8" runat="server" Height="50px" onclick="btn8_Click" 
           Text="8" Width="70px" />
       <asp:Button ID="btn9" runat="server" Height="50px" OnClick="btn9_Click" Text="9" Width="70px" />
       <br />
       <br />
       <br />
   </div>
   
</asp:Content>
