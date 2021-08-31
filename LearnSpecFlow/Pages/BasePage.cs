﻿using System;
using System.Collections.Generic;
using LearnSpecFlow.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LearnSpecFlow.Pages
{
	public class BasePage
	{
		public BasePage() 
		{
			
		}

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
	}
}