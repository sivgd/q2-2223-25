using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public float accel = 8;
    //public GameObject mainPlayer;
    private Rigidbody2D rb2;
    private bool MoveLeft = true;


    //private Vector2 playerPosition;

    //public bool playerOnLeft;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //playerPosition = mainPlayer.transform.position;
        //if (gameObject.transform.position.x > playerPosition.x)
        //{
        //    playerOnLeft = true;
        //    rb2.AddForce(new Vector2(-accel, 0));
        //}
        //else
        //{
        //    playerOnLeft = false;
        //    rb2.AddForce(new Vector2(accel, 0));
        //}

        if (MoveLeft == true)
        {
            rb2.AddForce(new Vector2(-accel, 0));
        }
        else
        {
            rb2.AddForce(new Vector2(accel, 0));
        }

        //Move right
        //if (mainPlayer.transform)
        //{
        //rb2.AddForce(new Vector2(accel, 0));
        //}

        //Move left
        //if (Input.GetAxis("Horizontal") < 0)
        //{
        //rb2.AddForce(new Vector2(-accel, 0));
        //}



    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        SceneManager.LoadScene("PlatformerScene");
    //    }
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (MoveLeft == true)
        {
            MoveLeft = false;
        }
        else
        {
            MoveLeft = true;
        }
    }

}
