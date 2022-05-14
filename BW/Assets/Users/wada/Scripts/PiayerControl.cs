using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiayerControl : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = this.transform.position;
        if(Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed;
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed;
        }
        transform.position = pos;
    }
}
