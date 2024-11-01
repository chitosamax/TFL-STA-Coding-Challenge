Feature: TFL Journey Planner 

@mytag
Scenario: Plan a valid journey using autocomplete selection
	Given I navigate to TFL Journey Planner Page
	When I select "Leicester Square Underground Station" from the start location suggestions
    And I select "Covent Garden Underground Station" from the end location suggestions
    And I click the "Plan my journey" button
	Then I should see the journey options for both walking and cycling
	And I validate that the walking time for the journey is displayed
	And I validate the cycling time is displayed
	