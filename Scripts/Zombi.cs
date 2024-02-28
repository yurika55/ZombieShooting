using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zombi : MonoBehaviour
{
    Animator animator;
    public float destroyTime = 1.0f;
    GameObject player;
    public float rangedistance = 0.5f;
    public float gameoverTime = 1.0f;

    public bool CanWalk { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");

        CanWalk = true;
    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤーの位置
        var playerPosition = player.transform.position;
        //ゾンビの位置
        var zombiPosition = transform.position;
        //ゾンビとプレイヤーがどれだけ離れているか
        //var offset = Mathf.Abs(playerPosition.x - zombiPosition.x);
        var offset = Vector3.Distance(playerPosition, zombiPosition);
        // プレイヤーとゾンビの距離が近くなったら攻撃
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
            
            //ゾンビが倒れる
            FallDown();

        }
    }

     void Attack()
    {
        // 攻撃するアニメーションを流す
        animator.SetTrigger("Attack");

        //ゲームオーバー場面に移動する
        Invoke("Gameover", gameoverTime);
    
    }

    void FallDown()
    {
        //動きを止める
        CanWalk = false;

        //倒れるアニメーションを流す
        animator.SetTrigger("FallDown");

        //ゾンビを消す
        Invoke("DestroyZombi", destroyTime);

    }

    
     void Gameover()
    {
         SceneManager.LoadScene("GameOver");
    }

    void DestroyZombi()
    {
        Destroy(gameObject);
    }

}
