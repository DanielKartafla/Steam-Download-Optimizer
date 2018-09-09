# Steam Download Optimizer
Checks each game for online functionality and edits the Steam game properties accordingly to (not) allow background game updates during gameplay.

## Why this program was written
The Steam client has two settings for game updates during gameplay: Allow or do not allow. (Steam -> Settings -> Downloads -> Allow downloads during gameplay)

However, many people would like their games to update even during gameplay if they are not playing online. Unfortunately Steam has no support for such a setting. The only thing that can be done, is to change the settings for each individual game (Game properties -> Updates -> Background downloads).

Since many Steam users have a lot of games, editing the properties of every game in their library can be a very tedious task. The Steam Download Optimizer can help you with this problem. It reads the features of every game on your PC from the Steam store page and edits each game's properties automatically according to your wishes. Want games with online functionality to never allow background updates during gameplay? No problem. Want pure offline games to always allow background updates of other games during gameplay? Also no problem.

## Development status
The first draft of the UI is finished. Currently working on the data classes for the games.

## How to use
Currently no usage guide available, since there is no use in using the program yet.

### Limitations
While the program can read the features of every Steam game, it cannot detect if you play a game with online functionalities actually online. 

For example Europa Universalis IV has online functionalities, but most people play it almost exclusively offline. The program does not know such things and will regard the game as online game. However, you can edit each game's properties individually anyways, which you should do for your most played games.
