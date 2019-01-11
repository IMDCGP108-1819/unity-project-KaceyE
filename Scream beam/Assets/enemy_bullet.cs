using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet : MonoBehaviour {

    public float speed = 20f;
    public int damage = 15;
    public Rigidbody2D rb;


    // Use this for initialization
    void Start()
    {



        rb.velocity = transform.forward * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {


        playermovement player = hitInfo.GetComponent<playermovement>();
        if (player != null)
        {


            player.TakeDamage(damage);
        }



        Destroy(gameObject);


    }


}

