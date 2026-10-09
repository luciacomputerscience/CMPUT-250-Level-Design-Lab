using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicMenuButton : MonoBehaviour
{
    
    public void StartGame(){
        SceneManager.LoadScene(PlayerPrefs.GetString("currentLevel"));
    }
}
