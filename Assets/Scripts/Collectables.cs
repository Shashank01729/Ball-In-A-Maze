using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour{
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            Debug.Log("Ball Collided with coin");
            // Add Score
            ScoreManager.instance.addScore(1);
            Invoke("DestroyCollectables",0f);
        }
    }

    void DestroyCollectables(){
        Destroy(this.gameObject);
    }
}
