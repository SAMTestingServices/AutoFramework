@featureRegression

Feature: Analyse By dropdown sanity check
	Analysis functionality in HIP allows a huge variation of filters to be set-up.
	Validating the feature requires cycling through a range of combinations to ensure no errors.
	The test also provides regression testing that is performed after monthly data loads.

Background: 
	Given I am logged into the Dr Foster website
	And I am viewing data as the Aintree University Hospital NHS Foundation Trust
	And I have selected HIP from the dashboard

Scenario: Default dropdown options are set as expected
	Given I select the Analysis tab
	And select the Drill Down menu option
	And the value for the Data Set option has been set to <dataSetDDOption>
		| dataSetDDOption |
		| Admitted        |
	When the Analyse By option has been set to <analyseByDDOption>
		| analyseByDDOption |
		| ACS Condition     |
	Then the page refreshes and shows a chart with the <analyseByDDOption> value in the title