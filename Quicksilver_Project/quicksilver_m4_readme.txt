README
Team Quicksilver
Milestone4
CS 6457

##### Team Members ##### 
Name: Rahmaan Lodhia
Email: rahmaanl@gatech.edu
Prism: rlodhia3

Name: William Gu
Email: wgu36@gatech.edu
Prism: wgu36

Name: Larry He
Email: larry.he@gatech.edu
Prism: lhe44

Name: Mitch Leff
Email: mal8690@gmail.com
Prism: mleff3

##### Group Requirements ##### 
- (COMPLETE) Navigation Mesh Rig:  Four navigation rigs were created for differing heights of platforms and differing size of characters.
- (COMPLETE) Navigation Targets: Sets of navigation targets were created for use on their own or in conjunction with a waypoint network.
- (COMPLETE) Waypoint Network Rig:  Two Waypoint Network Rigs were created for use with two of our AIs.
- (COMPLETE) Waypoint Route Rig:  One Waypoint Route Rig was created for use with one of our AIs.
- (COMPLETE) Mechanim Motor:  All AIs used utilized the Mechanim Motor to pass parameters to the Animation Controller.
- (COMPLETE) Mechanim Animator:  All AIs have animation states levereged by using the Set Mechanim Parameter Node in the RAIN AI rig.
- (COMPLETE) Custom RAIN AI Element:  A RAIN AI action was created to determine where a leading shot should be aimed based on the direction of the player movement.


##### Resources Used by Group ##### 
### From Previous Milestone ###
- Asset: Standard Assets by Unity Technologies
- URL: https://www.assetstore.unity3d.com/en/#!/content/32351
- Usage: The third person controller asset was used for our character controller.  The animations were used, and some elements of the scripting was used as a base for character movement.  Any scripts used were heavily modified to match our goal in character movement, so all scripts used are nothing like the original.

- Asset: FX Mega Pack 2 by Unluck Software
- URL: https://www.assetstore.unity3d.com/en/#!/content/14208
- Usage: Some particle systems were used to create effects for the robot that were used by every group member.

- Asset: Tile Tool by Unluck Software
- URL: https://www.assetstore.unity3d.com/en/#!/content/19904
- Usage: The objects and tiles used in this asset were used to create the group level.

- Asset: Free Sci-Fi Textures bu Luca Eberhart
- URL: https://www.assetstore.unity3d.com/en/#!/content/9933
- Usage: The tiles used in this asset were used to create the group level.

- Asset: Sci-Fi Door by 3DMondra
- URL: https://www.assetstore.unity3d.com/en/#!/content/21813
- Usage: The objects used in this asset were used to create the group level.

- Asset: Warriors Pack Bundle 1 Free by Explosive
- URL: https://www.assetstore.unity3d.com/en/#!/content/36405
- Usage: All Enemy AI models were taken from this model pack.  Each one is used by a group member for their individual AI.

- Asset: RAIN AI for Unity
- URL: https://www.assetstore.unity3d.com/en/#!/content/23569
- Usage: Used to program all AI in level.

- Asset: Volume Particle Light
- URL: https://www.assetstore.unity3d.com/en/#!/content/10105
- Usage: Used for the Ranged AI's projectile attack.

### Added to Current Milestone ###
- Asset: Introduction to New UI by 3D Buzz
- URL: http://www.3dbuzz.com/training/view/modern-ui-dev-in-unity-46
- Usage: Custom button images were used for UI menus, and tutorial aided in their creation

- Asset: Crystal Font by Felipe Munoz
- URL: http://openfontlibrary.org/en/font/crystal
- License URL: http://creativecommons.org/licenses/by/3.0/legalcode
- Usage: Used as main font throughout game

- Asset: Day 69, Day 60, Day 23 by Mark Sparling
- URL: http://www.marksparling.com/
- Usage: These royalty-free songs were used for the in-game background music

- Asset: 2D Platformer + Free 2D Assets Pack by Brackeys
- URL: http://www.brackeys.com/preview/2d-platformer-course/
- Usage: Fading script was used for screen transitions and tutorial implementation was loosely followed in incorporating transition functionality in game


##### Build Instructions ##### 
Use standard build settings for Web Player. Ensure all three scenes are included in build.

##### Grader Instructions #####
## Group Component ## 
- Controls:
	- Recommended input is a XBOX 360 Controller 
	- Walk/Run: WASD / Leftstick on Gamepad (Character will turn towards the direction of the keypress relative to the camera as he moves)
	- Jump: Spacebar / (A) Gamepad Button
	- Dash: Left Shift / (B) Gamepad Button
	- Air Dash: Left Shift / (B) Gamepade Button WHILE IN AIR AND SMALL ONLY
	- Attack: Q / (X) Gamepad Button
	- Shoot: R / (Y) Gamepad Button
	- Raise Shield: E / Left Bumper Gamepad Button
	- Shrink/Grow: Left Alt / Right Bumper Gamepad Button
	- Crouch: C / Leftstick click in (This is toggle button.  Character will remain crouched until button is pushed again)
	- Activate Ragdoll: K / Rightstick click in (This is a toggle button.  Chracter will remain a Ragdoll until button is pushed again)

- Viewing Requirements:


##### Unity Scene #####
The main file used is quicksilver_title.unity.

##### URL ######
http://www.prism.gatech.edu/~rlodhia3/CS6457/Milestone4/Milestone4_Player
