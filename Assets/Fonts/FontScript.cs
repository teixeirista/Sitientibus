using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FontScript : MonoBehaviour {

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
		//wrong.SetActive(false);
		wrong.enabled = false;
		//almost.SetActive(true);
		almost.enabled = true;
	}

	private void Wrong() {
		//almost.SetActive(false);
		almost.enabled = false;
		//wrong.SetActive(true);
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
		//wrong.SetActive(false);
		wrong.enabled = false;

		if(answer == "") {
			//almost.SetActive(false);
			almost.enabled = false;
			//wrong.SetActive(false);
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
					almost.text = "Resposta incompleta";
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
					almost.text = "Icônica, não é? Mas não é essa a resposta";
					Almost();
				}
				else if(answer.Contains("tomba") && answer.Contains("trem")) {
					almost.text = "Resposta incompleta";
					Almost();
				}
				else if(answer.Contains("tomba")) {
					almost.text = "Procure o motivo";
					Almost();
				}
				else {
					Wrong();
				}
				break;

			case 3:
				if(answer.Contains("domingos") && answer.Contains("ana")) {
					Correct(4);
				}
				else if(answer.Contains("domingos") || answer.Contains("ana")) {
					almost.text = "Resposta incompleta";
					Almost();
				} else {
					Wrong();
				}
				break;

			case 4:
				if(answer.Contains("rio subaé")) {
					Correct(5);
				}
				else if(answer.Contains("subaé")) {
					almost.text = "Qual?";
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
				} else {
					Wrong();
				}
				break;

			case 6:
				if(answer.Contains("atormentado")) {
					Correct(7);
				} else if(answer.Contains("insano") || answer.Contains("assombrado")) {
					almost.text = "malak";
					Almost();
				} else if(answer.Contains("cidadão dissidente") || answer.Contains("dissidente")) {
					almost.text = "Está no caminho certo";
					Almost();
				} else {
					Wrong();
				}
				break;

			case 7:
				if(answer.Contains("todo poder aos feirenses")) {
					Correct(8);
				}
				else if(answer.Contains("sede")) {
					almost.text = "Preste mais atenção no título";
					Almost();
				}
				else if(answer.Contains("poder") || answer.Contains("feirenses")) {
					almost.text = "Resposta incompleta";
					Almost();
				} else {
					Wrong();
				}
				break;

			case 8:
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

			case 9:
				if(answer.Contains("ponte rio branco")) {
					Correct(10);
				}
				else if(answer.Contains("lajedinho")) {
					almost.text = "Está no caminho certo";
					Almost();
				}
				else if(answer.Contains("rio") || answer.Contains("branco")) {
					almost.text = "Resposta incompleta";
					Almost();
				} else {
					Wrong();
				}
				break;

			case 10:
				if(answer.Contains("cidade nova") && answer.Contains("jomafa") && answer.Contains("viveiros")) {
					Correct(11);
				}
				else if(answer.Contains("cidade nova") && answer.Contains("jomafa")) {
					almost.text = "Falta um";
					Almost();
				}
				else if(answer.Contains("cidade nova") || answer.Contains("jomafa") || answer.Contains("viveiros")) {
					almost.text = "Resposta incompleta";
					Almost();
				} else {
					Wrong();
				}
				break;

			case 11:
				if(answer.Contains("um soldado brasileiro")) {
					Correct(12);
				}
				else if(answer.Contains("gravatá") || answer.Contains("jenipapinho") || answer.Contains("berreca")) {
					almost.text = "Não é o local";
					Almost();
				}
				else if(answer.Contains("bicho-preguiça")) {
					almost.text = "Bizarro, né?";
					Almost();
				}
				else if(answer.Contains("alberto romero") || answer.Contains("beto lima") || answer.Contains("amigo")) {
					almost.text = "Não é esse";
					Almost();
				}
				else {
					Wrong();
				}
				break;

			case 12:
				if(answer.Contains("1009")) {
					Correct(13);
				}
				else if(answer.Contains("bicho do tomba")) {
					almost.text = "Está no caminho certo";
					Almost();
				} else {
					Wrong();
				}
				break;

			case 13:
				if(answer.Contains("festa") && answer.Contains("de") && answer.Contains("santana")) {
					Correct(14);
				}
				else if(answer.Contains("bando anunciador")){
					almost.text = "Não ia ser tão fácil assim";
					Almost();
				} 
				else if(answer.Contains("festa") || answer.Contains("santana")) {
					almost.text = "Resposta incompleta";
					Almost();
				} else {
					Wrong();
				}
				break;

			case 14:
				if(answer.Contains("quarto 201")) {
					Correct(15);
				}
				else if(answer.Contains("samburá")) {
					almost.text = "Algo desse hotel";
					Almost();
				}
				else if(answer.Contains("pareja")) {
					almost.text = "Ele mesmo";
					Almost();
				}
				else {
					Wrong();
				}
				break;

			case 15:
				if(answer.Contains("praça do nordestino")) {
					Correct(16);
				}
				else if(answer.Contains("gameleira") || answer.Contains("dom pedro ii")) {
					almost.text = "Senso comum";
					Almost();
				} else {
					Wrong();
				}
				break;

			/*case 16:
				if(answer.Contains("correto")) {
					Correct(17);
				}
				else if(answer.Contains("quase")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 17:
				if(answer.Contains("correto")) {
					Correct(18);
				}
				else if(answer.Contains("quase")) {
					Almost();
				} else {
					Wrong();
				}
				break;
			
			case 18:
				if(answer.Contains("correto")) {
					Correct(19);
				}
				else if(answer.Contains("quase")) {
					Almost();
				} else {
					Wrong();
				}
				break; */

			case 16:
				if(answer.Contains("todos os caminhos levam a feira de santana")) {
					SceneManager.LoadScene(17);
				}
				else if(answer.Contains("caminhos")) {
					almost.text = "A frase inteira é bem bonita";
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