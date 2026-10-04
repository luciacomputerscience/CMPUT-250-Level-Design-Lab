using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TopDownUITimeBehaviour : MonoBehaviour
{
    [SerializeField] public float time;
    [SerializeField] TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        text.text = time.ToString("F1");
    }
}
