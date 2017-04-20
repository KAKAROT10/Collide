
using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour
{

    private int worldIndex;
    private int levelIndex;

    void Start()
    {

        worldIndex = 1;
        levelIndex = 1;
        CheckLockedLevels();

        
    }

    public void Selectlevel(string worldLevel)
    {
        
        if ((PlayerPrefs.GetInt("level" + worldIndex.ToString() + ":" + worldLevel[2])) == 1)
            Application.LoadLevel("Level" + worldLevel);
    }

    void CheckLockedLevels()
    {
        for (int j = 1; j < LockLevel.levels; j++)
        {
            levelIndex = (j + 1);
            Debug.Log(PlayerPrefs.GetInt("level" + worldIndex.ToString() + ":" + levelIndex.ToString()));
            if ((PlayerPrefs.GetInt("level" + worldIndex.ToString() + ":" + levelIndex.ToString())) == 1)
            {
                Debug.Log("hi");
                GameObject.Find("LockedLevel" + (j + 1)).active = false;
                Debug.Log("Unlocked");
            }
        }
    }
}
