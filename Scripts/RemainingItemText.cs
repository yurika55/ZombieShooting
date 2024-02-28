using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RemainingItemText : MonoBehaviour
{
    public float gameClearTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int RemainingItemNumber = GameObject.FindGameObjectsWithTag("Zombie").Length;

        if(RemainingItemNumber == 0)
        {
            //ゲームクリア場面に移動する
            Invoke("Gameclear", gameClearTime);
        }
        // else
        // {
        //     gameObject.GetComponent<UnityEngine.UI.Text>().text = $"残り{RemainingItemNumber}体";
        // }

    }

    void Gameclear()
    {
         SceneManager.LoadScene("GameClear");
    }
}
