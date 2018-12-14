using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelClear : MonoBehaviour {

    public static LevelClear levelClear;

    public int stageAt = 1;

	// Use this for initialization
	void Awake () {
		if(PlayerPrefs.GetInt("Stage") > 1)
			stageAt = PlayerPrefs.GetInt("Stage");
		
		if(levelClear == null)
        {
            levelClear = this;
        }
        else if (levelClear != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
	}

    public void UnlockStage(int stageUnlock)
    {
        if(stageUnlock > stageAt) {
            stageAt = stageUnlock;
			PlayerPrefs.SetInt("Stage", stageAt);
        }
    }

    public int GetStageAt()
    {
        return stageAt;
    }
}
