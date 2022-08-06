Feature: DoveShampoo


@shampoo
Scenario: search for product and verify
	Given Load the website in browser
	When website get load click on search
	Then search for product
	And verify the Shmapoo text

@discoverMore
Scenario: verify LetsStopTheBeautyTest section
	Given Load the url in browser
	When Website gets load go to LetsStopTheBeautyTest section
	Then click on Discover more 
	And verify the The Real Women behind Stop The Beauty Test text

@Termsofuse
Scenario: Verify Terms of use section
	Given Load the Website
	When website gets load go to footer 
	Then click on Terms of use 
	And verify Prohibited Use section