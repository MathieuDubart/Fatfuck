# Fat Fuck 

A dropdown game where you need to ctach fruits in order to keep the timer alive and increase your score.

## Fonctionnement

### PlayerMovements

Player is built like this:  
```
FatFuck  
...|_ Body  
.......|_ FatFuck Model
```
Attach 'PlayerMovements' script to FatFuck. Then apply Body in "Player" in parameters and change horizontalSpeed (default is 5). Your player should then be allowed to move sideways with "Q/D" or Left/Right arrows.