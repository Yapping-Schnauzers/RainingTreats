using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    // Basic singleton.
    public static GameManager Instance { get; private set; }

    // Start is called before the first frame update
    void Start() {
        if (Instance != null) {
            Debug.LogError("Instance of GameManager already exists.");
        }

        Instance = this;
    }

    // Update is called once per frame
    void Update() {
        
    }
}
