using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Answer : MonoBehaviour {

	InputField iField;
	public GameObject wrong;

	void Start(){
		iField = GetComponent<InputField>();
	}
     
    public void VerifyAnswer()
    {
		if(iField.text == "anarquia e sexo" || iField.text == "Anarquia e Sexo" || iField.text == "Anarquia e sexo") {
			wrong.SetActive(false);
		} else
		{
			wrong.SetActive(true);
		}
    }

}
