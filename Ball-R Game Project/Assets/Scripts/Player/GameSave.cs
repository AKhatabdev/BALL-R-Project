using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSave : MonoBehaviour
{
    private static GameSave instance;
    public Vector3 lastCheckPointPos;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else { Destroy(gameObject); }
    }
}
