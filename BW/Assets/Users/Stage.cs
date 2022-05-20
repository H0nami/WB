using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Stage : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    

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

        text.text = ("STAGE" + stageNum);
    }

    // Update is called once per frame

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            stageNum = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            stageNum = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            stageNum = 2;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            stageNum = 3;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            stageNum = 4;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void Rese()
    {
        stageNum = 0;
    }

    void Ins()
    {
        for(int i=0;i<=stageX;i++)
        {
            if (stageNum >= 5 && Random.Range(0, 8) == 0)
            {
                Debug.Log("aa");
                GameObject mwall =
                 Instantiate(moveWall, new Vector2(-8 + i, -2.5f), Quaternion.identity);
            }

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
                   
                    if(Random.Range(0,10)==0)
                    {
                        GameObject wwall=
                         Instantiate(wall, new Vector2(-8 + i,-2f), Quaternion.identity);

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
                Instantiate(next, new Vector2(-8 + i+2, -5), Quaternion.identity);
            }
        }
       
    }
}
