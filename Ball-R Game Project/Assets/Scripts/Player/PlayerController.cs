using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class PlayerController : MonoBehaviour
{
    //Motion
    public float speed;
    //Body
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (movement.magnitude >= 0.1f)
        {
            rb.AddForce(movement * speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //Go faster down half pipes
        if (other.gameObject.CompareTag("Slope"))
        {
            rb.maxAngularVelocity = 2;
        }
        //Else Normal Angular Velocity 
        else { rb.maxAngularVelocity = 10; }
    }
}