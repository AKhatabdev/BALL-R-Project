using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatformUp : MonoBehaviour
{
    private Vector3 MovingDirection = Vector3.up;
    private Vector3 startPos;
    private Vector3 endPos;
    public GameObject endPath;

    private void Start()
    {
        //Get object positions
        startPos = gameObject.transform.position;
        endPos = endPath.transform.position;
    }
    void Update()
    {
        gameObject.transform.Translate(MovingDirection * Time.smoothDeltaTime * 1.3f);

        if (gameObject.transform.position.y > endPos.y)
        {
            MovingDirection = Vector3.down;
        }
        else if (gameObject.transform.position.y < startPos.y) //Change to Object Y position 
        {
            MovingDirection = Vector3.up;
        }
    }
}