using UnityEngine;
using System.Collections;

public class LockLevel : MonoBehaviour
{

    public static int world = 1;
    public static int levels = 2;

    private int worldIndex;
    private int levelIndex;


    void Start()
    {
        PlayerPrefs.DeleteAll();
        LockLevels();
    }

    void LockLevels()
    {
        worldIndex = 1;
        levelIndex = 1;
        PlayerPrefs.SetInt("level" + worldIndex.ToString() + ":" + levelIndex.ToString(), 1);

            for (int i = 0; i < world; i++)
        {
            for (int j = 1; j < levels; j++)
            {
                worldIndex = (i + 1);
                levelIndex = (j + 1);
                GameObject.Find("LockedLevel" + (j + 1)).active = true;
                if (!PlayerPrefs.HasKey("level" + worldIndex.ToString() + ":" + levelIndex.ToString()))
                {
                    PlayerPrefs.SetInt("level" + worldIndex.ToString() + ":" + levelIndex.ToString(), 0);
                }

            }
        }

    }
}