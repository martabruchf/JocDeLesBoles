using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class punts : MonoBehaviour {
    int _punts = 0;
    Text textPunts;

    // Start is called before the first frame update
    void Start() {
        textPunts = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void sumaPunts() {
        _punts++;
        textPunts.text = _punts.ToString();
        if (_punts == 4) {
            Time.timeScale = 0;
        }
    }
}
