using UnityEngine;
using System.Collections;

public class exitgame : MonoBehaviour {

	void OnMouseDown()
    {
        transform.localScale *= 0.9F;
    }

    void OnMouseUp()
    {
        Application.Quit();
    }
}
