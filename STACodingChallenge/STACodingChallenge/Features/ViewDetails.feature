Feature: ViewDetails
	check complete access information

@mytag
Scenario: Check access information at Covent Underground station
	Given that I have planned a journey to Covent Garden Underground Station 
	When I click on the view details button
	Then I should be able to see complete access information in Covent Garden Underground station