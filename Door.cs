using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string SceneName = "SecondScene";

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            SceneManager.LoadScene(SceneName);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
