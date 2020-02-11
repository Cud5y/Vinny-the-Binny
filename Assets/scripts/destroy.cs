using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "bottle lol(Clone)"){
            Destroy(other.gameObject);
        }
        if(other.gameObject.name == "Sprite-0001(Clone)"){
            Destroy(other.gameObject);
        }
    }
}
