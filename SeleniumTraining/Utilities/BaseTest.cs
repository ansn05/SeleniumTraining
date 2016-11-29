using OpenQA.Selenium;

namespace SeleniumTraining
{
    public static class BaseTest
    {
        public static string elementId;

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://ansntest.wordpress.com/wp-admin/");
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }

        //public BaseTest IsAtPage(string elementId)
        //{
        //    this.elementId = elementId;
        //    return this;
        //}

        public static bool ElementIsPresent(this IWebDriver driver, By by)
        {
            try
            {
                return driver.FindElement(by).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
