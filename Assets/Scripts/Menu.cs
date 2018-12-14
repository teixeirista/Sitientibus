using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    int scene;

    void Start() {
        scene = SceneManager.GetActiveScene().buildIndex;
    }
    void Update() {
        if (Input.GetKey(KeyCode.Escape))
            if(scene == 0)
                Application.Quit();
            else if (scene > 0 && scene < 20)
                LoadStageScene(21);
            else
                SceneManager.LoadScene(0);
    }

    public void LoadStageScene(int s) {
        SceneManager.LoadScene(s);
    }

	public void LoadStage(int stage) {
        if(stage <= LevelClear.levelClear.GetStageAt())
            SceneManager.LoadScene(stage);
        else
            return;
    }
    
}
