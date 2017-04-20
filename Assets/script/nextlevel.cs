using UnityEngine;
using System.Collections;

public class nextlevel : MonoBehaviour {

    void Unlock()
    {
        PlayerPrefs.SetInt()
    }

    void OnMOuseDown()
    {
        transform.localScale *= 0.9F;
    }

    void OnMouseUp()
    {
        Application.LoadLevel(Application.loadedLevel+1);
    }

}
