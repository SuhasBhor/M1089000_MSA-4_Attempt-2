using System;
using TechTalk.SpecFlow;
using DoveShampoo.POM;

namespace DoveShampoo.StepDefinitions
{
    [Binding]
    public class DoveShampooStepDefinitions
    {
        [Given(@"Load the website in browser")]
        public void GivenLoadTheWebsiteInBrowser()
        {
            SearchProductMethod.NavigateURL();
        }

        [When(@"website get load click on search")]
        public void WhenWebsiteGetLoadClickOnSearch()
        {
           SearchProductMethod.ClickOnSearch(); 
        }

        [Then(@"search for product")]
        public void ThenSearchForProduct()
        {
            SearchProductMethod.SearchProduct();
        }

        [Then(@"verify the Shmapoo text")]
        public void ThenVerifyTheShmapooText()
        {
            SearchProductMethod.verifyText();
            SearchProductMethod.TakeScreenShot();
        }

        [Given(@"Load the url in browser")]
        public void GivenLoadTheUrlInBrowser()
        {
            DiscoverMoreMethod.NavigateURL();
        }

        [When(@"Website gets load go to LetsStopTheBeautyTest section")]
        public void WhenWebsiteGetsLoadGoToLetsStopTheBeautyTestSection()
        {
            DiscoverMoreMethod.ScrollDownToLetsStopTheBeautyTest();
        }

        [Then(@"click on Discover more")]
        public void ThenClickOnDiscoverMore()
        {
            DiscoverMoreMethod.ClickOnDiscoverMore()
;        }

        [Then(@"verify the The Real Women behind Stop The Beauty Test text")]
        public void ThenVerifyTheTheRealWomenBehindStopTheBeautyTestText()
        {
            DiscoverMoreMethod.ScrollToTheRealWomenbehindStopTheBeautyTest();
            DiscoverMoreMethod.verifyText();
            DiscoverMoreMethod.TakeScreenShot();
        }

        [Given(@"Load the Website")]
        public void GivenLoadTheWebsite()
        {
            TearmsOfUseMethod.NavigateURL();    
        }

        [When(@"website gets load go to footer")]
        public void WhenWebsiteGetsLoadGoToFooter()
        {
            TearmsOfUseMethod.ScrollDownToFooter();
        }

        [Then(@"click on Terms of use")]
        public void ThenClickOnTermsOfUse()
        {
            TearmsOfUseMethod.ClickOnTearmsOfUse();
        }

        [Then(@"verify Prohibited Use section")]
        public void ThenVerifyProhibitedUseSection()
        {
            TearmsOfUseMethod.verifyText();
            TearmsOfUseMethod.TakeScreenShot();
        }
    }
}
