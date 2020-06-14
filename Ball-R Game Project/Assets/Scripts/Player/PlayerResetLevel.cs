using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerResetLevel : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        ResetLevel();

    }
    void ResetLevel()
    {
        if (Input.GetKeyDown("backspace") || Input.GetKeyDown("delete"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
