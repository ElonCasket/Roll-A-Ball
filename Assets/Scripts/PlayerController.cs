using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 1f;
    public int pickupCount;
    void Start()
    {
        //Gets rigidbody component attatched to this game object
        rb = GetComponent<Rigidbody>();
        pickupCount = GameObject.FindGameObjectsWithTag("Pickup").Length;
        CheckPickups();
    }

    void FixedUpdate()
    {
        //Store horizontal and vertical axis in a float
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        //Create new vector3 based on above values
        Vector3 movement = new Vector3(moveHorizontal,0f,moveVertical);
        //Move object
        rb.AddForce(movement*speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            pickupCount -= 1;
            CheckPickups();
            Destroy(other.gameObject);
        }
    }
    void CheckPickups()
    {
        Debug.Log("Pickup count: " + pickupCount);
        if (pickupCount == 0)
        {
            Debug.Log("you win");
        }
    }

}





