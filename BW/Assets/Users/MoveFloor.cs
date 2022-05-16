using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    [SerializeField]
    //private GameObject floor;
    public int sizeX = 1;
    public int moveX = 3;
    private float moveCount = 0;
    private int moveDirection = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(moveCount>moveX)
        {
            moveDirection *= -1;
            moveCount = 0;
        }
        transform.Translate(new Vector2(Time.deltaTime * moveDirection, 0));
        moveCount += Time.deltaTime;
    }
}
