using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float velocity = 2f;
    private Rigidbody2D r2bd;

	// Use this for initialization
	void Start () {
        r2bd = GetComponent<Rigidbody2D>();
        r2bd.velocity = Vector2.left * velocity;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Este es un override
    void OnTriggerEnter2D(Collider2D other ) {
        if ( other.gameObject.tag == "Destroyer")
        {
            Destroy(gameObject);
        }        
    }
}
