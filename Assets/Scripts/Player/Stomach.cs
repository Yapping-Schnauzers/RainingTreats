using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles items consumed by Selena
public class Stomach : MonoBehaviour {
    Dictionary<Food, int> stomach;

    // Start is called before the first frame update
    void Start() {
        stomach = new Dictionary<Food, int>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void Eat(Food food) {
        if (stomach.TryGetValue(food, out int count)) {
            stomach[food] = count + 1;
        } else {
            stomach[food] = 1;
        }
    }
}
