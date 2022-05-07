using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{
    public GameObject PlayerBullet;
    Vector3 PlayerPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            PlayerPos = transform.position;
            PlayerPos.x += 1.0f;
            Instantiate(PlayerBullet,PlayerPos,Quaternion.identity);
        }
    }
}
