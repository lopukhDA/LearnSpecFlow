using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LearnSpecFlow.Pages.Components;
using TechTalk.SpecFlow;

namespace LearnSpecFlow.Steps
{
	[Binding]
	public sealed class SearchPopupSteps
	{
		// For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

		private readonly ScenarioContext _scenarioContext;

		public SearchPopupSteps(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}

		[When(@"I fill the '(.*)' on the search popup")]
		public void FillTheOnTheSearchPopup(string searchText)
		{
			SearchPopupComponent.Instance.FillInput(searchText);
		}

		[When(@"I select ""(.*)"" from the search results")]
		public void SelectFromTheSearchResults(string item)
		{
			SearchPopupComponent.Instance.SelectItemByText(item);
		}

	}
}
