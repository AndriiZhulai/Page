using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Page.Pages
{
    public class SpecialElementsPage
    {
        public SpecialElementsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

    }
}
