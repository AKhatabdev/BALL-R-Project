using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PLAYER RESPAWN IF OUT OF BOUNDS AND !SAVEPOINT
public class PlayerRespawn : MonoBehaviour
{
        public Transform player;
        private GameSave cp;

        void Start()
        {
            cp = GameObject.FindGameObjectWithTag("CP").GetComponent<GameSave>();
        }
        void OnTriggerEnter(Collider other)
        {

            FindObjectOfType<AudioManager>().Play("PlayerDeath");

            //Check Point Respawn
            Vector3 oldPos = cp.lastCheckPointPos;
            //Add Height to Respawn
            Vector3 NewPos = new Vector3(oldPos.x, oldPos.y + 5.5f, oldPos.z);
            player.transform.position = NewPos;
         
        }
 }

