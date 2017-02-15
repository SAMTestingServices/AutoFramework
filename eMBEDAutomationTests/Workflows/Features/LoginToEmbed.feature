Feature: LoginToEmbed
	As a user of eMBED
	I want to login by entering my user account details
	In order to have access to the dashboard page and rest of the site functionality

@smoke
Scenario: A user can successfully login to eMBED
	Given I have navigated to the eMBED website
	When I enter my username and password
	And I click on the login button
	Then I am logged into the eMbed dashboard page