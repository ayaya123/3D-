using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleBlocks : MonoBehaviour {

    public GameObject bombPrefab;

    private Rigidbody rigidBody;
    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Explosion"))
        {
            Destroy(gameObject);
        }
    }
}
