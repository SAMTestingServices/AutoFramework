Feature: LoginToDRFoster
	As a user of the Dr Foster website
	I want to login by entering my user account details
	In order to have access to the tools dashboard and rest of the site

@smoke
Scenario: A user can successfully login to the Dr Foster website
	Given I have navigated to the Dr Foster website
	When I enter my username and password
	And I click on the login button
	Then I am logged into the tools dashboard page