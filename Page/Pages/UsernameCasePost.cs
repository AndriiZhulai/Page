﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Page.Pages
{
    public class UsernameCasePost
    {
        public UsernameCasePost()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#post-74 > div > p > a")]
        public IWebElement LoginFormLink { get; set; }

    }
}
