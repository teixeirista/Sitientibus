using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    
    int scene; //Variável que guarda a cena ativa

    void Start() {
        // Salva em uma variável qual cena está ativa
        scene = SceneManager.GetActiveScene().buildIndex;
    }
    void Update() {
        //Verifica se o botão "voltar" foi pressionado
        if (Input.GetKey(KeyCode.Escape))
            if(scene == 0)
                //Se a cena ativa for o menu, encerra a aplicação
                Application.Quit();
            else if (scene > 0 && scene < 10) 
                //Se for um dos enigmas, carrega a cena de seleção de fase
                LoadStageScene(11);
            else 
                //Se não for nenhuma das duas outras, volta para o menu inicial
                SceneManager.LoadScene(0);
    }

    /*
    Este método carrega uma cena que não seja um próximo enigma
     */
    public void LoadStageScene(int s) {
        SceneManager.LoadScene(s);
    }

    /**
    Este método verifica se o enigma está desbloqueado antes de carregá-lo
     */
	/*/public void LoadStage(int stage) {
        //Verifica se a fase requisitada é 
        if(stage <= LevelClear.levelClear.GetStageAt())
            SceneManager.LoadScene(stage);
        else
            return;
    } */
    
}
