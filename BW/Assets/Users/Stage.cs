using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{


    [SerializeField]
    private GameObject floor,moveFloor;

    private int hole = 0;

    [SerializeField]
    private int floorNum,kakuritu = 0;

    [SerializeField]
    private bool stageHole = false;



   [SerializeField]
    private int stageX = 20;
    // Start is called before the first frame update
    void Start()
    {
        //stageHole = Random.Range(0, 2);
        Ins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Ins()
    {
        for(int i=0;i<stageX;i++)
        {
            if (stageHole == true) 
            {//ŒŠ‚ª‚ ‚é‚©‚Ç‚¤‚©‚Ì
                hole = Random.Range(0, kakuritu);
            }
            if(hole==0)
            {
                floorNum= Random.Range(0, 5);
                if(floorNum>=1)
                {
                    Instantiate(floor, new Vector2(-8 + i, -5), Quaternion.identity);
                }
                else if(floorNum==0)
                {
                    GameObject gameObject=
                    Instantiate(moveFloor, new Vector2(-8 + i, -5), Quaternion.identity);
                    gameObject.GetComponent<MoveFloor>().moveX = 4;
                    i += 4;
                }
               
            }
           
        }
       
    }
}
