using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    //UI
    public Text scoreText;
    public Text levelCompleteText;
    private int count;
    private int blueCubes;

    //Level Complete INdicator
    public bool levelComplete = false;

    // Start is called before the first frame update
    void Start()
    {
        blueCubes = GameObject.FindGameObjectsWithTag("BlueCube").Length;
        count = blueCubes;
        SetScoreText();
        levelCompleteText.text = "";
    }

    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BlueCube"))
        {
            FindObjectOfType<AudioManager>().Play("BlueItem");

            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            count--;
            SetScoreText();
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Blue Cubes: " + count.ToString();

        if (count == 0)// Change back to 7; 1 for testing
        {
            levelCompleteText.text = "Level Complete";
            levelComplete = true;

        }
    }
    
}
