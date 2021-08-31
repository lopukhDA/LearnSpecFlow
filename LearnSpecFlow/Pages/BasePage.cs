﻿using System;
using System.Collections.Generic;
using LearnSpecFlow.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LearnSpecFlow.Pages
{
	public class BasePage
	{
		private string TitleXpath => "//h1[text()='{0}']";

		public BasePage() 
		{
			
		}

		private static BasePage _basePage;

		public static BasePage Instance => _basePage ?? (_basePage = new BasePage());

		public IWebElement FindElement(By locator)
		{
			return DriverManager.Instance().FindElement(locator);
		}

		public IReadOnlyCollection<IWebElement> FindElements(By locator)
		{
			return DriverManager.Instance().FindElements(locator);
		}

		public bool IsDisplayed(By locator, int timeout = 30)
		{
			var wait = new WebDriverWait(DriverManager.Instance(), TimeSpan.FromSeconds(timeout));

			return wait.Until(d => DriverManager.Instance().FindElement(locator).Displayed);
		}

		public bool IsPageTitleDisplayed(string pageTitle)
		{
			return IsDisplayed(By.XPath(string.Format(TitleXpath, pageTitle)));
		}
	}
}
