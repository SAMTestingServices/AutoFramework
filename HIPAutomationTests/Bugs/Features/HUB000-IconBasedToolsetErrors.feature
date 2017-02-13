@bugRegression

Feature: HUB-nnn Icon based Toolset Failures
	Features of the icon based toolset available in the HIP UI have been seen to fail intermittently.
	This regression test cycles through each tool set item to ensure its functionality remains stable.

# Applies to http://jiralive:8080/browse/HUB-NNN

Background: 
	Given I am logged into the Dr Foster website
	And I am viewing data as the Aintree University Hospital NHS Foundation Trust
	And I have selected HIP from the dashboard

# Scenarios used as though this is one feature, each toolset item has different functionality

Scenario: The user selects the Favourites toolset item
	Given I have selected the Favourite tool icon
	And do something else
	When I do that other thing
	Then the page is listed on my favourites list thingy

Scenario: The user wants to export a report to pdf
	Given I have selected the Export to PDF tool icon
	And click that other thing
	When I click generate report
	Then a new browser window opens that contains the pdf file

	# add scenarios for remaining items