using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float bulletSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        Vector2 bulletPos = transform.position;
        bulletPos.x += bulletSpeed *1000* Time.deltaTime;
        transform.position = bulletPos;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Breakable")
        {
            Debug.Log("A");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
