using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T03 : MonoBehaviour
{

    private int ball_score = 0;

    public Rigidbody2D rb;

    public Text Score;

    // Start is called before the first frame update
    void Start()
    {

        rb = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter2D(Collider2D others)
    {

        if(others.gameObject.CompareTag("rightWall"))
        {

            AddScore();

            plusSpeed();

        }

        if (others.gameObject.CompareTag("leftWall"))
        {

            Reset();

        }


    }

    void AddScore()
    {

        ball_score++;

        Score.text = ball_score.ToString();

    }

    void Reset()
    {

        ball_score = 0;

        Score.text = ball_score.ToString();

        this.transform.position = new Vector3(0f, 0f, 0f);

        rb.velocity = new Vector2(10f, 10f);

    }

    void plusSpeed()
    {

        float vx = rb.velocity[0] + (rb.velocity[0] > 0 ? 1 : -1);
        float vy = rb.velocity[1] + (rb.velocity[1] > 0 ? 1 : -1);

        rb.velocity = new Vector2(vx, vy);

    }
}
