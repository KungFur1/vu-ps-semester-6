using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;



namespace TestProject;

public class Tests
{
    private const string email = "test132515@test.com";
    private const string password = "pass77886644";
    private IWebDriver driver;

    [SetUp]
    public void SetUp()
    {
        try
        {
            driver = new ChromeDriver();
            Register();
        }
        catch(Exception)
        {
            System.Console.WriteLine("User already registered.");
        }
        finally
        {
            driver.Close();
            driver.Quit();
        }
        

        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(90);
    }

    [TearDown]
    public void CleanUp()
    {
        driver.Close();
        driver.Quit();
    }

    [Test]
    [TestCase(email, password, "data1.txt")]
    [TestCase(email, password, "data2.txt")]
    public void TestCheckoutProcess(string email, string password, string dataFile)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
        // 1
        driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
        
        // 2
        driver.FindElement(By.LinkText("Log in")).Click();
        
        // 3
        driver.FindElement(By.Id("Email")).SendKeys(email);
        driver.FindElement(By.Id("Password")).SendKeys(password);
        driver.FindElement(By.CssSelector("input.button-1.login-button")).Click();
        
        // 4
        driver.FindElement(By.LinkText("Digital downloads")).Click();
        
        // 5
        var products = File.ReadAllLines(dataFile);
        foreach (var product in products)
        {
            AddProductToCart(product);
            driver.Navigate().Back();
        }
        
        // 6
        driver.FindElement(By.LinkText("Shopping cart")).Click();
        
        // 7
        driver.FindElement(By.Id("termsofservice")).Click();
        driver.FindElement(By.Id("checkout")).Click();

        // 8
        var billingAddressSelect = driver.FindElements(By.Id("billing-address-select"));
        if (billingAddressSelect.Count == 0)
        {
            FillAddressForm();
        }
        else
        {
            var selectElement = new SelectElement(billingAddressSelect.FirstOrDefault());
            selectElement.SelectByIndex(0);
            Console.WriteLine("There is at least one pre-filled address.");
        }
        
        wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(By.ClassName("new-address-next-step-button"))));
        driver.FindElement(By.ClassName("new-address-next-step-button")).Click();

        // 9
        wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(By.CssSelector(".payment-method-next-step-button"))));
        driver.FindElement(By.CssSelector(".payment-method-next-step-button")).Click();

        // 10
        wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(By.CssSelector(".payment-info-next-step-button"))));
        driver.FindElement(By.CssSelector(".payment-info-next-step-button")).Click();

        // 11
        wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(By.CssSelector(".confirm-order-next-step-button"))));
        driver.FindElement(By.CssSelector(".confirm-order-next-step-button")).Click();

        // 12
        Thread.Sleep(1000);
        Assert.IsTrue(driver.Url == "https://demowebshop.tricentis.com/checkout/completed/");
    }

    private void AddProductToCart(string productName)
    {
        driver.FindElement(By.LinkText(productName)).Click();
        driver.FindElement(By.XPath("//input[@value='Add to cart']")).Click();
    }

    private void FillAddressForm()
    {
         driver.FindElement(By.Id("BillingNewAddress_Company")).SendKeys("Your Company Name");

        var countrySelectElement = driver.FindElement(By.Id("BillingNewAddress_CountryId"));
        var selectCountry = new SelectElement(countrySelectElement);
        selectCountry.SelectByValue("1");

        driver.FindElement(By.Id("BillingNewAddress_City")).SendKeys("Your City");

        driver.FindElement(By.Id("BillingNewAddress_Address1")).SendKeys("Your Address 1");

        driver.FindElement(By.Id("BillingNewAddress_Address2")).SendKeys("Your Address 2");

        driver.FindElement(By.Id("BillingNewAddress_ZipPostalCode")).SendKeys("Your Zip");

        driver.FindElement(By.Id("BillingNewAddress_PhoneNumber")).SendKeys("Your Phone Number");

        driver.FindElement(By.Id("BillingNewAddress_FaxNumber")).SendKeys("Your Fax Number");
    }

    void Register()
    {
        // 1
        driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        // 2
        IWebElement loginLink = driver.FindElement(By.LinkText("Log in"));
        loginLink.Click();

        // 3
        wait.Until(d => d.FindElement(By.LinkText("Register"))).Click();

        // 4
        driver.FindElement(By.Id("gender-male")).Click();
        driver.FindElement(By.Id("FirstName")).SendKeys("Joris");
        driver.FindElement(By.Id("LastName")).SendKeys("Plascinskas");
        driver.FindElement(By.Id("Email")).SendKeys(email);
        driver.FindElement(By.Id("Password")).SendKeys(password);
        driver.FindElement(By.Id("ConfirmPassword")).SendKeys(password);

        // 5
        driver.FindElement(By.Id("register-button")).Click();

        // 6
        var continueButton = wait.Until(drv => drv.FindElement(By.XPath("//input[@class='button-1 register-continue-button']")));
        continueButton.Click();
    }
}