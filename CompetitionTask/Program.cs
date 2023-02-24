using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;




// Open Chrome browser
IWebDriver driver = new ChromeDriver();

// launch localhost
driver.Navigate().GoToUrl("http://localhost:5000/Home");

//Chick on Signin Botton
IWebElement SigninBotton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
SigninBotton.Click();

//Identify username textbox and enter valid username
IWebElement UserNameTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
UserNameTextBox.SendKeys("anjalyalwin123@gmail.com");

//Identify password textbox and enter valid Password
IWebElement PasswordTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
PasswordTextBox.SendKeys("Abraham123");

// click on login botton
IWebElement LoginBotton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
LoginBotton.Click();
Thread.Sleep(1000);

//check if user has logged in successfully
IWebElement HiAnjaly = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));

if(HiAnjaly.Text == "Hi Anjaly")
{
    Console.WriteLine("Logged in successfully, test passed");
}
else
{
    Console.WriteLine("Login failed , test failed");
}

//Click share skills and add details


IWebElement Shareskills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));
Shareskills.Click();

IWebElement Title = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
Title.SendKeys("Communication");

IWebElement Description = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
Description.SendKeys("Communication is an important skills that you need to succeed in work place");

IWebElement Category = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select"));
Category.Click();

IWebElement Selectcategory = driver.FindElement(By.XPath("//option[@value='6']"));
Selectcategory.Click();

IWebElement SelectSubcategory = driver.FindElement(By.Name("subcategoryId"));
SelectSubcategory.Click();