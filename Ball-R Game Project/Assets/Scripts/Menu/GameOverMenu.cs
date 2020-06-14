using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{ 
    public void StartMenuSegue(int sceneChange)
    {
        Debug.Log("GameOver: Back to Start Menu");
        SceneManager.LoadScene(sceneChange);
    }
}
