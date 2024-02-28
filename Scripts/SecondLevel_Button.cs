using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SecondLevel_Button : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Satsuki");
    }
}
