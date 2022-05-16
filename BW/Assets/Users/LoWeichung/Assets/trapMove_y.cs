using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapMove_y : MonoBehaviour
{
    private float _timer;

    void Update()
    {
        _timer += Time.deltaTime;
        Rigidbody2D trapRb = this.GetComponent<Rigidbody2D>();
        Debug.Log(_timer);
        if (_timer < 3.0f)
        {
            Vector2 force = new Vector2(0.0f, -3.0f);
            trapRb.AddForce(force, ForceMode2D.Impulse);
        }
        else if (_timer >= 3.0f && _timer < 4.0f)
        { trapRb.velocity = Vector2.zero; }
        if (_timer >= 4.0f)
        {
            Vector2 force = new Vector2(0.0f, 3.0f);
            trapRb.AddForce(force, ForceMode2D.Impulse);
            if (_timer >= 7.0f)
            {
                trapRb.velocity = Vector2.zero;
                _timer = 0.0f;
            }
        }
    }
}