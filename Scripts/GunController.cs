using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunController : MonoBehaviour
{

    /// <summary>
    /// 銃弾のプレハブ。
    /// 発砲した際に、このオブジェクトを弾として実体化する。
    /// </summary>
    [SerializeField]
    private GameObject m_bulletPrefab = null;
    public AudioClip sound;

    /// <summary>
    /// 銃口の位置。
    /// 銃弾を実体化する時の位置や向きの設定などに使用する。
    /// </summary>
    [SerializeField]
    private Transform m_muzzlePos = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// VRコントローラーのトリガーが握られた時に呼び出す。
    /// </summary>
    public void Activate()
	{
        ShootAmmo();
        GetComponent<AudioSource>().PlayOneShot(sound);

    }

    /// <summary>
    /// 銃弾を生成する。
    /// </summary>
    private void ShootAmmo()
	{

        //弾のプレハブか銃口位置が設定されていなければ処理を行わず帰る
        if(m_bulletPrefab == null ||
            m_muzzlePos == null)
		{
            Debug.Log(" Inspector の設定が間違ってる");
            return;
		}

        //弾を生成する。
        GameObject bulletObj = Instantiate(m_bulletPrefab);
        //2秒後に弾を消す。
        Destroy(bulletObj, 2.0f);


        //弾の位置を、銃口の位置と同一にする。
        bulletObj.transform.position = m_muzzlePos.position;

        //弾の向きを、銃口の向きと同一にする。
        bulletObj.transform.rotation = m_muzzlePos.rotation;


    }
}
