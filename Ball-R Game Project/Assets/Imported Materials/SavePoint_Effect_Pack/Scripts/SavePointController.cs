using UnityEngine;
using System.Collections;

public class SavePointController : MonoBehaviour {

	public GameObject Col_on;
    public GameSave cp;

    void Start()
    {
        cp = GameObject.FindGameObjectWithTag("CP").GetComponent<GameSave>();
    }
    void Awake(){
		Col_on = gameObject.transform.Find ("root/On").gameObject;
	}

	void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("SaveSound");

            Col_on.active = true;
            cp.lastCheckPointPos = transform.position;
            Debug.Log(cp);
        }

    }

	void OnTriggerExit(Collider other) {
		// Destroy everything that leaves the trigger
		Col_on.active = false;
	}
}
