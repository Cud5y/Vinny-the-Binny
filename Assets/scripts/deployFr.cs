using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployFr : MonoBehaviour
{
    public GameObject FriendlyPrefab;
    private Vector2 screenBounds;
    public float respawnTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(FriendlyWave());
    }
    private void spawnFriendly(){
        GameObject a = Instantiate(FriendlyPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y);
    }
    IEnumerator FriendlyWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnFriendly();
        }
    }
}
