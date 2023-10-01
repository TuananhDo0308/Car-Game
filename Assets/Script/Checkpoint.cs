using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Checkpoint : MonoBehaviour
{
    private int countTrack=0;
    timer TimeControl;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        countTrack++;
        if(countTrack==1){
                
        }
        if(countTrack==2){
            CarManager.isGameWin=true;  
            countTrack=0;
        }
    }
}
