﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueManager : MonoBehaviour {

	public GameObject dBox;
	public Text dText;

	public bool dialogueActive;

	public string[] dialogueLines;

	public int currentLine;

	private PlayerController thePlayer;

	// Use this for initialization
	void Start () {

		thePlayer = FindObjectOfType<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (dialogueActive && Input.GetKeyUp(KeyCode.Space)) 
		{
			currentLine++;
		}

		if (currentLine >= dialogueLines.Length) {
			dBox.SetActive (false);
			dialogueActive = false;

			currentLine = 0;

			thePlayer.canMove = true;
		}

		dText.text = dialogueLines [currentLine];
	}

	public void ShowBox(string dialogue)
	{
		dialogueActive = true;
		dBox.SetActive (true);
		dText.text = dialogue;
	}
	public void showDialogue(){
		dialogueActive = true;
		dBox.SetActive (true);
		thePlayer.canMove = false;
	}
}
