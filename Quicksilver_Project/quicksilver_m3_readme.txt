README
Team Quicksilver
Milestone2
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
- (COMPLETE) Basic Physics Interaction:  Our character is equipped with a rigidbody, whose mass parameters vary with what size he is.  He is able to interact with any other rigidbodies in the scene.
- (COMPLETE) Collider Animation:  Our character's capsule collider varies with the current stance he is in.  If he is jumping, it lowers in height.  If he is crouching, the sized is reduced to fit his crouched body.  In addition, the shield's collider varies with his raising animation via curves.  As the character raised the shield, its collider increases in size till full and lowers as the shield lowers.
- (COMPLETE) Ragdoll Simulation:  The character is equipped with a Ragdoll body.  This is enabled in game under certain conditions or manually by pressing K or Rightstick click on the gamepad.  It can be turned off via the same Ragdoll button.
- (COMPLETE) Game Feel:
		- (COMPLETE) Realtime, Responsive Control:  The character has real-time control.  All actions are determined by the users.  He can walk, run, jump, crouch, attack, block, shrink, and dash.  The controls are described in detail below.
		- (COMPLETE) Physical Target:  The physical target is bulky, heavy character that can on demand shrink to smaller, light, and floaty character almost giving the feeling of flight as it moves across the screen like a bullet.
		- (COMPLETE) Emotional Target:  The emotional target of the character is a sense of broken and dying.  The robot is constantly expending electricity around his body.  This gives an indication of a broken hardware, and in this case a broken person.  Everything he does, including just standing in existence, requires energy, and that energy dissipates into the air around him.
		- For all members the following polish effects are in play for the Game Feel level requirement:
			- Landing on a area designated with a "Floor" tag in Unity will create a landing smoke particle effect.
			- Dashing will create an explosion behind the character and display the words "BANG" to give the feeling that he is being shot from a gun.
			- Dashing into a wall denoted with a "WALL" tag in Unity will create a "BONK" effect and shoot out rocks from the collision point.
			- Shrinking will create an aura effect that lasts for the duration of the transition
			- Holding up the shield or having the shield in front of you while dashing will create a wave barrier to denote how protective the shield is.


##### Individual Requirements ##### 
## Rahmaan Lodhia ##
- Level Theme: Dungeon Crawler.  The character is placed in a dungeon with dangerous traps that he must cross to get to the treasure.  The level requires skillful platforming and deciding when best to switch size forms as some traps are weight sensitive.
- (COMPLETE) Five unique physics actors:
	- Crates with massive rigidbodies that can be pushed around
	- Bombs with light rigidbodies that can be rolled around
	- Chains hanging from arches and ceilings that move as interactions with them occur
	- Trap door that drops open if an object is exerting force on top of it
	- A bridge with its rigidbodies linked together to give a rickety effect
	- Hanging platforms attached to the previously mentioned chains
- (COMPLETE) At least two compound objects:
	- Chains with hinge joints between nodes
	- Hanging platforms with fixed joints to Chains
	- Bridge with hinge joints between woodboards
	- Trapdoor with hinge joints
- (COMPLETE) Variable terrain: Terrain has several ramps, hanging platforms, bridges, pits, and arches.
- (COMPLETE) At least three material sounds:
	- Metal footsteps play when walking on the dark area of the level that denotes a metallic or solid terrain.
	- Gravel footsteps play when walking on the light gray area of the level that denotes a gravel and dirt terrain.
	- Woodboard footsteps play when walking on the woooden bridge.
- (COMPLETE) Game Feel:
	- All polish effects listed above under group requirements
	- When walking on the gravel areas in the level, dirt will explode out from under the feet
	- When falling into a spike trap, the character will enter a ragdoll state and and the words "SMACK" will appear above the character's body indicating that the player has failed and died.
	- Weight based environment:
		- Bridge can collapse if you jump on it while in normal sized form, but it will stay whole if you operate in shrunken state
		- Trap door opens faster if you are in normal sized form, and very slowly or not at all if you are in shrunken state

## William Gu ##
- Level Theme: Icy Maze
- (COMPLETE) Five unique physics actors:
        - Boxes with rigidbodies that can be pushed around.
        - A sign post with a rigidbody that you can push to make it swing faster.
        - A swing with a rigidbody that you can push and make it swing in circles.
        - Skeletons with rigidbodies that you can push down.
        - A ball with a rigidbody that you can push around (mainly used to push into the pond).
        - Wrecking ball with rigidbodies that swings around.
- (COMPLETE) At least two compound objects:
        - The wrecking ball has hinge joints and a fixed joint each connected to each other.
- (COMPLETE) Variable terrain:
        - There are some stairs and different height grounds like entering the pond.
- (COMPLETE) At least three material sounds:
        - If you jump onto the pond, there should be a splash noise.
        - When you enter the maze while running, you will hear a crowd cheering you on.
        - When you bump into a skeleton, you will hear its bones rattling.
        - When you run into the wrecking ball, you will hear a metal clang.
- (COMPLETE) Game Feel:
        - When you walk into the water, there will be a bigger water burst particle effect.
        - When you enter the maze, there will be a light explosion signaling you entering the maze.
        - If you move the ball into the pond, it will be float (it is a bit off though).
        - There will be ice rain to make the game feel more intense.
        
## Larry He ##
- Level Theme: Space station
- (COMPLETE) Five unique physics actors:
	-Stairs with joints to climb
	-Metallic balls that roll
	-Turret shooting flames. Can kill you.
	-Another turret type that can't kill you.
	-Boxes located past the hanging stairs
- (COMPLETE) At least two compound objects:
	-Hanging set of stairs
	-Connected set of stairs
- (COMPLETE) Variable terrain:
	-Stairs to climb
- (COMPLETE) At least three material sounds:
	-Walking on orange platform makes metal sound
	-Walking on walkway makes slightly different metal sound
	-Walking on stairs makes thudding sounds
- (COMPLETE) Game Feel:
	-Sound effects for the flaming turret
	-Walking into the balls makes a thumping sound
	-Dashing into balls creates a "Bang" effect

## Mitch Leff ##
- Level Theme: Box Maze
- (COMPLETE) Five unique physics actors:
	- Crates that can be pushed and jumped on
	- Ball-and-chain at the top floor that can be swung
	- Barrel at the top of the first ramp that can be rolled down the ramp.
	- Double doors that swing on a hinge
	- Sphere's that spin and knock the player away
- (COMPLETE) At least two compound objects:
	- Ball and chain on the roof
	- Double doors that swing
- (COMPLETE) Variable terrain:
	- Go up the ramps to get to different areas of the level. You can also jump on the boxes and other objects.
- (COMPLETE) At least three material sounds:
	- Footsteps when you walk around
	- Clanging sound when you hit the barrel
	- "Woosh" sound when you dash
- (COMPLETE) Game Feel:
	- When you interact with the tree on the roof, it has mesh-perfect colision. You can walk between gaps in the branches.
	- You can push smaller objects but not larger ones.
	- The ball and chain pivots naturally and bounces against the walls.
	- The sphere's knock the player back aggressively


##### Resources Used by Group ##### 
- Asset: Standard Assets by Unity Technologies
- URL: https://www.assetstore.unity3d.com/en/#!/content/32351
- Usage: The third person controller asset was used for our character controller.  The animations were used, and some elements of the scripting was used as a base for character movement.  Any scripts used were heavily modified to match our goal in character movement, so all scripts used are nothing like the original.

- Asset: FX Mega Pack 2 by Unluck Software
- URL: https://www.assetstore.unity3d.com/en/#!/content/14208
- Usage: Some particle systems were used to create effects for the robot that were used by every group member.


##### Resources Used by Rahmaan ##### 
- Asset: FX Mega Pack 2 by Unluck Software
- URL: https://www.assetstore.unity3d.com/en/#!/content/14208
- Usage: Other particle system were used to create extra effects in the scene.

- Asset: Tile Tool by Unluck Software
- URL: https://www.assetstore.unity3d.com/en/#!/content/19904
- Usage: The objects and tiles used in this asset were used to create the individual level.

##### Resources Used by William ##### 
- Asset: FX Mega Pack 2 by Unluck Software
- URL: https://www.assetstore.unity3d.com/en/#!/content/14208
- Usage: Effects were used to polish game.

- Asset: Skeleton - Animated and Low Polygon
- URL: https://www.assetstore.unity3d.com/en/#!/content/30659
- Usage: Used for decoration

- Environment Asset imported through Unity.

##### Resources Used by Larry ##### 
- Asset: Fire sound
- URL: http://opengameart.org/content/fire-loop
- Usage: Add fire sfx to the turret

- Asset: Metal ball
- URL: https://www.assetstore.unity3d.com/en/#!/content/446
- Usage: Add a ball to roll around

- Asset: Walkways, platforms, stairs
- URL: https://www.assetstore.unity3d.com/en/#!/content/4707
- Usage: Everything you can walk on

- Asset: Crate
- URL: https://www.assetstore.unity3d.com/en/#!/content/21965
- Usage: Box to push around

- Asset: Turrets
- URL: https://www.assetstore.unity3d.com/en/#!/content/27858
- Usage: Enemies to fight

##### Resources Used by Mitch ##### 
- Asset: Yughues Free Metal Materials
- URL: https://www.assetstore.unity3d.com/en/#!/content/12949
- Usage: Used to add texture variety

- Asset: Metal Crates Pack
- URL: https://www.assetstore.unity3d.com/en/#!/content/8836
- Usage: Used for crate assets as obstacles

##### Build Instructions ##### 
Use standard build settings for Web Player. Ensure all four scenes are included in build.

##### Grader Instructions #####
## Group Component ## 
- Controls:
	- Recommend input is a XBOX 360 Controller 
	- Walk/Run: WASD / Leftstick on Gamepad (Character will turn towards the direction of the keypress relative to the camera as he moves)
	- Jump: Spacebar / (Y) Gamepad Button
	- Dash: Left Shift / (B) Gamepad Button
	- Air Dash: Left Shift / (B) Gamepade Button WHILE IN AIR AND SMALL ONLY
	- Attack: Q / (X) Gamepad Button
	- Raise Shield: E / Left Bumper Gamepad Button
	- Shrink/Grow: Left Alt / Right Bumper Gamepad Button
	- Crouch: C / Leftstick click in (This is toggle button.  Character will remain crouched until button is pushed again)
	- Activate Ragdoll: K / Rightstick click in (This is a toggle button.  Chracter will remain a Ragdoll until button is pushed again)

- Viewing Group Requirements:
	- Interacting with rigid bodies in each respective scene will demonstrate the basic physics interactions of the character
	- Crouching and jumping will show collider animations, along with raising the shield
	- Activating ragdoll via button will demonstrate that Ragdoll is attached to the character and can be activated anytime via gameplay or scripting
	- Testing the above control scheme will demonstrate the Game Feel requirement

- Viewing Individual Requirements:
	- Lodhia Level
		- Switch to this level by pressing 1 on the keyboard or keypad
		- Start by walking around the initial area.  Walking over the different color floor will initate two of the three material sounds.  Walking over the gravel area should create dirt particles, which is part of the Game Feel requirement
		- Walk into the crates nearby to force them to move.  They move sluggishly and only a little with each push.  These are one of the five nodes
		- Move up the ramp and try to jump on top of the platform with the bombs.  This should force all the bombs to roll off the platform.  This is two of the five geometry nodes.  If there is trouble jumping, try shrinking to a smaller sized
		- From the ramp, try jumping to the hanging platform.  These platforms are hard to reach while large, so being small is recommended.  It is possible to jump from platform to platform, but their moving motion will make it difficult.  This is three of the five geometry nodes
		- From the hanging platforms, drop down to the area before the bridge and move towards the arch.  Try jumping or running into the chains.  The chains will move accordingly demonstrating the fourth of five nodes
		- Head towards the bridge, big or small.  While walking on the bridge, note the material sound playing matches the wood bridge.  This is third of the three material sounds
		- While on the bridge, become larged and jump in place at the middle of the bridge.  This should force the bridge to break and fall.  This is reactive environment for the Game Feel requirment and a fifth node
		- If you successfully broke the bridge or simply fell off the bridge, you will find yourself in the spike trap.  If you touched ths spike, you should become a ragdoll and a death particle system should play.  This is also a Game Feel effect.  If you are in this state, simple push K or Rightstick click and leave the spike trap area by jumping while small.  Should you fall again into the spikes, simply deactivate the ragdoll again
		- From there, go past the bridge to the final area.  Walk up the ramp and try to reach the chest while in large form.  The character should fall into a trap door with another spike trap.  Repeat the steps above to escape (deactivate ragdoll, shrink, and jump).  This is the sixth node and a reactive environment for Game Feel
		- At this point, you can mess around with other controls.  Try dashing across the area while small on the ground or in the air.  Being small has several benefits that can be seen from traversing areas.  However, its floaty nature will make it difficult to aim landings

	- Gu Level
		- Switch to this level by pressing 2 on the keyboard or keypad
		- You'll spawn at the safe area first and you can explore
		- There is a pond behind you for the variable height terrain, the splash effect and sound
		- Next to you will be the sign post which you can bump into and make it swing faster
		- On the other side will be swing where you can spin if you bump into it
		- There is a ball nearby you also to see the floating effect
		- When you enter the maze (the only exit) you'll have to move through the skeletons
		- A entry sound and particle effect will play once you enter maze
		- The wrecking ball is there too so you can bump into it to see the sound effect and the movement
		- Boxes will be in the way at the end of the entry of the maze so you have to move them
		
	- He Level
		- Switch to this level by pressing 4 on the keyboard or keypad.
		- Note the footstep sound when walking on the orange platform.
		- A flaming turret is to you left. You can push it if you want.
		- Walking to the turret on your right will kill you. Dash into the metal balls to make the balls hit the turret and push the turret away.
		- Jump down the hanging stairs. You can walk into the boxes.
		- Restart the level. Go the walkway connected to the two joined staircases. Note the louder footstep sound when walking on the walkway. Go to the two joined staircases. Note the thudding footstep sound. Jump on the staircases to see them swing about.

	- Leff Level
		- Switch to this level by pressing 4 on the keyboard or keypad
		- You can start on the bottom floor and can go up floors using the ramps
		- The spinning spheres will knock you away
		- Each floor has a different texture and a different sound for footsteps
		- At the top of the first ramp you can push the barrel around and down the ramp
		- You can continue along the path up the ramp to the roof
		- On the top floor there is a ball-and-chain, a sphere joined with a cylinder that you can move and swing around
		- There is also a tree that you can move between the branches of



##### Unity Scene #####
The main file used is lodhia_r_m2.unity.

##### URL ######
http://www.prism.gatech.edu/~rlodhia3/CS6457/Milestone2/Milestone2_Player
