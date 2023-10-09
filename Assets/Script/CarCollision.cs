using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.transform.tag == "Track"){
            CarManager.isGameOver = true;
        }
    }
}
