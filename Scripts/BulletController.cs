using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    /// <summary>
    /// 弾の速度 (m/s)
    /// </summary>
    [SerializeField]
    private float m_bulletSpeed = 27.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //弾を前に進ませる
        transform.position += transform.forward * m_bulletSpeed * Time.deltaTime;
    }

    
}
