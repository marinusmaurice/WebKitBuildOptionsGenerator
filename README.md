# WebKitBuildOptionsGenerator
Generates options for running "build-webkit" script. **Windows only**
Uses .netcore3.1. You can most likely change it to suit your needs

When building webkit you would typically end up running the 'build-webkit' perl command. e.g.
perl Tools/Scripts/build-webkit --wincairo --release

This just provides a front end for the command : **perl Tools/Scripts/build-webkit --help**, to save you a few keystrokes if you like to play around with the options.
The options available in the gui are hardcoded . Probably should read it from a text file at some point. .. but right now i'm too lazy to do that. but it should be simple to do.

Added zip containing binary files : WebkitBuildOptionsGenerator-0.0.0.1.zip
 
What you would see in powershell:  

![build-webkit --help](https://github.com/marinusmaurice/WebKitBuildOptionsGenerator/blob/main/powershell_build_webkit.png "build-webkit --help")

Front-end:  

![Front-end build-webkit](https://github.com/marinusmaurice/WebKitBuildOptionsGenerator/blob/main/gui_build_webkit.png "Front-end for build-webkit")

# License
Do with it however you see fit
