SC Joystick Mapper V 2.27 - Build 61 BETA
(c) Cassini, StandardToaster - 25-Dec-2016

Contains 9 files:

SCJMapper.exe                The program (V2.27)
SCJMapper.exe.config         Program config (V2.27)              - MUST be in the same folder as the Exe file
SharpDX.DirectInput.dll      Managed DirectInput Assembly        - MUST be in the same folder as the Exe file
SharpDX.dll                  Managed DirectX Assembly            - MUST be in the same folder as the Exe file
OpenTK.dll                   Managed OpenGL Assembly             - MUST be in the same folder as the Exe file
OpenTK.GLControl.dll         Managed OpenGL Assembly             - MUST be in the same folder as the Exe file
Ionic.Zip.Reduced.dll        Managed Zip Assembly                - MUST be in the same folder as the Exe file
log4net.dll                  Managed Logging Assembly            - MUST be in the same folder as the Exe file
log4net.config.OFF           Config file for logging             - To use it - rename as  log4net.config and run the program
                                                                   then look for  trace.log  in the same folder
SCJMapper_QGuide V2.27beta.pdf    Quick Guide
ReadMe.txt                   This file

graphics folder              Skybox Images                       - graphics folder MUST be in the same folder as the Exe file


Read the Guide first RTFM ;-)
Put all files into one folder and hit SCJMapper.exe to run it

For Updates and information visit:
https://github.com/SCToolsfactory/SCJMapper-V2

Scanned for viruses before packing... 
cassini@burri-web.org

Changelog:
V 2.27 - BETA Build 61
- add - Collapse/Expand in context menu in Mapping tree
- improvement - actionmaps are taken from the defaultProfile and will no longer need a program update
- improvement - rename Blend to Disable
- fix - an issue in Seetings for actionmap ignore handling
- update - fallback default profile from SC 2.6.0 alpha
- update - doc SCJMapper_QGuide V2.27beta.pdf
V 2.26 - BETA Build 60
- add - new actionmaps from SC 2.5.0 alpha to choose from in Settings
- update - fallback default profile from SC 2.5.0 alpha
V 2.25 - BETA Build 59
- fix - an issue in parsing options from imported maps
- add - an option to show the actiontree as CSV list with more/less details (change in Settings)
- improvement - In table view add possibility to Blend All visible unmapped entries
V 2.24 - BETA Build 58
- fix - some trouble in SC path finding
V 2.23 - BETA Build 57
- update - Using .Net 4.5.2 Now (seems to handle some scaling issues WinForm apps)
- update - Try to find the SC path also as StarCitizen\Live (instead of Public) was mentioned for SC2.2.2 onwards ???
- fix - addbind UNDEF removed when assigned
- improvement - Issue a infobox if the Client folder cannot be found 
               (please submit the complete folder structure of your installation as bug report ...)
- add - a table display for mappings
- some internal stuff (namespaces etc)
- update - doc SCJMapper_QGuide V2.23beta.pdf
V 2.22 - BETA Build 56
- fix - try again to fix Win10 scaling issues for some PCs (hidden assignment area)
- improvement - actions with a profile modifier attached will show underlined in the action tree
- improvement - less offensive gamepad color mark ...
- add - a button to dump the used defaultProfile in the right area
- some internal stuff
- update - doc SCJMapper_QGuide V2.22beta.pdf
V 2.21 - BETA Build 55
- fix #40 added Tab entry in Ctrl. context menu
- fix - try to fix Win10 scaling issues (hidden assignment area)
- fix - profile tree color indication also applied when re-reading defaultProfile
- improvement - enumerates up to 12 devices now (though not tested as I don't have 12 ..)
- add - use of SCA 2.2 provided defaultProfile (new location and format)
- add - indication of the used defaultProfile
- add - built in defaultProfile updated to SCA 2.2 
V 2.19 - BETA Build 52
- fix #37 improved defaultProfile Parsing
- fix #38 locale issue - changed App number formatting to US
- fix #39 changed equal to equals string for kbd entry
- add - default actionmap to choose from (it is on the ignore list)
V 2.18 - BETA Build 51
- fix - layout works now for Win10
- fix - uses game defaultProfile again
- fix - keyboard command for all Ctrl keys fixed
- fix - keyboard command formatting
- improvement - timeout ~4 sec for kbd modifiers in Joystick Mode (Esc no longer needed)
- improvement - ActivationMode handling finished
- improvement - user ActivationMode change indication in mapping tree
- improvement - Blending adds multiTap=1 to overwrite double taps
- improvement - Dump List: added ActivationModes; device checkBox applied to list
- update - doc SCJMapper_QGuide V2.18beta.pdf
V 2.17 - BETA Build 50
- update - Updated for SC Alpha 2.0/2.1PTU using new actionmap syntax (no longer use device attribute)
- update - Complete new QuickReference Guide
- update - Supports actionmaps with <profile version="1" optionsVersion="2" rebindVersion="2"> 
- add - ActivationMode - Use Context Menu in ActionTree (or read the manual)
- add - PTU file usage in Settings
- add - Prepared JS Modifiers (but SC cannot right now - so it is disabled)
- add - full mouse settings
- improvement - some GUI improvements
- improvement - reworked blending
- removed - global JS or GP blend options in Settings
- removed - ignoreversion from Settings
- NOTE: - Dump Log does not work right now as CIG does no longer list detected controllers in the log file
- NOTE: - Right now a number of binds behave erratically e.g. addbind does not work at all
          so be aware that your map is not necessarily wrong but the game may just have a bug there
V 2.16 - BETA Build 49
- update - Updated for AC Alpha 1.3 defaultProfile does no longer have js1_ or xi_ marks form commands
- NOTE: - Dump Log does not work right now as CIG does no longer list detected controllers in the log file
V 2.15 - BETA Build 48
- update - Updated for AC Alpha 1.1.6 new files locations to find files and mappings
- NOTE: - Dump Log does not work right now as CIG does no longer list detected controllers in the log file
V 2.14 - BETA Build 47
- update - added new defaultProfile (CIG allows some more joystick mappings)
V 2.13 - BETA Build 46
- update - added new defaultProfile and actionmaps from AC 1.1.1
- add - keyboard modifier for joystick (e.g. rctrl+js1_xy) - Press ESC to clear modifiers
- fix - device checkboxes are now applied after Reassign
- fix - invert checkbox handling (removed flight invert - use the one in Tuning)
- fix - Add UICustomization Header and Devices List in any case
V 2.12 - BETA Build 45
- improvement - SCJM maintains mappings in USER rather than data folder (AC 1.03)
- improvement - UICustomization Header for joystick updated (label is the filename minus "layout_") (AC 1.03)
V 2.11 - BETA Build 44
- fix - reading of deadzone value (if not a number should not break anymore)
- fix - writing the proper deadzone XML if first used
- fix - reading addbind commands from existing mappings will appear now in the tree
- improvement - better handling of the default mapping name from config file
- improvement - mapping name added to XML mapping (first line comment extended with mapping name)
V 2.10 - Build 43 - Production
- new feature - added Action Tree context menu for Assign, Clear and Blend
- fix - issue for Js Reassignment if more than one was not yet assigned
- improvement - Right click in Action Tree selects the items (no need to select and then right click anymore)
V 2.10 - BETA Build 41
- fix - issue with null ptr assignment in Device Tuning (review and fix of AC1.0 changes)
- fix - disabled first joystick tab when gamepad is second or later
- improvement - added tooltips for device tabs showing Name and GUID
- improvement - added full 4 number version for beta builds
V 2.10 - BETA Build 40
- rework for AC 1.0
- new feature - add DumpLog to get the AC detected Controller assignments from logfile
- new feature - add Invert checkboxes for supported option items
- new feature - context menu in treeview allows to add/delete action sub items (support addbind mapping in XML)
- update - cannot longer assign cross device mappings (AC 1.0 related - use addbind above)
- update - new options naming and structure (not compatible with pre 2.10 - delete them in the file and then reload)
- update - Profile Version to 1
V 2.8 - BETA Build 37
- new feature - add checkboxes to show Joystick, Gamepad, Kbd and Mapped Only
- fix - Blended ones don't reload with proper visual
V 2.8 - BETA Build 36
- new feature - add invert for single mappings
- improvement - initialization and assignment of Joystick devices
V 2.8 - BETA Build 34
- new feature - add keyboard input
- new feature - add gamepad input as xboxpad
- new feature - add gamepad for tuning 
- new feature - blend single entries with <Space>
- fix - tuning copy to all axis now applies immediately
- improvement - cleanup of some inconsistencies
V 2.7 - Build 33
- fix - if an axis is not mapped the prog will not longer crash (was null ptr exception)
- doc update 2.7
V 2.7 - BETA
- new feature - Joystick Tuning
V 2.6
- fix - taking actionmaps from config file now works
- improvement - added actionmap vehicle_driver
V 2.5
- new feature - support and maintain option tags
- improvement - support and maintain version and ignoreversion attribute / can force ignoreversion="1"
- improvement - makes backup copy before each save (in my documents e.g. layout_my_xyz.xml.backup)
- Update of the Guide for V2.5
V 2.4
- improvement - add new actionmaps for AC 0.9 (flycam, spaceship_turret)
- improvement - supports now assignment of js1 .. js8 - SC may not support all though...
- Update of the Guide for V2.4
V 2.3
- new feature - allow reassignment of the jsN group
- improvement - uniquely identified devices with the same name (use GUID)
- improvement - shows jsN assignment in Joystick tab
- improvement - detection of the SC install path extended to one more Registry entry
- fix - blend unmapped works properly now
- fix - manual entry of SC directory works now
- Update of the Guide for V2.3
V 2.2
- new feature - option to ignore actionmaps in Settings
- improvement - add actionmaps for multiplayer, singleplayer, player
- improvement - GUI layout of Joystick tabs for more than 4 devices
- Update of the Guide for V2.2
V 2.1
- program is maintained at "https://github.com/SCToolsfactory/SCJMapper-V2/releases"
- new feature - option to blend unmapped actions
- improvement - ignore buttons in Settings
- improvement - override the built in detection of the SC folder in Settings
- added - trace log for resolving crash and other issues
- Update of the Guide for V2.1
V 2.0
- program is maintained at "https://github.com/bm98/SCJMapper-V2/releases"
- new feature - get defaultProfile.xml from game assets
- new feature - get actionsmaps from game assets
- new feature - reset to defaults
- new feature - load and save own maps to gamefolders (makes backup in My Documents\SCJMapper)
- new feature - filter the action tree
- new feature - drag and drop an mapping file into the XML window
- new feature - make throttle assignment for any axis
- improved joystick detection (jitter avoidance, limit can be set in Program config file)
- improved button detection (blend buttons that are always on)
- improved sizeable window
- improved settings persist between sessions
- Update of the Guide for V2.0
- removed defaultProfile.xml from distribution (REMOVE IT FROM YOUR FOLDER - else it will be taken as action list)
V 1.4PRE
- using a new Managed DirectX assembly and built with .Net4 (Hope this works for Win8.1)
- added Joystick properties and Axis Names from the Joystick driver
V 1.3
- new feature - read the original defaultProfile.xml from SC to derive the actions (must be in the EXE folder)
- added support for up to 8 devices
- added multibinding i.e. bind the same action to multiple buttons, one for kbd, one for xbox etc. if the profile supports it
- added Dump List - a readable list of the commands (can be saved as txt file - using Save as)
- fixed "Find 1st" 
- Update of the Guide 
- removed MappingVars file from distribution (REMOVE IT FROM YOUR FOLDER - else it will be taken as action list)
V 1.2
- added support for rebinding xboxpad and ps3pad
- added Find 1st  for a Control
- fixed Hat direction not maintained as last Control used
- some GUI refinements
- Update of the Guide (incl MappingVar.csv format)
MappingVar file
- added commands that where missing
- changed from keyboard to xboxpad rebinding where possible to leave kbd intact
V 1.1 
- fixed issue with less than 3 joysticks attached
V 1.0 initial 
