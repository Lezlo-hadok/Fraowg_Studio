# Flash_Studio
## Team Members
1. Eli as Designer
2. Matthew as Coder
3. Ben as Developer and Author
4. Xavier as Reviewer and Coder 

## Branching Naming Conventions

### Feature Branch
Format: - `feature/{feature-name}`<br>
Example: - `feature/user-authentication`<br>
### Bugfix Branches
Format: - `bugfix/{bug-description}`<br>
Example: - `bugfix/fix-login-error`<br>
### Release Branches
Format: - `release/{version-number}`<br>
Example: - `release/v1.2.0`<br>

## Commit names 
Every github commit should start with one of the following words:
- `modification`: when a new code is added or removed. Designate the file and the purpose of the modification. 
- `fix`: when a specific bug is fixed. 
- `file change`: if files are added or removed. 
- `refactor`: improved code without changing its behaviour
- `ui`: Add or modify UI Elements
## Features
 ### Menu and Options Menu
- [ ] The game will feature a main menu allowing players to start a new game, load a saved game, or exit.
- [ ]	The options menu will enable players to adjust sound settings, graphic preferences, and gameplay settings.
### Saving and Loading Options
- [ ]	The game will allow players to save their menu preferences, such as sound settings, graphic settings, and key bindings.
- [ ]	These settings will persist across sessions, ensuring that the player’s preferred configurations are automatically loaded when the game starts.
- [ ]	The system will store these preferences in a file format, enabling easy retrieval and modification.
### Player Movement
- [ ]	The player can move freely within the game world using keyboard inputs (WASD or arrow keys).
- [ ]	The Player can change speeds between crouch and sprint.
- [ ]	Movement is smooth and responsive, with a simple collision detection system to prevent the player from passing through objects.
### Camera Control
- [ ]	The camera will follow the player, providing a dynamic perspective of the game world.
- [ ]	The camera's position and rotation will adjust smoothly as the player moves, ensuring a clear and focused view of the action.
- [ ]	The player can optionally adjust the camera angle and zoom in/out using the mouse.
### Dialogue System
- [ ]	Players can read through text-based responses and make choices that affect the conversation.
- [ ]	Dialogue options will trigger different responses or actions based on player decisions.
### Interaction
- [ ]	The player can interact with NPCs, objects, and environments through simple prompts.
- [ ]	Interactions will trigger actions such as opening doors, picking up items, or starting dialogues.
- [ ]	The interaction system will be simple and context-sensitive, adapting to the object or NPC being interacted with.
### Stats and Leveling
- [ ]	The player will have stats such as health, experience points (XP), and level, which improve as they progress.
- [ ]	The leveling system will improve stats as the player advances.
### Saving and Loading Stats
- [ ]	Player stats will be saved during the game save process.
- [ ]	Stats will be stored in a file for easy management and retrieval when loading the game.
- [ ]	Any changes to the player’s stats (such as leveling up) will be automatically saved.
- [ ]	The player’s position, rotation, and other transform-related data will be saved when the game is saved.
- [ ]	When the game is loaded, the player will return to their exact last location and state, preserving the continuity of gameplay.
### Respawn
- [ ]	When the player’s character dies, they will respawn at a predefined location, such as a checkpoint or starting area.
- [ ]	Respawn will restore the player's health to a default value.
- [ ]	The respawn system will include a short delay before the player is returned to the game world to avoid instant re-engagement after death.
- [ ]	The game will provide a visual or audio cue to indicate the respawn event, ensuring the player is aware of their return to the game.
- [ ]	Player stats, including experience points and level, will remain intact upon respawn, maintaining the player’s progression despite death.

## Work Allocation

| Feature                    | Priority | Team Member   | Order | Order Reason                                                                                      |
|----------------------------|----------|---------------|-------|---------------------------------------------------------------------------------------------------|
| Main Menu and Options Menu | Urgent   | Ben           |   3   | Develop UI for settings as keybinds will be needed for player                                     |
| Saving and Loading Options | Low      | Ben           |   8   | Save and Load Keybinds and Mouse Invert option for the Player and Camera                          |
| Player Movement            | Urgent   | Xavier/Mathew |   1   | Stats and Options will dictate functionality                                                      |
| Camera Control             | High     | Eli/Xavier    |   2   | Options will dictate functionality                                                                |
| Dialogue System            | Low      | Eli           |   9   | To open the dialogue to test player and camera should allow movements, Interact is needed to open |
| Interface and Interaction  | High     | Xavier/Eli    |   5   | Needs Keybinds for interaction key, Needs camera for aiming                                       |
| Stats and leveling         | Low      | Matthew       |   6   | Needed to be able to save stats, movement will pull stats for impact stamina                      |
| Saving and Loading Stats   | High     | Matthew       |   7   | Saving and loading will require stats and the players movements to exist for saving and loading   |
| Respawn                    | High     | Ben           |   4   | Respawn will require reloading stats and check point location from save file                      |

Task 2;
 key tasks
 - Function name
   - purpose
   - branch naming convention Naming
   - 
# 1. Eli 
- Dialogue System
  - Players can read text based responses and that make choices that effect the conversation. Dialogue responses will change the actions and responses of the conversation.
  - 
-
- Interaction
  - The player can interact with simple NPC's, Objects & Environments through simple prompts (such as Q). Interactions will include things like opening doors, starting dialogue & picking up items.
  - 
- Camera Controls
  - Camera will follow the player showing dynamic perspective of the game world. The camera's position & roation will adjust smoothly as the player moves winthin their world (3rd person camnera)
  - player can zoom in and out (between 3rd and 1st person)
  - 
# 2. Matthew
- Player Movement
  - The player can move freely within the world using WASD input from the keyboard controls input. The player must be able to control speed, crouch & sprint.
  - 
- Stats & Leveling
  - The player will have stats such as XP, Level & Health to show their progression throughout the game. The player will improve stats as the player advances.
  - 
- Saving & Loading Stats
  - Players stats will be saved during the game save menu options. Stats are stored within a file for easy management and retriveal when loading the game. Any changes to the players stats (such as levels) will need to be updated automatically.
  - 
# 3. Ben

- Saving & Loading Options
  - The game will allow player to save their menu preferences such as sound, graphics & key binds.
  - 
- Menu & Options Menu
  - The Game must have a Main Menu that has the options; new game, load game, save game & Exit. The Options menu will enable you to adjust sound settings, graphics & gameplay setttings.
  - Menu_OptionsMenu
- Respawn
  - Player will need to have there X, Y positions reset on the player world.
  -
# 4. Xavier
- charater movement
  - The player can move freely within the world using WASD input from the keyboard controls input. The player must be able to control speed, crouch & sprint.
  - 
- camera controler
  - Camera will follow the player the dynamic perspective of the game world. The camera's position & roation will adjust smoothly as the player moves winthin their world (3rd person camnera)
  - player can zoom in and out (between 3rd and 1st person)
  - 
- interactions
  - The player can interact with simple NPC's, Objects & Environments through simple prompts (such as Q). Interactions will include things like opening doors, starting dialouge & picking up items.
  - 
