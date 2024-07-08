using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    int childCount = 0;
    [HideInInspector] public bool allCoinsCollected = false;
    [SerializeField] private int x;
    private void Start()
    {
        childCount = transform.childCount;
    }

    private void Update()
    {   
        // check if the count of the child objects has changed
        if (transform.childCount<childCount) {
            Debug.Log("A child has been destroyed");

            // Update the childCount variable
            childCount = transform.childCount;

            if (childCount == 0) { 
                allCoinsCollected = true; 
            }
        }
    }
}
