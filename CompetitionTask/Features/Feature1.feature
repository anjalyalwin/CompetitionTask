Feature: Feature1

As a local host admin
I would like to create , edit and delete manage listings
so that i can manage listings and share skills successfully

@tag1
Scenario: Create share skills and manage listings
	Given I logged into local host
	When I navigate to shareskills page
	And I added skills in shareskills
	Then The skills added successfully to manage listings
