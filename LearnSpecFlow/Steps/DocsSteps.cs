using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LearnSpecFlow.Pages;
using TechTalk.SpecFlow;

namespace LearnSpecFlow.Steps
{
	[Binding]
	public sealed class DocsSteps
	{
		// For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

		private readonly ScenarioContext _scenarioContext;

		public DocsSteps(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}

		[When(@"I click the search docs field")]
		public void ClickTheSearchDocsField()
		{
			DocsPage.Instance.ClickSearchDocs();
		}

	}
}
