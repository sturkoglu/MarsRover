Feature: Rovers
	In order to avoid driving off the multi-million-dollar rover off the plateau
	As a rover operator
	I want to cancel invalid cammands

Scenario: Deploy two rovers
	Given a plateau 5 5
	Given a rover
	And the rover deployed to 1 3 N
	And MRM command is send
	When commands are executed
	Then the rover should be at 2 4 E
	Given a rover
	And the rover deployed to 4 2 E
	And RML command is send
	When commands are executed
	Then the rover should be at 4 1 E

Scenario: Deploy two rovers with different size plateau
	Given a plateau 6 5
	Given a rover
	And the rover deployed to 5 3 N
	And MRM command is send
	When commands are executed
	Then the rover should be at 6 4 E
	Given a rover
	And the rover deployed to 6 6 E
	And RML command is send
	When commands are executed
	Then the rover should be at 6 5 E

Scenario: One rover explore it all
	Given a plateau 5 5
	Given a rover
	And the rover deployed to 1 1 N
	And MMMMRMRMMMMLMLMMMMRMRMMMMLMLMMMM command is send
	When commands are executed
	Then the rover should be at 5 5 N
	Given a rover
	And the rover deployed to 4 2 E
	And RML command is send
	When commands are executed
	Then the rover should be at 4 1 E

Scenario: Deploy a rover North-East border of a plateau
	Given a plateau 5 5
	Given a rover
	And the rover deployed to 5 5 N
	And M command is send
	When commands are executed
	Then the rover should be at 5 5 N
	And RM command is send
	When commands are executed
	Then the rover should be at 5 5 E

Scenario: Deploy a rover North-West border of a plateau
	Given a plateau 5 5
	Given a rover
	And the rover deployed to 1 5 N
	And M command is send
	When commands are executed
	Then the rover should be at 1 5 N
	And LM command is send
	When commands are executed
	Then the rover should be at 1 5 W

Scenario: Deploy a rover South-West border of a plateau
	Given a plateau 5 5
	Given a rover
	And the rover deployed to 1 1 S
	And M command is send
	When commands are executed
	Then the rover should be at 1 1 S
	And RM command is send
	When commands are executed
	Then the rover should be at 1 1 W

Scenario: Deploy a rover South-East border of a plateau
	Given a plateau 5 5
	Given a rover
	And the rover deployed to 5 1 S
	And M command is send
	When commands are executed
	Then the rover should be at 5 1 S
	And LM command is send
	When commands are executed
	Then the rover should be at 5 1 E