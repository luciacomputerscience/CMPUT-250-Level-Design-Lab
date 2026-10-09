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
        TopDownUITimeBehaviour timescript = Object.FindObjectOfType<TopDownUITimeBehaviour>();
        timescript.time = PlayerPrefs.GetFloat("time");

        if (SceneManager.GetActiveScene().name == "Intro Level"){
            timescript.time = 0f;
            PlayerPrefs.SetFloat("time", timescript.time);
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            SceneManager.LoadScene("BasicMenu");
        }
    }
}
