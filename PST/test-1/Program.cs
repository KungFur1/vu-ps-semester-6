// dotnet add package Selenium.WebDriver
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;


FirstTask();
//SecondTask();



void SecondTask()
{
    // 1
    var driver = new ChromeDriver();
    driver.Navigate().GoToUrl("https://demoqa.com/");
    driver.Manage().Window.FullScreen();



    // 2
    string xpath = "//p[@class='fc-button-label']";
    var consent = driver.FindElement(By.XPath(xpath));
    consent.Click();


    // 3
    System.Threading.Thread.Sleep(1000);
    var elements = driver.FindElement(By.XPath("//h5[text()='Elements']"));
    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", elements);
    elements.Click();

    // 4
    var webTables = driver.FindElement(By.XPath("//span[text()='Web Tables']"));
    webTables.Click();

    // 5
    var addNewRecordButton = driver.FindElement(By.Id("addNewRecordButton"));
    var nextButton = driver.FindElement(By.XPath("//button[text()='Next']"));
    while (nextButton.GetAttribute("disabled") != null)
    {
        addNewRecordButton.Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Joris");
        driver.FindElement(By.Id("lastName")).SendKeys("Pla");
        driver.FindElement(By.Id("userEmail")).SendKeys("Joris@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("22");
        driver.FindElement(By.Id("salary")).SendKeys("3333");
        driver.FindElement(By.Id("department")).SendKeys("Software");
        driver.FindElement(By.Id("submit")).Click();
    }
    System.Threading.Thread.Sleep(1000);
    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", nextButton);
    nextButton.Click();

    // 6
    xpath = "//*[local-name()='path' and @d='M864 256H736v-80c0-35.3-28.7-64-64-64H352c-35.3 0-64 28.7-64 64v80H160c-17.7 0-32 14.3-32 32v32c0 4.4 3.6 8 8 8h60.4l24.7 523c1.6 34.1 29.8 61 63.9 61h454c34.2 0 62.3-26.8 63.9-61l24.7-523H888c4.4 0 8-3.6 8-8v-32c0-17.7-14.3-32-32-32zm-200 0H360v-72h304v72z']";
    var deleteButton = driver.FindElement(By.XPath(xpath));
    deleteButton.Click();

    // 7
    xpath = "//div[@class='rt-tbody']//div[@class='rt-tr-group'][2]//div[@class='rt-td']";
    var thirdCellInput = driver.FindElement(By.XPath(xpath));
    if (thirdCellInput.Text != "&nbsp;")
    {
        Console.WriteLine("You came back to first page!");
    }
    else
    {
        Console.WriteLine("Failed to comeback to first page!");
    }
    
}


void FirstTask()
{
    // 1
    var driver = new ChromeDriver();
    driver.Navigate().GoToUrl("https://demoqa.com/");


    // 2
    string xpath = "//p[@class='fc-button-label']";
    var consent = driver.FindElement(By.XPath(xpath));
    consent.Click();


    // 3
    System.Threading.Thread.Sleep(1000);
    var widgets = driver.FindElement(By.XPath("//h5[text()='Widgets']"));
    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", widgets);
    widgets.Click();


    // 4
    xpath = "//span[text()='Progress Bar']";
    var progressBar = driver.FindElement(By.XPath(xpath));
    progressBar.Click();

    // 5
    var startStopButton = driver.FindElement(By.Id("startStopButton"));
    startStopButton.Click();

    // 6
    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
    wait.Until(ExpectedConditions.ElementIsVisible(By.Id("resetButton")));
    var resetButton = driver.FindElement(By.Id("resetButton"));

    // xpath = "//div[@id='progressBar']//div";
    var progressBarOther = driver.FindElement(By.XPath(xpath));
    // while (progressBarOther.Text != "100%")
    // {
    //     System.Threading.Thread.Sleep(500);
    // }
    // var resetButton = driver.FindElement(By.Id("resetButton"));
    resetButton.Click();

    // 7
    if (progressBarOther.Text == "0%")
    {
        Console.WriteLine("Its empty!");
    }
    else
    {
        Console.WriteLine("Its not empty!");
    }
}