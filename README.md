# Sketch-of-Rage
This was the Unity Live Project I developed for the Tech Academy. It's a side-scrolling game inspired by Streets of Rage.

I created this solo project using C# and Unity, where I designed the animations, backgrounds, enemy tracking, and transitions. A talented friend provided custom music, granting me the rights to use it in the demo. I crafted all the artwork from scratch, ensuring smooth movement within the constraints of my timeline. Effective task and time management were crucial in maintaining progress and completing each phase before advancing to the next.

One of the significant challenges was enabling the player to move vertically in the play space, as this functionality wasn't built into Unity by default. I had to dig deep to figure that out while also ensuring proper animation blending. Overall, I emerged from the project eager to explore more advanced concepts, such as coroutines, which I utilized at a level that showed me the potential for even greater applications.


Here are some of the essential sections I organized and would like to highlight:

1. [UI Elements](#UI)
2. [Animations](#Animations)
3. [Player Traversal](#Player)
4. [Enemy Behavior](#Enemy)
5. [Acquired Skills](#Experience)

## UI <a name="UI Elements">
<body>
Here are several UI elements designed to help players transition from the Main Menu to gameplay, as well as to enable them to retry as often as they wish in case of game overs, along with tracking player health and score.
![Main Menu](<img/Main_Menu.png>)
![Game Over](<img/Game_Over.png>)
![Player HUD Full Health](<img/Player_HUD.png>)
![Player HUD Damaged](<img/Player_HUD_Loss.png>)
</body>

## Animations <a name="Animations">
<body>
Here are some essential animations designed to provide players with the freedom to navigate and engage enemies effectively.
![Idle](<img/Idle.gif>)
![Walk](<img/Walk.gif>)
![Running](<img/Running.gif>)
![Punch](<img/Punch.gif>)
![Death](<img/Death.gif>)
![Enemy](<img/Enemy.gif>)
</body>

## Player <a name="Player Traversal">
<body> 
Here is the code I used to navigate the player along the x and y axis, creating a nostalgic feel reminiscent of classic beat'em up games.
![Player Traversal Code](<img/Player_Movement.png>)
</body>


## Enemy <a name="Enemy Behavior">
<body>
Here is the method I employed for the enemy to monitor the player and pursue them for an attack.
![Enemy Traversal Code](<img/Enemy_Movement.png>)
</body>

## Experience <a name="Aquired Skills">
<body>
Throughout the journey of developing this project, I discovered how to seamlessly connect various animations to respond to a simple button press, as well as how to initiate other animations based on interactions with both players and enemies. The coroutines have proven to be incredibly powerful tools, and I am currently exploring their potential in another project to see how far I can push their capabilities. Although I only had two weeks to assemble this project, I feel quite accomplished with what I learned, especially considering that everything was created from scratch. The UnityEngine library is filled with tools I wasn’t previously aware of, and this project barely scratched the surface of its capabilities. Storing floats, calculating velocity, and managing distances are just a small portion of what I was able to grasp, and I am excited about all the additional possibilities that await me as I continue to work with the engine.
</body>