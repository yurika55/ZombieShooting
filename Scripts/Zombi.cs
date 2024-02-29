using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zombi : MonoBehaviour
{
    Animator animator; // ゾンビのアニメーターコンポーネント
    public float destroyTime = 1.0f; // ゾンビが倒れてから消えるまでの時間
    GameObject player; // プレイヤーオブジェクト
    public float rangedistance = 0.5f; // ゾンビが攻撃を開始するプレイヤーとの距離
    public float gameoverTime = 1.0f; // 攻撃後、ゲームオーバー画面に遷移するまでの時間

    public bool CanWalk { get; private set; } // ゾンビが歩けるかどうか

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); // アニメーターコンポーネントを取得
        player = GameObject.FindWithTag("Player"); // プレイヤーオブジェクトを検索して取得

        CanWalk = true; // 初期状態ではゾンビは歩ける
    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤーの位置
        var playerPosition = player.transform.position;
        // ゾンビの位置
        var zombiPosition = transform.position;
        // ゾンビとプレイヤーがどれだけ離れているかを計算
        var offset = Vector3.Distance(playerPosition, zombiPosition);
        // プレイヤーとゾンビの距離が攻撃範囲内に入ったら攻撃
        if(offset <= rangedistance)
        {
            Attack();
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            // 弾を消す
            Destroy(collision.gameObject);
            
            // ゾンビが倒れる処理
            FallDown();
        }
    }

    void Attack()
    {
        // 攻撃するアニメーションを実行
        animator.SetTrigger("Attack");

        // ゲームオーバー画面に移行する
        Invoke("Gameover", gameoverTime);
    }

    void FallDown()
    {
        // 動きを止める（歩けなくする）
        CanWalk = false;

        // 倒れるアニメーションを実行
        animator.SetTrigger("FallDown");

        // ゾンビを指定時間後に消去
        Invoke("DestroyZombi", destroyTime);
    }

    void Gameover()
    {
        // ゲームオーバー画面に遷移
        SceneManager.LoadScene("GameOver");
    }

    void DestroyZombi()
    {
        // オブジェクトを破棄してゾンビを消す
        Destroy(gameObject);
    }
}
