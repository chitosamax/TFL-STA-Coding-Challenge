Feature: InvalidDetails
	Simple calculator for adding two numbers
@mytag
Scenario: Add two numbers
	Given I am on the TfL Journey Planner page
	When I enter an invalid start location
	When I enter an invalid end location
	When I attempt to plan the journey
	Then I should see an error message indicating no results