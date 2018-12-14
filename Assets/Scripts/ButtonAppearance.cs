using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAppearance : MonoBehaviour {
	Button button;
	int index;
	void Start() {
		// get button component from game object
		button = GetComponent<Button>();
		ColorBlock cb = button.colors;

		// get button text component in children and set the text property
 		index = int.Parse(button.GetComponentInChildren<Text>().text);
		if(index == 11 || index == 13 || index == 14)
			button.interactable = false;
		else if(index > 15 && index < 19)
			button.interactable = false;
		else {
			if(index > LevelClear.levelClear.GetStageAt()) {
				button.interactable = false;
			}
			else if(index < LevelClear.levelClear.GetStageAt()) {
				cb.normalColor = Color.green;
				button.colors = cb;
				button.interactable = true;
			}
			
			else {
				cb.normalColor = Color.white;
				button.colors = cb;
				button.interactable = true;
			}
		}
	}
}
