using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        var obj = collision.gameObject;
        var health = obj.GetComponent<Health>();

        if (health != null)
            health.TakeDamage(10);

        Destroy(gameObject);
    }
}
