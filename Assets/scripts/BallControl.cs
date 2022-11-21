using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody ball;
    private float speed;
    private float dirX;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
        speed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * speed;
        ball.velocity = new Vector3(dirX, ball.velocity.y);

    }
}
