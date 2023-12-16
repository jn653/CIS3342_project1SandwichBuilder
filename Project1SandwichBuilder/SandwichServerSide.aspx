<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SandwichServerSide.aspx.cs" Inherits="Project1SandwichBuilder.SandwichServerSide" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%-- 
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 408px; top: 29px; position: absolute" Text="Welcome to the Sandwich Shop"></asp:Label>
       </div>
        <p>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 399px; top: 69px; position: absolute; right: 598px" Text="Enter your name:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 518px; top: 69px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtNumber" runat="server" style="z-index: 1; left: 516px; top: 116px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 345px; top: 112px; position: absolute" Text="Enter your phone number:"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 284px; top: 152px; position: absolute" Text="What size sandwich would you like?"></asp:Label>
        <asp:DropDownList ID="sandwichSize" runat="server" style="z-index: 1; left: 516px; top: 153px; position: absolute">
            <asp:ListItem>Small - $2.00</asp:ListItem>
            <asp:ListItem>Medium - $3.00</asp:ListItem>
            <asp:ListItem>Large -$4.00</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 260px; top: 197px; position: absolute" Text="Would you like your sandwich toasted?"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 359px; top: 231px; position: absolute" Text="What type of spread would you like?"></asp:Label>
        
        <asp:RadioButton ID="mayoSpread" runat="server" GroupName ="spread" style="z-index: 1; left: 413px; top: 262px; position: absolute" Text="Mayo - $0.50" />
        <asp:RadioButton ID="mustardSpread" runat="server"  GroupName ="spread" style="z-index: 1; left: 416px; top: 292px; position: absolute" Text="Mustard - $0.50" />
        <asp:RadioButton ID="ranchSpread" runat="server"   GroupName ="spread" style="z-index: 1; left: 415px; top: 322px; position: absolute" Text="Ranch - $0.50" />
        <asp:RadioButton ID="avocadoSpread" runat="server"  GroupName ="spread" style="z-index: 1; left: 418px; top: 351px; position: absolute" Text="Avocado - $0.50" />
        <asp:RadioButton ID="chipotleSpread" runat="server"  GroupName ="spread" style="z-index: 1; left: 421px; top: 379px; position: absolute" Text="Chipotle - $0.50" />
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 248px; top: 405px; position: absolute" Text="What type of toppings would you like?"></asp:Label>
        <asp:CheckBox ID="checkLettuce" runat="server" style="z-index: 1; left: 495px; top: 405px; position: absolute" Text="Lettuce - $0.25" />
        <asp:CheckBox ID="checkTomato" runat="server" style="z-index: 1; left: 641px; top: 403px; position: absolute" Text="Tomato - $0.25" />
        <asp:CheckBox ID="checkPickles" runat="server" style="z-index: 1; left: 787px; top: 404px; position: absolute" Text="Pickles - $1.00" />
        <asp:CheckBox ID="checkOnions" runat="server" style="z-index: 1; left: 387px; top: 434px; position: absolute" Text="Onions - $1.00" />
        <asp:CheckBox ID="checkPeppers" runat="server" style="z-index: 1; left: 519px; top: 432px; position: absolute" Text="Peppers - $1.00" />
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 272px; top: 460px; position: absolute" Text="Would you like any extra toppings?"></asp:Label>
        <asp:RadioButton ID="radioYes" runat="server"  GroupName="toasted" style="z-index: 1; left: 515px; top: 199px; position: absolute" Text="Yes" />
        <p>
            <asp:CheckBox ID="checkBacon" runat="server" style="z-index: 1; left: 499px; top: 463px; position: absolute" Text="Bacon - $1.25" />
        </p>
        <asp:CheckBox ID="checkExtraCheese" runat="server" style="z-index: 1; left: 628px; top: 463px; position: absolute" Text="Extra Cheese - $0.50" />
        <asp:CheckBox ID="checkExtraMeat" runat="server" style="z-index: 1; left: 800px; top: 464px; position: absolute" Text="Extra Meat - $0.75" />
        <asp:CheckBox ID="checkItalianSausage" runat="server" style="z-index: 1; left: 388px; top: 489px; position: absolute" Text="Italian Sausage - $1.25" />
        <asp:CheckBox ID="checkHotCheetos" runat="server" style="z-index: 1; left: 574px; top: 487px; position: absolute" Text="Hot Cheetos - $1.75" />
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 277px; top: 512px; position: absolute" Text="Upgrade your order to a meal and get a drink and any side from these five options:"></asp:Label>
        <asp:DropDownList ID="sideOption" runat="server" style="z-index: 1; left: 396px; top: 541px; position: absolute; width: 126px">
            <asp:ListItem>Cookie - $0.50</asp:ListItem>
            <asp:ListItem>Chips - $0.50</asp:ListItem>
            <asp:ListItem>Fries - $1.00</asp:ListItem>
            <asp:ListItem>Fruits - $2.00</asp:ListItem>
            <asp:ListItem>Garlic Bread - $2.50</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 180px; top: 580px; position: absolute" Text="Would you like to leave a tip? If no tip type &quot;0.00&quot;"></asp:Label>
        <asp:TextBox ID="txtTip" runat="server" style="z-index: 1; left: 502px; top: 576px; position: absolute"></asp:TextBox>
        <asp:Button ID="submitBtn" runat="server" OnClick="submitBtn_Click" style="z-index: 1; left: 478px; top: 640px; position: absolute" Text="Submit Order" />
        
        <asp:RadioButton ID="radioNo" runat="server" GroupName="toasted" style="z-index: 1; left: 579px; top: 200px; position: absolute" Text="No" />
        --%>
        <p>
            <asp:Label ID="lblReciept" runat="server" style="z-index: 1; left: 402px; top: 29px; position: absolute"></asp:Label>
        </p>

    </form>
</body>
</html>
