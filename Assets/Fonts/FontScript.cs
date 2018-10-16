using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FontScript : MonoBehaviour {

	InputField iField;
	string answer;
	public GameObject wrong;
	public GameObject almost;

	void Start(){
		iField = GetComponent<InputField>();
	}
     
    public void VerifyAnswer()
    {
		answer = iField.text.ToLower();
		wrong.SetActive(false);

		if(answer.Contains("feira de santana")) {
			SceneManager.LoadScene(2);
		}
		else if(answer.Contains("trem") && answer.Contains("tomba")) {
			SceneManager.LoadScene(3);
		}
		else if(answer.Contains("domingos") && answer.Contains("ana")) {
			SceneManager.LoadScene(4);
		}
		else if(answer.Contains("rio subaé")) {
			SceneManager.LoadScene(5);
		}
		else if(answer.Contains("ruy barbosa")) {
			SceneManager.LoadScene(6);
		}
		else if(answer.Contains("atormentado")) {
			SceneManager.LoadScene(7);
		}
		else if(answer.Contains("aos que tem sede")) {
			SceneManager.LoadScene(8);
		}
		else if(answer.Contains("pindoba") && answer.Contains("tábua") && answer.Contains("prato raso") && answer.Contains("grande") && answer.Contains("salgada") && answer.Contains("geladinho") && answer.Contains("subaé") && answer.Contains("chico maia") && answer.Contains("berreca")) {
			SceneManager.LoadScene(9);
		}
		else if(answer.Contains("ponte rio branco")) {
			SceneManager.LoadScene(10);
		}
		else if(answer.Contains("cidade nova") && answer.Contains("jomafa") && answer.Contains("viveiros")) {
			SceneManager.LoadScene(11);
		}
		else if(answer.Contains("")) {
			SceneManager.LoadScene(12);
		}
		else if(answer.Contains("1009")) {
			SceneManager.LoadScene(13);
		}
		else if(answer.Contains("")) {
			SceneManager.LoadScene(14);
		}
		else if(answer.Contains("")) {
			SceneManager.LoadScene(15);
		}
		else if(answer.Contains("festa") && answer.Contains("de") && answer.Contains("santana")) {
			SceneManager.LoadScene(16);
		}
		else if(answer.Contains("")) {
			SceneManager.LoadScene(17);
		}
		else if(answer.Contains("")) {
			SceneManager.LoadScene(18);
		}
		else if(answer.Contains("")) {
			SceneManager.LoadScene(19);
		}
		else if(answer.Contains("")) {
			SceneManager.LoadScene(20);
		}
		else if(answer.Contains("todos os caminhos levam a feira de santana")) {
			SceneManager.LoadScene(21);
		}
		else {
			wrong.SetActive(true);
		}
    }

}
