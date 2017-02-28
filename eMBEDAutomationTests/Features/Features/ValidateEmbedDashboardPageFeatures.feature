@embedsmoketest
Feature: ValidateEmbedDashboardPageFeatures
	This sanity test is to ensure the state of Dashboard page elements and ensure all links, panels, etc. 
	are present and work as expected, before the main testing takes place

Background: 
	Given I am logged into eMBED and viewing the Dashboard page

Scenario: A top navigation section provides links to CIM, account and view settings
	Given the top navigation elements have loaded
	Then each <topLink> goes to the <expectedLocation>
	# Placeholder values here for reference
	| topLink     | expectedLocation                      |
	| Logo        | http://testing05/                     |
	| CIM         | http://testing05:50000/mbed           |
	| UserName    | http://testing05/profile/mcrowther    |
	| SignOut     | http://testing05/users/account/logoff |
	| OrgSelector | org-selector                          |

Scenario: A Filter element allows users to select month and year range for analysis
	Given I have clicked on the filter burger icon
	When I select a month and year range
	Then the data returned matches the date range selected

Scenario: A set of navigation links are shown that take the user to relevent dashboard sections 
	Given the navigation elements are present on the page
	And the SAR <item> is active
	And each other <item> is present and inactive but selectable
	Then they link to the expected <navLocation>
	| item        | navLocation                                     |
	| SAR         | http://testing05:50000/mbed#/performance        |
	| RiskStrat   | http://testing05:50000/mbed#/riskstratification |
	| GPOS        | http://testing05:50000/mbed#/gpos               |
	| Performance | http://testing05:50000/mbed/performance         |

Scenario: Secondary Care Indicators panel can be expanded to view SAR by ACS and by Diagnosis data
	Given I have expanded the Secondary Care Indicators panel
	And I can see the SAR by ACS and by Diagnosis sections
	Then I can expand both of these to view the data in each panel section

Scenario: A user can export the information on the dashboard to PDF
	Given I have selected the Export to PDF tool icon in a <panel>
	When a PDF file save dialogue is opened
	Then I can save the PDF and get returned to the main screen
	# Automagically enumerate these
	| panel       |
	| Secondary   |
	| byACS       |
	| byDiagnosis |

Scenario: Footer text provides required copyright notices and reference links
	Given the footer has copyright notices and reference links
	Then the copyright notices should state the current year
	And reference links should go to the correct locations
	# Automagically enumerate these
	| linkText     | linkLocation            |
	| My DR Foster | http://testing05:50000/ |
	| Feedback     | OpenUserVoiceDialogue   |