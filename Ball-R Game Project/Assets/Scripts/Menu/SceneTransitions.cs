using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
    public Animator transitionAnim;
    public PlayerCollision checkFinished;
    public float delayTime = 1.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (checkFinished.levelComplete == true)
        {
            StartCoroutine(LoadScene());
        }
    }

    //Coroutines
    IEnumerator LoadScene()
    { 
        //Animation Level Change transition
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(delayTime);
        // load next level/scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
