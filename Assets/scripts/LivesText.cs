using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesText : MonoBehaviour
{
    public static int livesValue = 9;
    Text lives;
    // Start is called before the first frame update
    void Start()
    {
        lives = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(livesValue == 9){
            lives.text = "Lives: 3";
        }
        if(livesValue == 6){
            lives.text = "Lives: 2";
        }
        if(livesValue == 3){
            lives.text = "Lives: 1";
        }
        if(livesValue == 0){
            SceneManager.LoadScene("game over");
        }
    }
}
