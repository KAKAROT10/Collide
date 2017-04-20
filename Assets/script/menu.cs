using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour
{

    void OnMOuseDown()
    {
        transform.localScale *= 0.9F;
    }

    void OnMouseUp()
    {
        Application.LoadLevel(1);
    }
}
