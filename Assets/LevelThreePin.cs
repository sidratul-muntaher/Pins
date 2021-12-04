using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelThreePin : MonoBehaviour
{
    [SerializeField] float speed = 20f;

    Rigidbody2D rb;

    bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == ("Rotator"))
        {
            if (Rotator.speed == -100f)
            {
                Rotator.speed = 100f;
            }
            else if (Rotator.speed == 100f)
            {
                Rotator.speed = -100f;
            }
            
            transform.SetParent(collision.transform);
            Score.score++;
            canMove = false;


        }
        else if (collision.tag == ("Pin"))
        {

            Rotator rotator = FindObjectOfType<Rotator>();
            rotator.canRotate = false;
            rotator.GetComponent<Animator>().SetTrigger("GameOver");
        }
    }


}

