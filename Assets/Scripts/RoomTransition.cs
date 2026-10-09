using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomTransition : MonoBehaviour
{
    public string SceneToTransitionTo = "";


    void OnTriggerEnter2D(Collider2D col)
    {
        TopDownPlayerBehaviour player = col.gameObject.GetComponent<TopDownPlayerBehaviour>();

        if (player != null)
        {
            if (SceneToTransitionTo != "")
            {
                //Get Time 
                TopDownUITimeBehaviour timescript = Object.FindObjectOfType<TopDownUITimeBehaviour>();
                PlayerPrefs.SetFloat("time", timescript.time);

                PlayerPrefs.SetString("currentLevel", SceneToTransitionTo);
                SceneManager.LoadScene(SceneToTransitionTo);
            }
        }
    }
}
