using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisonFloor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "bottle lol(Clone)"){
            LivesText.livesValue -=1;
            Destroy(other.gameObject);
        }
        if(other.gameObject.name == "Sprite-0001(Clone)"){
            Destroy(other.gameObject);
        }
        if(other.gameObject.name == "dinasoor"){
            Destroy(other.gameObject);
        }
    }
}
