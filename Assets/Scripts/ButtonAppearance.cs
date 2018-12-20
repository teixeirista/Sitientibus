using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAppearance : MonoBehaviour {
	Button button; //Componente botão
	int index; //Índice da cena ativa
	void Awake() {
		//Recebe o componente botão do objeto
		button = GetComponent<Button>();
		//Recebe as cores do botão
		ColorBlock cb = button.colors;
		//Recebe o índice da cena através do texto do botão
 		index = int.Parse(button.GetComponentInChildren<Text>().text);

		//Verifica se o botão é de um enigma bloqueado. Se for, desabilita o botão.
		if(index > LevelClear.levelClear.GetStageAt()) {
			button.interactable = false;
		}
		//Verifica se o botão é de um enigma já desbloqueado. Se for, habilita o botão e configura a cor verde
		else if(index < LevelClear.levelClear.GetStageAt()) {
			cb.normalColor = Color.green;
			button.colors = cb;
			button.interactable = true;
		}
		//Se não, habilita o botão e configura a cor branca
		else {
			cb.normalColor = Color.white;
			button.colors = cb;
			button.interactable = true;
		}
	}
}
