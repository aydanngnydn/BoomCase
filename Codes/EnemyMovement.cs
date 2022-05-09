using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody enemyRB;
    public GameObject target;
    public PlayerManager playerscript;
    Vector3 directionToTarget;
    public float speed;

    void Start()
    {
        target = GameObject.Find("Witch");
        playerscript = GameObject.Find("Witch").GetComponent<PlayerManager>();
        enemyRB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Follow();
    }

    void Follow()//enemies follow witch right after they spawn
    {
        if(!playerscript.isdead)
        {
        Vector3 pos = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.fixedDeltaTime);
        enemyRB.MovePosition(pos);
        transform.LookAt(target.transform);
        }
        else
        {
            enemyRB.velocity = Vector3.zero;
        }
    }
}
