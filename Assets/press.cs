using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class press : MonoBehaviour {
   int n;
   public void OnButtonPress(){
      n++;
      Debug.Log("Button clicked " + n + " times.");
   }
   public void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene ("game");
	}
	public void Exit()
	{
		Application.Quit ();
	}
}