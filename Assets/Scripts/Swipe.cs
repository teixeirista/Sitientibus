using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour {

    Vector2 tPosition;

    void Start() {
        tPosition = new Vector2(360.0f, 289.4064f);
        transform.position = tPosition;
    }

    private void LateUpdate() {
        if(transform.position.y < 289.4064f) {
            tPosition = new Vector2(360.0f, 289.4064f);
            transform.position = tPosition;
        }
        else if(transform.position.y > 1000.4319f) {
            tPosition = new Vector2(360.0f, 1000.4319f);
            transform.position = tPosition;
        }
    }
}     

