using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayButton : MonoBehaviour
{
    public GameObject audioObject; // 音声を再生するためのオーディオソースを持つGameObjectを指定する変数

    // ボタンがクリックされた時に呼び出されるメソッド
    public void AudioPlay()
    {
        // 指定されたaudioObjectにアタッチされたAudioSourceコンポーネントを取得し、再生する
        audioObject.GetComponent<AudioSource>().Play();
    }
}

