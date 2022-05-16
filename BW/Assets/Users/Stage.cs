using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{


    [SerializeField]
    private GameObject floor,moveFloor;

    private int stageHole,hole,floorNum = 0;

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
            if(stageHole ==1)
            {//ŒŠ‚ª‚ ‚é‚©‚Ç‚¤‚©‚Ì
                hole = Random.Range(0, 2);
            }
            if(hole==0)
            {
                if(floorNum==0)
                {
                    Instantiate(floor, new Vector2(-8 + i, -5), Quaternion.identity);
                }
                else if(floorNum==1)
                {

                }
               
            }
           
        }
       
    }
}
