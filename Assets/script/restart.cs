using UnityEngine;
using System.Collections;

public class restart : MonoBehaviour {


    void OnMOuseDown()
    {
        transform.localScale *= 0.9F;
    }

    void OnMouseUp()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

}
