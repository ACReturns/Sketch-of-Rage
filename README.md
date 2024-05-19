# Sketch of Rage
This was the Unity Live Project I created for the Tech Academy. It's a side scroller game that was inspired by Streets of Rage. 

This was created utilizing C# & Unity. This was a solo project in which I created the animations, background, enemy tracking, and transitions. There is also custom music which was made by a good friend who gave me the rights to utilize in the demo. I created everything artwise from scratch and ensured it moved as good as it could for the limited amount of time I had to create. Task and time management was very important in keeping pace to ensure that everything was on schedule and finished before moving on to the next part. Learning how to have the player move up and down in the playspace was a great challenge as it was not set in Unity out of the box to play that way so digging into figure that out as well as blending the animations properly. I definitely came out of the project very excited to dig into more content such as coroutines as I utilized them to a level that I could see you can go even further. 

Below are some of the key portions I setup and wanted to showcase:

1. [UI Elements](#UI)
2. [Animations](#Animations)
3. [Player Traversal](#Player)
4. [Enemy Behavior](#Enemy)
5. [Acquired Skills](#Experience)
6. [Portfolio](#Portfolio)


## UI
These are the UI aspects I created.
![Main Menu](https://github.com/ACReturns/Sketch-of-Rage/assets/18241737/b043ca02-1d2d-49e9-806d-46c9cd1455d4)

![Game Over](https://github.com/ACReturns/Sketch-of-Rage/assets/18241737/1af30edd-0149-40e9-95fc-fd5e5e612879)

![UI](https://github.com/ACReturns/Sketch-of-Rage/assets/18241737/35ff199d-954f-478e-b7ca-43a8e7bb0c72)

## Animations
<body>Here are some key animations put together to give the player the freedom to move and attack enemies
  
![Idle](https://github.com/ACReturns/Sketch-of-Rage/assets/18241737/b2a58e30-8f65-417c-9a7e-a70b14461992) ![Walking](https://github.com/ACReturns/Sketch-of-Rage/assets/18241737/f8f4400a-8571-4aa3-b614-9d528c3343ae) ![Punching](https://github.com/ACReturns/Sketch-of-Rage/assets/18241737/7c343c96-31f0-4bdd-ae34-421dfc645db0)

![RunStart](https://github.com/ACReturns/Sketch-of-Rage/assets/18241737/fc9d1e6f-7089-4518-bea3-bed5c63aa1da) ![Running](https://github.com/ACReturns/Sketch-of-Rage/assets/18241737/dc5c0504-c568-4ef0-8416-124a2014cbf1) ![RunStop](https://github.com/ACReturns/Sketch-of-Rage/assets/18241737/3776cad5-0ff1-4230-bfe6-cd5918595358)

![Death](https://github.com/ACReturns/Sketch-of-Rage/assets/18241737/0a348f85-d799-4d48-9008-6e621aaabefc) ![Enemy](https://github.com/ACReturns/Sketch-of-Rage/assets/18241737/19b12476-dc69-43ac-b5e7-8a9d5cacab91) 
</body>

## Player 
<body> 
Below is the code I utilized to move the player on the x and y axis to feel like old school beat'em ups.
  
![Player Traversal Code](<img/Player_Movement.png>)
</body>


## Enemy 
<body>
Below is what I utilized for the enemy to keep track of the player and chase them down to attack.
  
![Enemy Tracking Code](<img/Enemy_Movement.png>)
</body>

## Experience
<body>
  One of the big take aways from working in Unity was how effecient it was to have so many features broken down into their own files for ease of readability and debugging. It really made creating features really quick and small in terms of code to review. Another take away which I didn't get to fully impliment in this project but did come to the realization at the end was how creating a Game Manager class would have made things like controlling how the audio transitions for some levels while not restarting on other levels when it shouldn't. Coroutine's were probably my favorite feature in Unity, being similar to an asyncronous method I definiltey only scratched the surface with them really only being utilized as a yield for enemy spawners. Digging deeper, I found more features that I am really excited to use in future projects.    
</body>

## Portfolio
<body>
  To view my portfolio: 
  <a href="https://acreturns.github.io/Portfolio/#Home">Portfolio</a><br>
  Try out the game: 
  <a href="https://acreturns.github.io/Portfolio/projects/sor/sor.html">Sketch of Rage</a><br>
</body>
