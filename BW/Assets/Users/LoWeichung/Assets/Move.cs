using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    void Update()
    {
        Rigidbody2D PlayerMove = this.GetComponent<Rigidbody2D>();

        if (Input.GetKey(KeyCode.A))
        {
            Vector2 force = new Vector2(-3.0f, 0.0f);
            PlayerMove.AddForce(force, ForceMode2D.Impulse);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            Vector2 force = new Vector2(3.0f, 0.0f);
            PlayerMove.AddForce(force, ForceMode2D.Impulse);
        }
    }
}
