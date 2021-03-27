using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlEnemic : MonoBehaviour {
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(Random.Range(6, 15), 0, Random.Range(6, 15));

    }

    // Update is called once per frame
    void Update() {
        
    }
}
