using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cantonada : MonoBehaviour {
    public string nomTag;
    public GameObject text;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == nomTag) {
            // Cridem la funció que està a la classe punts
            text.GetComponent<punts>().sumaPunts();
            Destroy(other.gameObject);
        }
    }
}
