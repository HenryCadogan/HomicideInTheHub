﻿using UnityEngine;
using System.Collections;

abstract public class Character {
	//Abstract class used to define the variables and methods used by PlayerCharacter and NonPlayerCharacter

	//__Variables__
	private string characterID; //Holds The characters name (used for reference and comparisons)
	private Sprite sprite; 		//Holds the image of the character
	private string nickname;	//Assigns a nickname to the character.
	public bool canBeQuestioned = true;

	//__Constructor__
	protected Character(string characterID, Sprite sprite, string nickname) {
		this.characterID = characterID;
		this.sprite = sprite;
		this.nickname = nickname;
	}

	//Accessors 
	public string getCharacterID(){
		return this.characterID;
	}

	public Sprite getSprite(){
		return this.sprite;
	}

	public string getNickname(){
		return this.nickname;
	}

	public bool CanBeQuestionned(){			//ADDITION BY WEDUNNIT
		return this.canBeQuestioned;
	}

	public void BlockCharacterQuestioning(){			//ADDITION BY WEDUNNIT
		this.canBeQuestioned = false;
	}

	public void AllowCharacterQuestioning(){			//ADDITION BY WEDUNNIT
		this.canBeQuestioned = true;
		Debug.Log (canBeQuestioned);
	}
}
