Feature: Feature1

A short summary of the feature

//Background: Preconditions for this feature
//Hooks: Preconditions that can be used for multiple features

//@tag1			: Used to filter scenarios for execution. Eg: @ui
//Scenario: A   : Scenario Name
//	Given B     : When B is there
//	When C		: When C happens
//	Then D		: Then D should happen

Background: 
Given Open chrome


@CategoryA
Scenario: A
	Given B
	When C
	Then D

@CategoryA @CategoryB
Scenario: ABCD
	Given B
	When C
	Then D

@CategoryA @CategoryC
Scenario: Sample
	Given B
	When I click on 'Submit'
	Then D

@CategoryA @CategoryC
Scenario: Sample2
	Given B
	When I click on 'Exit'
	Then D


@CategoryA @CategoryC
Scenario: Another Scenario
	Given B
	When I click on 'Exit'
	Then D
