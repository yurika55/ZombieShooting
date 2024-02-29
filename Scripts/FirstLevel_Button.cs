using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class FirstLevel_Button : MonoBehaviour
{
    // StartGameメソッドはボタンクリックなどによって呼び出される
    public void StartGame()
    {
        // "Map_v1"という名前のシーンをロードする
        // このメソッドが呼ばれると、指定されたシーンに切り替わる
        SceneManager.LoadScene("Map_v1");
    }

}
