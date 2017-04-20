using UnityEngine;
using System.Collections;

public class back1 : MonoBehaviour {

        void OnMOuseDown()
        {
            transform.localScale *= 0.9F;
        }

        void OnMouseUp()
        {
            Application.LoadLevel(1);
        }
    }
