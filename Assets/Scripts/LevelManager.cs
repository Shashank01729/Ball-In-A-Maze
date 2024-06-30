using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour{
    public GameObject ballPrefab;
    public Transform instatiatePos;
    public CameraFollows cameraFollow;
    private void Start()
    {
        GameObject go = Instantiate(ballPrefab,instatiatePos.position,Quaternion.identity);
        cameraFollow.target = go.transform;
    }
}
