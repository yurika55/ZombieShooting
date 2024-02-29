using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGun : MonoBehaviour
{

    // 他のColliderがこのColliderに侵入したときに呼び出されるメソッド
    void OnTriggerEnter(Collider other){
 
        // もしもぶつかってきたオブジェクトのタグに「Bullet」という名前がついていたら
        if(other.CompareTag("Bullet")){
 
            // ぶつかってきたオブジェクトを破壊（削除）せよ。
            Destroy(other.gameObject);
        }
    }
}
