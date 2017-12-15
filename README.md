# Run Stickman Run

Run Stickman Run is a game in which the player doesn't take the control of a character but become a part of the game with the help of the kinect.

In this game, Stickman is a student that didn't get a 20 to his 3DETech's project which result to him failing his studies and being kicked out of his school. 

Rejected by all, Stickman lost everything and became desperate to the point where his mind completly broke and made him lost all perspective to what is real and what is not.

Stickman is now completly paranoiac. He is stuck in his mind where everyone and everything is against him and try to hirt him. So he runs. He runs for his life without stopping. Without paying attention to the things on his path. The only way for him to get out of his internal jail, is to go through.

This is where the player come to use. The objective of the player is to help Stickman to go through his ennemies by modintfying his environment.

The Kinect will allow some control on Stickman's world that the player will use to clear or change Stickman's path and protect him to allow him to come back to the real world.


## Requirements

In order to use this project, you will need a couple of things.

First of all, you will need to install Unity on your computer. The version that was used to make the project and test it was the version 5 - 2017.2.0f3. You can download a version of unity [HERE](https://unity3d.com/fr/get-unity/download)

Then, if you want to use the kinect to play the game, you will need to install the microsoft SDK v1.8. The game was made to work with the version 1 of the kinect. It will not work with the version 2 of the kinect.

## Install / Configuration

To get the project on your computer, you need to open a prompt, go to the folder you want to install the project, and type the following command:

```
git clone https://github.com/gbaelen/RunStickmanRun.git
```

Once the repository is cloned on your computer, you need to open unity and choose *open a project*. 

Then you will need to select the folder where you cloned the project.

Unity will then open the project and to run it you will have to go to 

```	
File -> click on **Build settings**
```
In *scene to build* add the scenes **Menu** and **Blocs-Assembly**, select your operating system and then click on **build and run**. 
 
The game will then launch.


## How to play to the game

### The controls

When you will start the game you will start with Stickman running. As you enter the game, the kinect will detect the person that is the closest and choose him as the player. To be able to play correctly, be sure to have a clear space around the player.

When it is done the player will have his the control of with his two hands:
* the right Hand will give two functionnalities:
	* the control of the mouse cursor : the mouse cursor will follow your right hand allowing you to interact with certain elements of the game.
	* the grip of the tools : two tools will be made available to the player, a hammer and a shield, the player will have the possibility, when the cursor will be on one on the tools icon, to take it by gripping it with his right hand. The mouse cursor will take the form of the tools and will then have the tool's properties.
* the left hand will push the Stickman (or make him jump) by swiping to the right.

When you want to play with the keyboard, you will only have to use the mouse instead of your right hand and the left click of the mouse to grip the tools. The space bar will be used instead of the left hand in order to push the Stickman.

### The interface

To give information to the player, there are icons on top of the screen. 

The hearts on the left are the remaining life of the player. The Stickman can be only touch 3 times by his ennemies, otherwise the game is other and the player need to start from the beginning.

In the middle you have the tools. There are two tools that the player can use to help the stickman:
* the hammer: This tool is used to break the blocks that are breakable.
* the shield: This tool is used to protect the Stickman from the projectiles that are falling upon him.   

### The game's elements
#### The ennemies

The Stickman has four type of ennemies that can hirt him:
* The moving one : some ennemies are wandering in the world of Stickman, touching them might be painful.
* The falling spikes : some spikes are set higher than the Stickman waiting to fall on him.
* The cannon : some ennemies can throw projectiles toward the Stickman.
* The fall : be aware of void below, Stickman can't fly.

#### The Blocks

The player can interact with two types of blocks:
* The block that can be destroyed: Those blocks can be destroyed if you manage to put the hammer on them.
* The moving blocks : Those blocks can be moved. If the player put the mouse cursor on them, those blocks will follow it as long as the player moves it on the block's axe. There is two types of moving blocks:
	* The blocks that moves on a limited axe. The player won't be able to get the block further than his axe.
	* The blocks that moves without limitation. The player can get the block outside of its axe, but be careful, the block doesn't fall as long as it is on its axe. 



Please see this video presentation:

[![Run Stickman Run](https://i.ytimg.com/vi/diUWLN393ls/hqdefault.jpg?sqp=-oaymwEWCKgBEF5IWvKriqkDCQgBFQAAiEIYAQ==\u0026rs=AOn4CLAYp52pGNrKNSK0nEow0tk2w5pl7g)](https://youtu.be/L29EW9zDuuI)

## Authors

* **Lisa Kaprielian** - *Initial work*

* **Anthony Gueguen** - *Initial work*

* **Guillaume Baelen** - *Initial work* - [gbaelen](https://github.com/gbaelen)


