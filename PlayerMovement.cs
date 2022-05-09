using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] float movementSpeed;
    public PlayerManager playerscript;

    void Update()
    {
        if(playerscript.isGameStarted){
        transform.Translate(new Vector3(0,0, movementSpeed * Time.deltaTime));
        }
    }
}
