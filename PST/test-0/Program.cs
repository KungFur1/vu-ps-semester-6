// Basic selenium commands:
// // Initializing WebDriver
// IWebDriver driver = new ChromeDriver();

// // Opening a Webpage
// driver.Navigate().GoToUrl("http://www.example.com");

// // Refreshing the Webpage
// driver.Navigate().Refresh();

// // Navigating Forward
// driver.Navigate().Forward();

// // Navigating Backward
// driver.Navigate().Back();

// // Finding Elements
// IWebElement elementById = driver.FindElement(By.Id("elementId"));
// IWebElement elementByName = driver.FindElement(By.Name("elementName"));
// IWebElement elementByXPath = driver.FindElement(By.XPath("//div[@class='example']"));
// IWebElement elementByCss = driver.FindElement(By.CssSelector(".example"));

// // Sending Text to an Element
// elementById.SendKeys("Your Text Here");

// // Clicking an Element
// elementById.Click();

// // Getting Text from an Element
// string text = elementById.Text;

// // Waiting for Elements (Explicit Wait)
// WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
// IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("elementId")));

// // Executing JavaScript
// IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
// js.ExecuteScript("arguments[0].click();", elementById);

// // Taking Screenshots
// Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
// screenshot.SaveAsFile("screenshot.png", ScreenshotImageFormat.Png);

// // Closing the Browser
// driver.Close(); // Closes the current window
// driver.Quit();  // Closes all windows and quits the driver


using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;


// Test
Console.WriteLine("Hello, World!");


// 1
var driver = new ChromeDriver();
driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");


// 2
driver.FindElement(By.XPath("//a[@href='/gift-cards']")).Click();


// 3
string xpath = "//div[@class='product-item' and .//span > 99]//div[@class='picture']";
var expensive_gift_card = driver.FindElement(By.XPath(xpath));
expensive_gift_card.Click();


// 4
var recipient_name_field = driver.FindElement(By.ClassName("recipient-name"));
recipient_name_field.SendKeys("Testavimas");

var sender_name_field = driver.FindElement(By.ClassName("sender-name"));
sender_name_field.SendKeys("Joris");


// 5
var quantity_field = driver.FindElement(By.ClassName("qty-input"));
quantity_field.SendKeys(Keys.Backspace);
quantity_field.SendKeys("5000");


// 6
xpath = "//div[@class='add-to-cart-panel']//input[@type='button']";
var add_to_cart_button = driver.FindElement(By.XPath(xpath));
add_to_cart_button.Click();
System.Threading.Thread.Sleep(3000);

// 7
var add_to_wishlist_button = driver.FindElement(By.Id("add-to-wishlist-button-4"));
add_to_wishlist_button.Click();
System.Threading.Thread.Sleep(6000);



// 8
xpath = "//a[@href='/jewelry']";
var jewlery_link = driver.FindElement(By.XPath(xpath));
jewlery_link.Click();


// 9
xpath = "//div[@class='item-box' and .//a[@href='/create-it-yourself-jewelry']]//div[@class='picture']";
var your_own_jewlery_link = driver.FindElement(By.XPath(xpath));
your_own_jewlery_link.Click();


// 10
xpath = "//select[@name='product_attribute_71_9_15']//option[@value='47']";
var drop_down_element = driver.FindElement(By.XPath(xpath));
drop_down_element.Click();

var length_field = driver.FindElement(By.Id("product_attribute_71_10_16"));
length_field.SendKeys("80");

var star_element = driver.FindElement(By.Id("product_attribute_71_11_17_50"));
star_element.Click();


// 11
var quantity_field_ = driver.FindElement(By.ClassName("qty-input"));
quantity_field_.SendKeys(Keys.Backspace);
quantity_field_.SendKeys("26");


// 12
var add_to_cart_button_ = driver.FindElement(By.Id("add-to-cart-button-71"));
add_to_cart_button_.Click();
System.Threading.Thread.Sleep(3000);


// 13
var add_to_wishlist_button_ = driver.FindElement(By.Id("add-to-wishlist-button-71"));
add_to_wishlist_button_.Click();
System.Threading.Thread.Sleep(3000);


// 14
xpath = "//a[@href='/wishlist']";
var wishlist_link = driver.FindElement(By.XPath(xpath));
wishlist_link.Click();


// 15
xpath = "//input[@name='addtocart']";
var checkboxes = driver.FindElements(By.XPath(xpath));
foreach (var checkbox in checkboxes)
{
    checkbox.Click();
}


// 16
var add_to_cart_button__ = driver.FindElement(By.ClassName("wishlist-add-to-cart-button"));
add_to_cart_button__.Click();


// 17 product-price
var price_element = driver.FindElement(By.ClassName("product-price"));
if(price_element.Text == "1002600.00")
{
    Console.WriteLine("The price matches!");
}
else
{
    Console.WriteLine("The price differs!");
}



System.Threading.Thread.Sleep(5000);