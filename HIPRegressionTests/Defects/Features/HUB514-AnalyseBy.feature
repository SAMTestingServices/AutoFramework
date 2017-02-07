@bugRegression

Feature: HUB-514 Ensure Analyse By types run without error
	HIP users observed errors when selecting from 11 Analyse By LOS types.
	This regression test checks the feature to confirm no errors recur

# Applies to http://jiralive:8080/browse/HUB-514

Background: 
	Given I am logged into the Dr Foster website
	And I am viewing data as the Aintree University Hospital NHS Foundation Trust
	And I have selected HIP from the dashboard

Scenario: LOS Analyse By dropdown items invoke reports without error
	Given I select the Analysis tab
	And select the Drill Down menu option
	And from the Analyse By dropdown select an Analyse By <listItem> previously seen to error
		| listItem                    |
		| Length of Stay              |
		| Length of Stay (Superspell) |
		| LOS (0 or 1 +)              |
		| LOS (1 week)                |
		| LOS (6 bands)               |
		| LOS (national quartile)     |
		| LOS (Post-Op)               |
		| LOS (Pre-Op)                |
		| LOS (S/S national quartile) |
		| LOS (Short Stay)            |
		| LOS (Weekly)                |
	Then the corresponding Analyse By report should be produced without error