using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

// 必須コンポーネントとしてXRGrabInteractableを指定
[RequireComponent(typeof(XRGrabInteractable))]

public class Haptics : MonoBehaviour
{
   
   [Header("Trigger haptics parameters")]
   [SerializeField] float triggerAmplitude = 0.95f; // 振幅 (0.0〜1.0)
   [SerializeField] float triggerDuration = 0.2f; // 持続時間(秒) ()


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   // Activate Action(トリガー押下)発生時に実行する処理
    public void pullTrigger(ActivateEventArgs arg)
    {
       // イベント発生元のXRBaseControllerに振動させる。
       arg.interactor.GetComponent<XRBaseController>().SendHapticImpulse(triggerAmplitude,triggerDuration);
       //GetComponent<XRBaseController>().SendHapticImpulse(triggerAmplitude,triggerDuration);
       
    }
   
}
