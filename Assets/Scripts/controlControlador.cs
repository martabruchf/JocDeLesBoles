using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlControlador : MonoBehaviour {
    public GameObject objecte;
    private Vector3 vel = Vector3.zero;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        int forsa = 8;
        //Dreta
        if (Input.GetKey(KeyCode.RightArrow)) {
            //vel += new Vector3(1, 0, 0);
            objecte.transform.position += transform.right * Time.deltaTime * forsa;
        }
        //Esquerra
        if (Input.GetKey(KeyCode.LeftArrow)) {
            //vel += new Vector3(-1, 0, 0);
            objecte.transform.position -= transform.right * Time.deltaTime * forsa;
        }
        //Endavant
        if (Input.GetKey(KeyCode.UpArrow)) {
            //vel += new Vector3(0, 1, 0);
            objecte.transform.position += transform.forward * Time.deltaTime * forsa;
        }
        //Endarrera
        if (Input.GetKey(KeyCode.DownArrow)) {
            //vel += new Vector3(0, -1, 0);
            objecte.transform.position -= transform.forward * Time.deltaTime * forsa;
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            objecte.transform.Rotate(Vector3.up, -10);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            objecte.transform.Rotate(Vector3.up, +10);
        }

    }
}
