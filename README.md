# 3DCollectionGame

Campfire Bunny Game

Credits:
 Dialogue System for Unity
Code Snippets:
 https://gist.github.com/ftvs/5822103
https://docs.unity3d.com/ScriptReference/RenderSettings-fog.html

Goal:
To create a fun little group of missions that are interesting to go through and to make them as intuitive as I can while maintaining some sort of player captivation

Setting: 
You are a young bunny, new to the cult, but eager to prove yourself for the ritual to come. You must help Gregor prepare the bonfire for the Ritual that will summon the Great Old Bun. 

NPCs:
Gregor: The leader. Gregor the Great is his full name. He is called the great because he is the Blue Bunny that the ice cream was named after and he thinks that’s pretty great.
Tiffany: Young and bubbly bunny. Probably younger than you, but she’s been a part of the cult longer
Frank: He talks tough, but he just wants to help out.
Bertha: The oldest bunny. She is helpful and has a habit of calling everyone hun. (short for honey bunny of course)
Currency:
I will not be implementing a currency system. The reward for your quests will be setting up the ritual and getting to see it in action and also the gratitude of your fellow bunnies
Controls: Walk (arrow keys), jump (spacebar), interact (e)
Interactables:
1.	Other bunnies (talk)
2.	Trees(chop wood)
3.	Campfire spot(build fire)

Quest 1) Collect wood – Chop down trees to collect wood (need 10 wood)
This quest is the introduction to interaction and shows how the player can interact with the world and other NPCs. It also establishes a tone for the game. It should be very easy to accomplish.

•	Trees will give the option to be cut down if the player gets within proximity
•	Cutting down a tree will yield 1 wood
o	Interact button to cut tree
•	Cut down 10 trees to fulfill the quest

Quest2) Build fire-Find a place to build a fire and use your wood to start a fire
•	Find the area clearly meant to start a fire at (ring of stones)
•	Press interact button to place wood and build the fire
o	Fire will be a particle system

Quest3) Collect bunnies to sit-Find each bunny and have them sit by the fire
•	Find each bunny and let them know that there is a fire and that they must sit
•	They will go to the spot on their own


End of the game: Campfire Ritual

There is an end cutscene that shows the summoning of the Great Old One where he proceeds to destroy the world. For this, I wanted to move the camera, but I only got as far as switching angles statically.
