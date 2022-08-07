# WebKitBuildOptionsGenerator
Generates options for running "build-webkit" script. **Windows only**
Uses .netcore3.1. You can most likely change it to suit your needs

When building webkit you would typically end up running the 'build-webkit' perl command. e.g.
perl Tools/Scripts/build-webkit --wincairo --release

This just provides a front end for the command : **perl Tools/Scripts/build-webkit --help**, to save you a few keystrokes if you like to play around with the options.
The options available in the gui are hardcoded . Probably should read it from a text file at some point. .. but right now i'm too lazy to do that. but it should be simple to do.
 
What you would see in powershell:


# License
Do with it however you see fit
