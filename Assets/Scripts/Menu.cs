using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void LoadStage(int stage)
    {
        SceneManager.LoadScene(stage);
    }
}
