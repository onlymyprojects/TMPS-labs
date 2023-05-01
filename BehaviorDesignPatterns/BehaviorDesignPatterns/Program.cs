using BehaviorDesignPatterns.State;
using BehaviorDesignPatterns.Strategy;

// STATE
var headlights = new Headlights(new HeadlightsTurnedOffState());

headlights.TurnOnOff();
headlights.TurnOnOff();


// STRATEGY
IDriveStrategy driveStrategy = new DriveForwardStrategy();
var driving = new Driving(driveStrategy);
driving.Drive();

IDriveStrategy driveStrategy2 = new DriveBackwardStrategy();
var driving2 = new Driving(driveStrategy2);
driving2.Drive();