[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Objects
- Seeds Planted UI
- Seeds Remaining UI
- Player
- Plants

Attributes & Actions
- Text
- Bunny Sprite
= Plant Sprite
- Movement
  - WASD
- Planting plants
  - Press space

Affect
- Count goes down and up
- IF player who has remaining seeds, place a single seed in players location + increase plants planted 


## Devlog
The breakdown I had before was less in depth compared to what Prof Reid had as I didn't mention what keys you would have to use or include the sprites being an attribute. With the breakdown I wrote, it was a list of what to do. First was working in Unity's Window, where you had to connect the components such as scripts to the GameObjects like the Player and UI. This step included making the Plant sprite into a Prefab as well. Now, working on the code, I work in the Update Method in the Player class, where the action of movement through the WASD keys. Next, the Plant Seed method was instantiated and was used to make a copy of the Plant Prefab + transform to place at the player's location. The UI was worked on in class PlantCountUI where the GameObject Text (TMP) was assigned and whenever there is a change, one of the values changes, it will be updated in Player due to it being called there.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for clearly describing the connection between your break-down and the code you wrote. :)

Thank you also for formatting your break-down well. You can also remove the prompt text- this all makes it much easier for the grading team to read.
