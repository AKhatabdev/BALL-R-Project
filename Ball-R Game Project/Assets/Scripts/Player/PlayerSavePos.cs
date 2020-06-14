using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSavePos : MonoBehaviour
{
    private GameSave cp;

    // Start is called before the first frame update
    void Start()
    {
        cp = GameObject.FindGameObjectWithTag("CheckPoint").GetComponent<GameSave>();
        //transform.position = cp.lastCheckPointPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
