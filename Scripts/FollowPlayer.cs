using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    GameObject player;
    Zombi zombi;

    // Start is called before the first frame update
    void Start()
    {
       agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
       player = GameObject.FindWithTag("Player");
        zombi = GetComponent<Zombi>();
    }

    // Update is called once per frame
    void Update()
    {
        if(zombi.CanWalk)
        {
            //ゾンビがプレイヤーの方に向かっていく
            agent.destination = player.transform.position;
        }
        else
        {
            agent.isStopped = true;
        }
    }
}
