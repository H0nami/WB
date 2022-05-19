using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    /*
    public int moveX = 3;
    private float moveCount = 0;
    public int moveDirection = 1;
    */
    public bool moveFrag=false;
    // Start is called before the first frame update
    void Start()
    {
        if(Random.Range(0,2)==0)
        GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(moveFrag)
        {
            if (moveCount > moveX)
            {
                moveDirection *= -1;
                moveCount = 0;
            }
            transform.Translate(new Vector2(Time.deltaTime * moveDirection * 2, 0));
            moveCount += Time.deltaTime;
        }
           */
    }
    
}
