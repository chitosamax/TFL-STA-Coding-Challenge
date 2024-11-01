Feature: EditPreferences
	Edit preference to choose route with least walking
@mytag
Scenario: Edit preference for planned journey
	Given that the journey is planned
	And I click on the edit preference button
	And I select routes with least walking
	When I update journey
	Then I should be able to validate journey time