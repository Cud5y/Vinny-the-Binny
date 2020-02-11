using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "main bin"){
                ScoreScript.scoreValue +=10;
                LivesText.livesValue += 1;
        }  
    }
}
