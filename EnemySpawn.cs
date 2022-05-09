using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public PlayerManager playerscript;
    public GameObject enemyPrefab;
    public GameObject[] enemies;
    public float place, difference, second;
    bool first = true;

    private void Update()
    {
       if(!playerscript.isdead && playerscript.isGameStarted && first)
        {StartCoroutine(Spawn());
        first = false;
        }
    }

    public IEnumerator Spawn()
    {
        enemies = new GameObject[5];

        while(!playerscript.isdead && playerscript.isGameStarted){//enemies spawn on the platform after game starts
            for(int i = 0; i < enemies.Length; i++)
            {
                GameObject clone = (GameObject)Instantiate(enemyPrefab, new Vector3(Random.Range(-place, place), 0, (playerscript.transform.position.z + difference)), Quaternion.identity);
                enemies[i] = clone;
            }
            yield return new WaitForSeconds(second);
        }
    }
}
