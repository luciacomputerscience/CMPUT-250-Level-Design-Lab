using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadManager : MonoBehaviour
{
    public TopDownPlayerBehaviour player;

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.M)){
             SceneManager.LoadScene("BasicMenu");
        }
    }
}
