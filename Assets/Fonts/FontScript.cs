using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FontScript : MonoBehaviour {

	int index;
	InputField iField;
	string answer;
	public GameObject wrong;
	public GameObject almost;
	public Text eia;

	void Start(){
		iField = GetComponent<InputField>();
	}

	private void Almost() {
		wrong.SetActive(false);
		almost.SetActive(true);
	}

	private void Wrong() {
		almost.SetActive(false);
		wrong.SetActive(true);
	}
     
    public void VerifyAnswer()
    {
		answer = iField.text.ToLower();
		wrong.SetActive(false);
		index = SceneManager.GetActiveScene().buildIndex;


		switch (index)
		{
			case 1:
				if(answer.Contains("feira de santana")) {
					SceneManager.LoadScene(2);
				}
				else if(answer.Contains("feira") || answer.Contains("santana")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 2:
				if(answer.Contains("lugar") && answer.Contains("trem") && answer.Contains("tomba")) {
					SceneManager.LoadScene(3);
				}
				else if(answer.Contains("lugar") || answer.Contains("trem") || answer.Contains("tomba")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 3:
				if(answer.Contains("domingos") && answer.Contains("ana")) {
					SceneManager.LoadScene(4);
				}
				else if(answer.Contains("domingos") || answer.Contains("ana")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 4:
				if(answer.Contains("rio subaé")) {
					SceneManager.LoadScene(5);
				}
				else if(answer.Contains("subaé")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 5:
				if(answer.Contains("ruy barbosa")) {
					SceneManager.LoadScene(6);
				}
				else if(answer.Contains("ruy") || answer.Contains("barbosa")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 6:
				if(answer.Contains("atormentado")) {
					SceneManager.LoadScene(7);
				} else {
					Wrong();
				}
				break;

			case 7:
				if(answer.Contains("aos que tem sede")) {
					SceneManager.LoadScene(8);
				}
				else if(answer.Contains("sede")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 8:
				if(answer.Contains("pindoba") && answer.Contains("tábua") && answer.Contains("prato raso") && answer.Contains("grande") && answer.Contains("salgada") && answer.Contains("geladinho") && answer.Contains("subaé") && answer.Contains("chico maia") && answer.Contains("berreca")) {
					SceneManager.LoadScene(9);
				}
				else if(answer.Contains("pindoba") || answer.Contains("tábua") || answer.Contains("prato raso") || answer.Contains("grande") || answer.Contains("salgada") || answer.Contains("geladinho") || answer.Contains("subaé") || answer.Contains("chico maia") || answer.Contains("berreca")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 9:
				if(answer.Contains("ponte rio branco")) {
					SceneManager.LoadScene(10);
				}
				else if(answer.Contains("rio") || answer.Contains("branco")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 10:
				if(answer.Contains("cidade nova") && answer.Contains("jomafa") && answer.Contains("viveiros")) {
					SceneManager.LoadScene(11);
				}
				else if(answer.Contains("cidade nova") || answer.Contains("jomafa") || answer.Contains("viveiros")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 11:
				if(answer.Contains("correto")) {
					SceneManager.LoadScene(12);
				}
				else if(answer.Contains("quase")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 12:
				if(answer.Contains("1009")) {
					SceneManager.LoadScene(13);
				}
				else if(answer.Contains("bicho do tomba")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 13:
				if(answer.Contains("correto")) {
					SceneManager.LoadScene(14);
				}
				else if(answer.Contains("quase")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 14:
				if(answer.Contains("correto")) {
					SceneManager.LoadScene(15);
				}
				else if(answer.Contains("quase")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 15:
				if(answer.Contains("festa") && answer.Contains("de") && answer.Contains("santana")) {
					SceneManager.LoadScene(16);
				}
				else if(answer.Contains("bando anunciador") || answer.Contains("festa") || answer.Contains("santana")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 16:
				if(answer.Contains("correto")) {
					SceneManager.LoadScene(17);
				}
				else if(answer.Contains("quase")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 17:
				if(answer.Contains("correto")) {
					SceneManager.LoadScene(18);
				}
				else if(answer.Contains("quase")) {
					Almost();
				} else {
					Wrong();
				}
				break;
			
			case 18:
				if(answer.Contains("correto")) {
					SceneManager.LoadScene(19);
				}
				else if(answer.Contains("quase")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 19:
				if(answer.Contains("correto")) {
					SceneManager.LoadScene(20);
				}
				else if(answer.Contains("quase")) {
					Almost();
				} else {
					Wrong();
				}
				break;

			case 20:
				if(answer.Contains("todos os caminhos levam a feira de santana")) {
					SceneManager.LoadScene(21);
				}
				else if(answer.Contains("caminhos")) {
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
/*		if(answer.Contains("feira de santana")) {
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
		else if(answer.Contains("1000000")) {
			SceneManager.LoadScene(12);
		}
		else if(answer.Contains("1009")) {
			SceneManager.LoadScene(13);
		}
		else if(answer.Contains("500000")) {
			SceneManager.LoadScene(14);
		}
		else if(answer.Contains("100000")) {
			SceneManager.LoadScene(15);
		}
		else if(answer.Contains("festa") && answer.Contains("de") && answer.Contains("santana")) {
			SceneManager.LoadScene(16);
		}
		else if(answer.Contains("100000")) {
			SceneManager.LoadScene(17);
		}
		else if(answer.Contains("100000")) {
			SceneManager.LoadScene(18);
		}
		else if(answer.Contains("100000")) {
			SceneManager.LoadScene(19);
		}
		else if(answer.Contains("100000")) {
			SceneManager.LoadScene(20);
		}
		else if(answer.Contains("todos os caminhos levam a feira de santana")) {
			SceneManager.LoadScene(21);
		}
		else {
			wrong.SetActive(true);
		}*/