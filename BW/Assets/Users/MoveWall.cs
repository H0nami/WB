using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    public int moveX = 7;
    private float moveCount = 0;
    public int moveDirection = 1;

    // Start is called before the first frame update
    void Start()
    {
        if(Random.Range(0,2)==0)
        {
            moveDirection *= -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (moveCount > moveX)
        {
            moveDirection *= -1;
            moveCount = 0;
        }
        transform.Translate(new Vector2(Time.deltaTime * moveDirection * 4, 0));
        moveCount += Time.deltaTime*4;
    }
}
