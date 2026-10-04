using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float timeToDeath = 5f;
    private float timer; 

    // Update is called once per frame
    void Update()
    {
        if(timer<timeToDeath){
            timer+=Time.deltaTime;
        }   
        else{
            Destroy(gameObject);
        }
    }
}
