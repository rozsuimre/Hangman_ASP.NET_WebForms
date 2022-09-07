<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleImike.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 133px;
            height: 160px;
            text-align: center;
        }
        .auto-style3 {
            font-size: x-large;
        }
        .kozepre{
            display:block;
            margin:auto;
        }
    </style>
</head>
<body style="height: 965px">
    
    
        <div style="height: 220px; width: 305px; margin: auto;">
            <h2 class="auto-style1">Üdvözlet a Demo oldalamon !</h2>
            <div style="display:block;width:115px; margin:auto; height: 142px;"><img width: 250px; alt="sjb" class="auto-style2" src="Kepek/HangmanCimkep2.jpg" />
                <br />
               
            </div>
        </div>
    <!--
    <div style="width: 80px; margin-left: 45%; height: 30px;">
        <a href="https://localhost:44323/Default.aspx">
            <button onclick="indit();">Új Játék</button></a>
        
        
        
    </div>-->
    <br />
    <div style="width: 297px; margin-left: 39%;">
    <strong><span class="auto-style3">Hangman/ Akasztófa játék:</span></strong><br />
        </div>
    <h3 class="auto-style1">A feladat: találd ki az angol szót a gombokon való tippelgetéssel (5000 angol szóból) ! </h3>

    <script>
        function betolt() {
            document.getElementById("jatekter").style.visibility = "hidden";
        }

        function indit() {
            document.getElementById("jatekter").style.visibility = "visible";
        }

    </script>
     
    <div id="jatekter">
    <form id="form1" runat="server">
         <div class="HTMLpanel" style="width:759px; display: block; margin:auto; height: 407px;" id="Label1" >
          <div class="belso" style="display:block; left:40%; font-size: medium;">

           
            <br />
              <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Találd ki a következő szót:"></asp:Label>
              <br />
        <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="XX-Large" Letter-Spacing="15px" Width="138px" CssClass="auto-style1" Height="41px"></asp:Label>
            
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
              <asp:Image style="float:right" ID="Image1" runat="server" ImageUrl="~/Kepek/hangman2.jpg" Width="284px" />
             <br />
             <br />
            <asp:Label ID="LabelPont" runat="server" Font-Size="X-Large" Text="pontszám: "></asp:Label>
             <asp:Label ID="Label3" runat="server" Font-Size="X-Large" Text=""></asp:Label>&nbsp;<br />
            <asp:Label ID="LabelPont0" runat="server" Font-Size="X-Large" Text="Ezt kellett volna kitalálni: " Visible="False"></asp:Label>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="XX-Large" Letter-Spacing="15px" Width="138px" CssClass="auto-style1" Height="41px"></asp:Label>

              <br />
                         
             <br />

          </div>
             <br />
            <br />
        <asp:Panel ID="Panel1" runat="server">
        <asp:Button ID="btA" runat="server" OnClick="btA_Click" Text="a" Width="45px" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btB" runat="server" Text="b" Width="45px" OnClick="btB_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btC" runat="server" Text="c" Width="45px" OnClick="btC_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btD" runat="server" Text="d" Width="45px" OnClick="btD_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btE" runat="server" Text="e" Width="45px" OnClick="btE_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btF" runat="server" Text="f" Width="45px" OnClick="btF_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btG" runat="server" Text="g" Width="45px" OnClick="btG_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btH" runat="server" Text="h" Width="45px" OnClick="btH_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btI" runat="server" Text="i" Width="45px" OnClick="btI_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;<br/><br />
        <asp:Button ID="btJ" runat="server" Text="j" Width="45px" OnClick="btJ_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium"/>&nbsp;
        <asp:Button ID="btK" runat="server" Text="k" Width="45px" OnClick="btK_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        
        <asp:Button ID="btL" runat="server" Text="l" Width="45px" OnClick="btL_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btM" runat="server" Text="m" Width="45px" OnClick="btM_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btN" runat="server" Text="n" Width="45px" OnClick="btN_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btO" runat="server" Text="o" Width="45px" OnClick="btO_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btP" runat="server" Text="p" Width="45px" OnClick="btP_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btQ" runat="server" Text="q" Width="45px" OnClick="btQ_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btR" runat="server" Text="r" Width="45px" OnClick="btR_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;<br />
            <br />
        <asp:Button ID="btS" runat="server" Text="s" Width="45px" OnClick="btS_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btT" runat="server" Text="t" Width="45px" OnClick="btT_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btU" runat="server" Text="u" Width="45px" OnClick="btU_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btV" runat="server" Text="v" Width="45px" OnClick="btV_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        
        <asp:Button ID="btW" runat="server" Text="w" Width="45px" OnClick="btW_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btX" runat="server" Text="x" Width="45px" OnClick="btX_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btY" runat="server" Text="y" Width="45px" OnClick="btY_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        <asp:Button ID="btZ" runat="server" Text="z" Width="45px" OnClick="btZ_Click" BackColor="#CCFFCC" Font-Bold="True" Font-Size="Medium" />&nbsp;
        </asp:Panel>
             <br />
                        
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label6" runat="server" BackColor="#CCFFCC" Font-Bold="True" Font-Size="50px" ForeColor="Red"></asp:Label>
        </div>
          
    </form>
   
        </div>
   <br />
    <br />
    <br />
        <div style="width: 280px; margin-left: 40%; font-size:50px; ">
           

            
            <a href="Default.aspx">
                <button onclick="indit();" style="font-size: 45px; background-color: #00FFFF; border: 1px solid red; border-radius: 15%; padding: 10px; width: 273px; margin-left: 0px;" dir="ltr">Új Játék</button></a>
            <br />
            <br />
            


        </div>
    <br />
 
    </body>
</html>
