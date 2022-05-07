using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapMove : MonoBehaviour
{
    public float speed = 0.1f;

    private bool isStart = false;

    private float _timer;

    void Start()
    {
        isStart = true;

        _timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isStart)
        {
            _timer += Time.deltaTime;
            Vector2 position = transform.position;
            if (_timer <= 5.0f)
            {
                position.x -= speed * 5;
            }
            else if (_timer > 5.0f)
            {
                position.x += speed * 5;
                if (_timer > 10.0f)
                {_timer = 0;}
            }
            
            transform.position = position;
        }
        
    }
}
