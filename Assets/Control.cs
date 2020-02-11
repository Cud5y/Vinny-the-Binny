using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public void IveBeenClicked(int SceneIndex)
    {
        SceneManager.LoadScene("game");
    }
}