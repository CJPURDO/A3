Feature: Transfer amount from one account to another
	In order to transfer amount
	As a program user
	I need to select which account the money is debited from and which account the money is credited to

	@mytag
Scenario: Transfer funds from Everyday to Investment 
	Given the first account is Everyday
	And the Everyday account balance is 100
	And second account is Investment
	And the Investment account balance is 100
	When you transfer 50
	Then the Everyday account will hold 50
	And the Investment account will hold 150

	@mytag
Scenario: Transfer funds from Everyday to Omni
	Given the first account is Everyday
	And the Everyday account balance is 100
	And the second account is Omni
	And the Omni account balance is 100
	When you transfer 50
	Then the Everyday account will hold 50
	And the Omni account will hold 150

	@mytag
Scenario: Transfer funds from Everyday to Everyday 
	Given the first account is Everyday
	And the Everyday account balance is 100
	And the second account is the other Everyday
	And the other Everyday account balance is 100
	When you transfer 50
	Then the Everyday account will hold 50
	And the other Everyday account will hold 150

	@mytag
Scenario: Transfer funds from Investment to Everyday 
	Given the first account is Investment
	And the Investment account balance is 100
	And the second account is Everyday
	And the Everyday account balance is 100
	When you transfer 50
	Then the Investment account will hold 50
	And the Everyday account will hold 150

	@mytag
Scenario: Transfer funds from Investment to Omni
	Given the first account is Investment
	And the Investment account balance is 100
	And the second account is Omni
	And the Omni account balance is 100
	When you transfer 50
	Then the Investment account will hold 50
	And the Omni account will hold 150

	@mytag
Scenario: Transfer funds from Investment to  Investment
	Given the first account is Investment
	And the Investment account balance is 100
	And the second account is the other Investment
	And the other Investment account balance is 100
	When you transfer 50
	Then the Investment account will hold 50
	And the other Investment account will hold 150

	@mytag
Scenario: Transfer funds from Omni to Everyday 
	Given the first account is Omni
	And the Omni account balance is 100
	And the second account is Everyday
	And the Everyday account balance is 100
	When you transfer 50
	Then the Omni account will hold 50
	And the Everyday account will hold 150

	@mytag
Scenario: Transfer funds from Omni to Investment
	Given the first account is Omni
	And the the Omni account balance is 100
	And the second account is Investment
	And the Investment account balance is 100
	When you transfer 50
	Then the Omni account will hold 50
	And the Investment account will hold 150

	@mytag
Scenario: Transfer funds from Omni to Omni
	Given the first account is Omni
	And the Omni account balance is 100
	And the second account is the other Omni
	And the other Omni account balance is 100
	When you transfer 50
	Then the Omni account will hold 50
	And the other Omni account will hold 150

	@mytag
Scenario: Transfer funds with enough balance plus overdraft limit to complete transaction
	Given the first account is Omni
	And the Omni balance is 100
	And the Omni overdraft limit is 100
	And the second account is Investment
	And the Investment account balance is 50
	When you transfer 200
	Then the Omni account will hold -100
	And the Investment account will hold 250

	@mytag
Scenario: Transfer funds with not enough balance plus overdraft limit to complete transaction
	Given the first account is Omni
	And the Omni balance is 100
	And the Omni overdraft limit is 100
	And the second account is Investment
	And the Investment account balance is 50
	When you transfer 250
	Then the Omni account will hold 90
	And the Investment account will hold 50

	@mytag
Scenario: Transfer insufficent funds to complete transaction as a bank staff member
	Given the first account is Everyday
	And the Everday balance is 100
	And the second account is Investment
	And the Investment account balance is 50
	When you transfer 200
	Then the Everyday account will hold 95
	And the Investment account will hold 50

	@mytag
Scenario: Transfer insufficent funds to complete transaction as a non bank staff member
	Given the first account is Everyday
	And the Everday balance is 100
	And the second account is Investment
	And the Investment account balance is 50
	When you transfer 200
	Then the Everyday account will hold 90
	And the Investment account will hold 50




