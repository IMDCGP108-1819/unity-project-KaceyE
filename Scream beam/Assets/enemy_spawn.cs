using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawn : MonoBehaviour {

    public GameObject enemy;
    float randX;
    Vector2 wheretospawn;
    public float spawnrate = 2f;
    float nextspawn = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time > nextspawn) {

            nextspawn = Time.time + spawnrate;
            randX = Random.Range(1.6f, 2f);
            wheretospawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, wheretospawn, Quaternion.identity);
        }


	}
}
