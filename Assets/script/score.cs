using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

    public TextMesh currSco;
    public GameObject sprite1,sprite2,sprite3;
    public int points;
    float speed;
    float xpos;
    public Rigidbody2D rigid;
    GameObject ball;
    int i = 0;

    void Update()
    {
        ball = GameObject.FindGameObjectWithTag("Player");

        if (ball != null) { 
        rigid = ball.GetComponent<Rigidbody2D>();
        speed = rigid.velocity.magnitude;
        xpos = rigid.position.magnitude; }
        if (xpos < 6)
            i = 1;
        if (speed<=0.8&&i==1)
        {
            Destroy(ball);
            Instantiate(sprite1, new Vector3((float)1.42,(float)-1.61,(float) -1), Quaternion.identity);
            Instantiate(sprite2, new Vector3((float)-2.29, (float)-1.66, (float)-1), Quaternion.identity);

        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            i = 0;
            if (speed < 5)
            {
                currSco.text = "" + points;
                speed = 0;
                Destroy(ball);
                Instantiate(sprite1, new Vector3((float)-0.3, (float)0.1, (float)-1),Quaternion.identity);
                Instantiate(sprite2, new Vector3((float)-2.29, (float)-1.66, (float)-1), Quaternion.identity);
                Instantiate(sprite3, new Vector3((float)1.42, (float)-1.61, (float)-1), Quaternion.identity);
            }
        }
    }
}
