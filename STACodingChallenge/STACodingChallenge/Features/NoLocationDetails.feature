Feature: NoLocationDetails
	When no location details are entered

@mytag
Scenario: No location entered
	Given I am on the Journey Planner page bfor TFL
	When I leave both location fields empty
	When I attempt to click on the plan the journey button
	Then I should see an error message indicating that locations are required