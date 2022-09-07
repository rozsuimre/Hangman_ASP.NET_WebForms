<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JatekVege.aspx.cs" Inherits="SimpleImike.JatekVege" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
     
    <div id="jatekter">
         <div class="HTMLpanel" style="width:759px; display: block; margin:auto; height: 407px;" id="Label1" >
          &nbsp;<asp:Label ID="Label6" runat="server" BackColor="#CCFFCC" Font-Bold="True" Font-Size="50px" ForeColor="Red"></asp:Label>
        </div>
          
        </div>
        <div style="width: 280px; margin-left: 40%; font-size:50px; ">
           

            
            <a href="https://localhost:44323/Default.aspx">
                <button onclick="indit();" style="font-size: 45px; background-color: #00FFFF; border: 1px solid red; border-radius: 15%; padding: 10px; width: 273px; margin-left: 0px;" dir="ltr">Új Játék</button></a>
           
        </div>
        </div>
    </form>
</body>
</html>
