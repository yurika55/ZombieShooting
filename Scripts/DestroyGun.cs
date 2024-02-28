using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
 
        // もしもぶつかってきたオブジェクトのタグに「Bullet」という名前がついていたら
        if(other.CompareTag("Bullet")){
 
            // ぶつかってきたオブジェクトを破壊（削除）せよ。
            Destroy(other.gameObject);
        }
    }
}
