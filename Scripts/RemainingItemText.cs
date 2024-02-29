using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RemainingItemText : MonoBehaviour
{
    public float gameClearTime = 1.0f;// ゲームクリアに移行するまでの待機時間

    // Update is called once per frame
    void Update()
    {
        // "Zombie"タグが付いたオブジェクトの数をカウント
        int RemainingItemNumber = GameObject.FindGameObjectsWithTag("Zombie").Length;

        // 残りのアイテム数が0になったらゲームクリア処理を行う
        if(RemainingItemNumber == 0)
        {
            // gameClearTime秒後にGameclearメソッドを呼び出す
            Invoke("Gameclear", gameClearTime);
        }

    }

 // ゲームクリアのシーンに移行するメソッド
    void Gameclear()
    {
         SceneManager.LoadScene("GameClear");
    }
}
