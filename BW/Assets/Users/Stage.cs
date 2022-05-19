using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{


    [SerializeField]
    private GameObject floor,moveFloor,wall,moveWall,next;

    private int hole,floorMoveX ,holeRange = 0;

    [SerializeField]
    private int floorNum,kakuritu = 0;

    [SerializeField]
    private bool stageHole = false;

    public static int stageNum=0; 

   [SerializeField]
    private int stageX = 20;
    // Start is called before the first frame update
    void Start()
    {
        stageNum++;
        //stageHole = Random.Range(0, 2);
        Ins();
        Debug.Log(stageNum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Ins()
    {
        for(int i=0;i<=stageX;i++)
        {
            if (stageNum>=2&&holeRange<5) 
            {//åäÇ™Ç†ÇÈÇ©Ç«Ç§Ç©ÇÃ
                hole = Random.Range(0, kakuritu);
            }
            else
            {
                hole = 0;
                holeRange = 0;
            }
            if(hole==0)
            {
                floorNum= Random.Range(0, 5);
                if(floorNum>=1)
                {//ïÅí è∞
                    GameObject gameObject=
                    Instantiate(floor, new Vector2(-8 + i, -5), Quaternion.identity);
                    if (stageNum >= 4&&Random.Range(0,2)==0)
                    {
                        gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
                    }
                    else if(stageNum>=5&&Random.Range(0,8)==0)
                    {

                    }
                    if(Random.Range(0,10)==0)
                    {
                        GameObject wwall=
                         Instantiate(wall, new Vector2(-8 + i, 0.5f), Quaternion.identity);

                    }
                }
                else if(floorNum==0)
                {//ìÆÇ≠è∞
                    floorMoveX = Random.Range(3, 3);
                    
                    if(Random.Range(0,2)==0)
                    {
                        GameObject gameObject =
                        Instantiate(moveFloor, new Vector2(-8 + i+floorMoveX, -5),
                        Quaternion.identity);
                        gameObject.GetComponent<MoveFloor>().moveX = floorMoveX;
                        gameObject.GetComponent<MoveFloor>().moveDirection *= -1;
                        if (stageNum >= 4 && Random.Range(0, 2) == 0)
                        {
                            gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
                        }
                    }
                    else
                    {
                        GameObject gameObject =
                        Instantiate(moveFloor, new Vector2(-8 + i, -5), Quaternion.identity);
                        gameObject.GetComponent<MoveFloor>().moveX = floorMoveX;
                        if (stageNum >= 4 && Random.Range(0, 2) == 0)
                        {
                            gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
                        }
                    }
                    
                    i += floorMoveX;
                }
               
            }
            else 
            {
                holeRange++;
            }


            Debug.Log(i );
            Debug.Log(stageX);
            if (i>=stageX)
            {
                Instantiate(next, new Vector2(-8 + i+4, -5), Quaternion.identity);
            }
        }
       
    }
}
