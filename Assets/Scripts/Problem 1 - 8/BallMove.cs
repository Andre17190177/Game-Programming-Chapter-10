using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    Rigidbody2D rb;
    float h;
    float v;
    float moveLimiter = 0.7f;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (h != 0 && v != 0)
        {
            h *= moveLimiter;
            v *= moveLimiter;
        }

        rb.velocity = new Vector2(h * speed, v * speed);
    }
}
