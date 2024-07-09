using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour{
    public float speed;
    private string tag_wall = "wall";
    private int currScore;
    // Update is called once per frame
    void Update(){
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
       
        Vector3 movement = new Vector3(HorizontalInput,0.0f,VerticalInput) * speed * Time.deltaTime;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement,ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == tag_wall){
            Debug.Log("Collided with wall");
            currScore = ScoreManager.instance.getScore();
            if(currScore>0){
                ScoreManager.instance.addScore(-1);
            }
        }
    }
}
