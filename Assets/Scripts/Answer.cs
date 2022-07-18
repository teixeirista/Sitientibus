using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Answer : MonoBehaviour {

	int index;
	InputField iField;
	string answer;
	public Text wrong;
	public Text almost;
	public Transform iFieldTrans;

	void Awake(){
		wrong.enabled = false;
		almost.enabled = false;
	}

	void Start(){
		iField = GetComponent<InputField>();
		index = SceneManager.GetActiveScene().buildIndex;
	}

	private void Almost() {
		wrong.enabled = false;
		almost.enabled = true;
	}

	private void Wrong() {
		almost.enabled = false;
		wrong.text = "Resposta incorreta";
		wrong.enabled = true;
	}

	private void Correct(int scene) {
		if(index > 0 && index < 17)
			LevelClear.levelClear.UnlockStage(scene);

		if(scene <= LevelClear.levelClear.GetStageAt())
            SceneManager.LoadScene(scene);
        else
            return;
	}

	public void SetPosition() {
		iFieldTrans.position = new Vector2(360,600);
	}
     
    public void VerifyAnswer()
    {
		answer = iField.text.ToLower();
		wrong.enabled = false;

		if(answer == "") {
			almost.enabled = false;
			wrong.enabled = false;
			return;
		}


		switch (index)
		{
			case 1:
				if(answer.Contains("feira de santana")) {
					Correct(2);
				}
				else if(answer.Contains("feira") || answer.Contains("santana")) {
					almost.text = "O nome completo é bonito, não acha?";
					Almost();
				} else {
					Wrong();
				}
				break;

			case 2:
				if(answer.Contains("lugar") && answer.Contains("trem") && answer.Contains("tomba")) {
					Correct(3);
				}
				else if(answer.Contains("caixa")) {
					almost.text = "Icônica, não é? Mas a resposta está no nome";
					Almost();
				}
				else if(answer.Contains("tomba") && answer.Contains("trem")) {
					almost.text = "Resposta incompleta";
					Almost();
				}
				else if(answer.Contains("tomba")) {
					almost.text = "Procure o motivo desse nome";
					Almost();
				}
				else {
					Wrong();
				}
				break;

			case 3:
				if(answer.Contains("cidade nova") && answer.Contains("jomafa")) {
					Correct(11);
				}
				else if(answer.Contains("cidade nova") || answer.Contains("jomafa")) {
					almost.text = "Falta um";
					Almost();
				}
				else {
					Wrong();
				}
				break;


			case 4:
				if(answer.Contains("rio subaé")) {
					Correct(5);
				}
				else if(answer.Contains("subaé")) {
					almost.text = "O rio ou a lagoa?";
					Almost();
				} else {
					Wrong();
				}
				break;

			case 5:
				if(answer.Contains("ruy barbosa")) {
					Correct(6);
				}
				else if(answer.Contains("ruy") || answer.Contains("barbosa")) {
					almost.text = "Resposta incompleta";
					Almost();
				} 
				else if(answer.Contains("princesa") || answer.Contains("sertão")) {
					almost.text = "Preste atenção ao título";
					Almost();
				}
				else {
					Wrong();
				}
				break;

			case 6:
				if(answer.Contains("pindoba") && answer.Contains("tábua") && answer.Contains("prato raso") && answer.Contains("grande") && answer.Contains("salgada") && answer.Contains("geladinho") && answer.Contains("subaé") && answer.Contains("chico maia") && answer.Contains("berreca")) {
					Correct(9);
				}
				else if(answer.Contains("lagoa")) {
					almost.text = "Seja um tanto mais descritivo";
					Almost();
				}
				else if(answer.Contains("pindoba") || answer.Contains("tábua") || answer.Contains("prato raso") || answer.Contains("grande") || answer.Contains("salgada") || answer.Contains("geladinho") || answer.Contains("subaé") || answer.Contains("chico maia") || answer.Contains("berreca")) {
					almost.text = "Tem coisa faltando aí";
					Almost();
				} else {
					Wrong();
				}
				break;

			case 7:
				if(answer.Contains("cá") && answer.Contains("te") && answer.Contains("espera")) {
					Correct(13);
				}
				else if(answer.Contains("bicho do tomba")) {
					almost.text = "Está no caminho certo, mas tem outras dicas aí";
					Almost();
				}
				else if(answer.Contains("bicho") && answer.Contains("aparecendo") && answer.Contains("feira")) {
					almost.text = "Na última página";
					Almost();
				} else {
					Wrong();
				}
				break;

			case 8:
				if(answer.Contains("festa") && answer.Contains("senhora") && answer.Contains("santana")) {
					Correct(14);
				}
				else if(answer.Contains("bando anunciador")){
					almost.text = "Não ia ser tão fácil assim, né? Falta simbolismo";
					Almost();
				} 
				else if(answer.Contains("festa") || answer.Contains("santana")) {
					almost.text = "Resposta incompleta";
					Almost();
				} else {
					Wrong();
				}
				break;

			case 9:
				if(answer.Contains("praça do nordestino")) {
					Correct(16);
				}
				else if(answer.Contains("gameleira") || answer.Contains("dom pedro ii")) {
					almost.text = "Utilize o senso comum";
					Almost();
				} else {
					Wrong();
				}
				break;

			default:
				break;
		}
	}
}