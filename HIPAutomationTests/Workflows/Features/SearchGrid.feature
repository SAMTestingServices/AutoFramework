@featureRegression

Feature: Ability to search for a fixture using a variety of search terms and open the desired fixture in details view
	As an Operations Tanker user of the Arc system, I should be able to search for a fixture via the fixture grid and load that fixture.

Background: 
	Given I have navigated to the Arc website
	And have logged in
	And I am in operations in Tanker View

Scenario: Search by Gain ID 
	Given I am on the Fixture Grid page
	And I enter the following search terms into the Search bar: "107239-01-TK-05-17" 
	And click Return 
	Then the correct fixture with the Gain ID = "107239-01-TK-05-17" should be returned as the first result
	And there should be 1 result returned
	