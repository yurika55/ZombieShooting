using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent; // NavMeshAgentコンポーネントを格納する変数
    GameObject player; // プレイヤーオブジェクトを格納する変数
    Zombi zombi; // Zombiスクリプトを格納する変数

    void Start()
    {
       agent = GetComponent<UnityEngine.AI.NavMeshAgent>(); // NavMeshAgentコンポーネントを取得してagent変数に代入
       player = GameObject.FindWithTag("Player"); // "Player"タグが付いたオブジェクトを検索してplayer変数に代入
        zombi = GetComponent<Zombi>(); // Zombiスクリプトを取得してzombi変数に代入
    }

    void Update()
    {
        // もしゾンビが歩ける状態ならば
        if(zombi.CanWalk)
        {
            // ゾンビの目標地点をプレイヤーの位置に設定する
            agent.destination = player.transform.position;
        }
        else // もしゾンビが歩けない状態ならば
        {
            // NavMeshAgentを停止する
            agent.isStopped = true;
        }
    }
}
