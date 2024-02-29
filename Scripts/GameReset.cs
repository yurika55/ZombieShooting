using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReset : MonoBehaviour
{
    public float backTime = 1.0f; // シーンを戻るまでの時間を設定する変数
    // Start is called before the first frame update
    void Start()
    {
        // Invokeメソッドを使って、指定した時間後にBackSceneメソッドを呼び出します。
         Invoke("BackScene", backTime);

    }

    // BackSceneメソッドは、ゲームを最初のシーンに戻すために使用されます。
    void BackScene()
    {
        Debug.Log("BackScene() called");
        // SceneManager.LoadSceneメソッドを使って、"StartScene"という名前のシーンに切り替えます。
        SceneManager.LoadScene("StartScene");
    }
}
