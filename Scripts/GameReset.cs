using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReset : MonoBehaviour
{
    public float backTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
         Invoke("BackScene", backTime);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BackScene()
    {
        Debug.Log("BackScene() called");
        SceneManager.LoadScene("StartScene");
    }
}
