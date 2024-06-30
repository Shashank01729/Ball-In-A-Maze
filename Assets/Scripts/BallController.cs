using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour{
    public float speed;
    // Update is called once per frame
    void Update(){
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
       
        Vector3 movement = new Vector3(HorizontalInput,0.0f,VerticalInput) * speed * Time.deltaTime;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement,ForceMode.Impulse);
    }
}
