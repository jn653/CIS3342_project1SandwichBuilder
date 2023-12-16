using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1SandwichBuilder
{
    public partial class SandwichServerSide : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            // making my toppings and spread price by using my sandwichprices class
            sandwichPrices spreadPrice = new sandwichPrices();
            sandwichPrices lettucePrice = new sandwichPrices();
            sandwichPrices tomatoPrice = new sandwichPrices();
            sandwichPrices onionPrice = new sandwichPrices();
            sandwichPrices picklePrice = new sandwichPrices();
            sandwichPrices pepperPrice = new sandwichPrices();
            sandwichPrices baconPrice = new sandwichPrices();
            sandwichPrices extracheesePrice = new sandwichPrices();
            sandwichPrices extraMeatPrice = new sandwichPrices();
            sandwichPrices italianSausagePrice = new sandwichPrices();
            sandwichPrices hotCheetosPrice = new sandwichPrices();

            //making string size and spread to display the size and spread
            string size;
            string spread;

            //using request to recieve the name of customer and customer phone number
            string customerName = Request["txtName"];
            string customerNumber = Request["textNumber"];

            //converting tip to a double by using request and convert.todouble
            double tipMoney = Convert.ToDouble(Request["txtTip"]);

            // my total amount class
            double totalAmount = 0.00;

            //using request to recieve the information for all off my inputs from using
            string toastSandwich = Request["radioToast"];
            string sandwichSpread = Request["radioSpread"];
            string lettuceToppings = Request.Form["checkLettuce"] ;
            string tomatoToppings = Request.Form["checkTomato"];
            string pepperToppings = Request.Form["checkPeppers"] ;
            string onionToppings = Request.Form["checkOnions"];
            string pickleToppings = Request.Form["checkPickles"] ;
            string baconToppings = Request.Form["checkExtraBacon"] ;
            string extracheeseToppings = Request.Form["checkExtraCheese"] ;
            string extrameatToppings = Request.Form["checkExtraMeat"] ;
            string extraitaliansausageToppings = Request.Form["checkExtraItalianSausage"] ;
            string extrahotcheetosToppings = Request["checkExtraHotCheetos"] ;
            
            // adding my tipMoney to the total amount
            totalAmount += tipMoney;

            //getting the spread and adding the price and displaying the spread type
            if (sandwichSpread.Equals("Mayo"))
            {
                spread = "Mayo - $0.50";
                spreadPrice.price = 0.50;
                totalAmount += spreadPrice.price;
            }
            else if (sandwichSpread.Equals("Ranch"))
            {
                spread = "Ranch - $0.50";
                spreadPrice.price = 0.50;
                totalAmount += spreadPrice.price;
            }
            else if (sandwichSpread.Equals("Avocado"))
            {
                spread = "Avocado - $0.50";
                spreadPrice.price = 0.50;
                totalAmount += spreadPrice.price;
            }
            else if (sandwichSpread.Equals("Chipotle"))
            {
                spread = "Chipotle - $0.50";
                spreadPrice.price = 0.50;
                totalAmount += spreadPrice.price;
            }
            else
                spread = "Mustard - $0.50";
            spreadPrice.price = 0.50;
            totalAmount += spreadPrice.price;


            //getting the size of the sandwich from request and displaying the tsize and price using if else
            string sandwichSize = Request["sandwichSize"];
            if (sandwichSize.Equals("Small"))
            {
                size = "Small - $2.00";
                totalAmount += 2.00;
            }
            else if (sandwichSize.Equals("Medium"))
            {
                size = "Medium - $3.00";
                totalAmount += 3.00;
            }
            else
                size = "Large - $4.00";
            totalAmount += 4.00;


            //getting the meal option using request and displaying the price by using if else
            string mealOption = Request["sideOption"];
            if (mealOption.Equals("Garlic Bread"))
            {
                totalAmount += 2.00;
            }
            else if (mealOption.Equals("Fruits"))
            {
                totalAmount += 2.00;
            }
            else if (mealOption.Equals("Fries"))
            {
                totalAmount += 1.00;
            }
            else
                totalAmount += 0.50;

            

            // my if else if statements that get the information for the toppings
            if (lettuceToppings != "Lettuce - $0.25")
            {
                lettucePrice.price = 0.00;
                 lettuceToppings = "No lettuce";
                totalAmount += lettucePrice.price;
            }
            else if(lettuceToppings == "Lettuce - $0.25")
            {
                lettucePrice.Price = 0.25;
                lettuceToppings = "Lettuce - $0.25";
                totalAmount += lettucePrice.price;
            }

            if (tomatoToppings != "Tomato - $0.25")
            {
                tomatoPrice.price = 0.00;
                tomatoToppings = "No tomato";
                totalAmount += tomatoPrice.price;
            }
            else if (tomatoToppings == "Tomato - $0.25")
            {
                tomatoPrice.Price = 0.25;
                tomatoToppings = "Tomato - $0.25";
                totalAmount += tomatoPrice.price;
            }

            if (pickleToppings != "Pickles - $1.00")
            {
                picklePrice.price = 0.00;
                pickleToppings = "No pickles";
                totalAmount += picklePrice.price;
            }
            else if (pickleToppings == "Pickles - $1.00")
            {
                picklePrice.Price = 1.00;
                pickleToppings = "Pickles - $1.00";
                totalAmount += picklePrice.price;
            }


            if (onionToppings != "Onions - $1.00")
            {
                onionPrice.price = 0.00;
                onionToppings = "No onions";
                totalAmount += onionPrice.price;
            }
            else if (onionToppings == "Onions - $1.00")
            {
                onionPrice.Price = 1.00;
                onionToppings = "Onions - $1.00";
                totalAmount += onionPrice.price;
            }

            if (pepperToppings != "Peppers - $1.00")
            {
                pepperPrice.price = 0.00;
                pepperToppings = "No peppers";
                totalAmount += pepperPrice.price;
            }
            else if (pepperToppings == "Peppers - $1.00")
            {
                pepperPrice.Price = 1.00;
                pepperToppings = "Peppers - $1.00";
                totalAmount += pepperPrice.price;
            }
            

            // my if else if statements that get the information for the extra toppings
            if (baconToppings != "Bacon - $1.25")
            {
                baconPrice.price = 0.00;
                baconToppings = "No bacon";
                totalAmount += baconPrice.price;
            }
            else if (baconToppings == "Bacon - $1.25")
            {
                baconPrice.Price = 1.00;
                baconToppings = "Bacon - $1.25";
                totalAmount += baconPrice.price;
            }

            if (extracheeseToppings != "extraCheese - $0.50")
            {
                extracheesePrice.price = 0.00;
                extracheeseToppings = "No extra cheese";
                totalAmount += extracheesePrice.price;
            }
            else if (extracheeseToppings == "extracheese - $0.50")
            {
                extracheesePrice.Price = 0.50;
                extracheeseToppings = "extra cheese - $0.50";
                totalAmount += extracheesePrice.price;
            }

            if (extrameatToppings != " extraMeat - $0.75")
            {
                extraMeatPrice.price = 0.00;
                extrameatToppings = "No extra meat";
                totalAmount += extraMeatPrice.price;
            }
            else if (extrameatToppings == " extraMeat - $0.75")
            {
                extraMeatPrice.Price = 0.75;
                extrameatToppings = "extra meat - $0.75";
                totalAmount += extraMeatPrice.price;
            }

            if (extraitaliansausageToppings != " ItalianSausage - $1.25")
            {
                italianSausagePrice.price = 0.00;
                extraitaliansausageToppings = "No italian sausage";
                totalAmount += italianSausagePrice.price;
            }
            else if (extraitaliansausageToppings == " ItalianSausage - $1.25")
            {
                italianSausagePrice.Price = 1.25;
                extraitaliansausageToppings = "Italian Sausage - $1.25";
                totalAmount += italianSausagePrice.price;
            }

            if (extrahotcheetosToppings != "HotCheetos - $1.75")
            {
                hotCheetosPrice.price = 0.00;
                extrahotcheetosToppings = "No hot cheetos";
                totalAmount += hotCheetosPrice.price;
            }
            else if (extrahotcheetosToppings == "HotCheetos - $1.75")
            {
                hotCheetosPrice.Price = 1.75;
                extrahotcheetosToppings = "Hot Cheetos - $1.75";
                totalAmount += hotCheetosPrice.price;
            }





            // my label that displays the information
            lblReciept.Text ="Thank you for your order. Order information:" + "</br>" + "</br>" + "Name: " + customerName + "<br/>" + "</br>" + "Phone Number: " +
              customerNumber + "<br/> " + "</br>" + "Sandwich Size: " + size + "<br/>" + "</br>" + "Toast sandwich? " + toastSandwich
              + "<br/>" + "</br>" + "Spread type: " + spread + "<br/>" + "</br>" + "Toppings:" + "<br/>" + lettuceToppings + "<br/>" + tomatoToppings +
              "<br/>" + pickleToppings + "<br/>" + onionToppings + "<br/>" + pepperToppings + "<br/>" + "</br>" + "Extra toppings:" + "<br/>" +
              baconToppings + "<br/>" + extracheeseToppings + "<br/>" + extrameatToppings + "<br/>" + extraitaliansausageToppings + "<br/>" + extrahotcheetosToppings + "<br/>" + "</br>" +
              "Side for the meal:" + mealOption + "<br/>" + "</br>" + "Tip:" + tipMoney.ToString("C") + "<br/>" +
              "Total Amount: " + "<br/>" + totalAmount.ToString("C");





        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
           
            

        }
    }
}