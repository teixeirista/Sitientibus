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
		else if(answer.Contains("cidade nova") && answer.Contains("jomafa") && answer.Contains("viveiros")) {
			SceneManager.LoadScene(3);
		}
		else if(answer.Contains("festa") && answer.Contains("de") && answer.Contains("santana")) {
			SceneManager.LoadScene(4);
		}
		else if(answer.Contains("1009")) {
			SceneManager.LoadScene(5);
		}
		else if(answer.Contains("ovni")) {
			SceneManager.LoadScene(5);
		}
		else if(answer.Contains("princesa do sertão")) {
			SceneManager.LoadScene(5);
		}
		else if(answer.Contains("todos os caminhos")) {
			SceneManager.LoadScene(5);
		}
		else {
			wrong.SetActive(true);
		}
    }

}
