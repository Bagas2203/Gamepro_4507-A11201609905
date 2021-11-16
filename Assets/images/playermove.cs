using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playermove : MonoBehaviour
{
    public float lompat;
    [SerializeField]
    bool isGrounded = false;
    Rigidbody2D RB;

    

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()

    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, lompat);
            if (isGrounded == true)
            {
                RB.AddForce(Vector2.up * lompat);
                isGrounded = false;
            }

        }
       

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            if (isGrounded == false)
            {
                isGrounded = true;
            }
        }

        if (collision.gameObject.CompareTag("rintangan"))
        {
            Die();
            
        }


    }
    void Die()
    {
        SceneManager.LoadScene("gameover");
    }

}

    