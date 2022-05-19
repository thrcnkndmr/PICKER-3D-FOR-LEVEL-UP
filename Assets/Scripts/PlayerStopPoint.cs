using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStopPoint : MonoBehaviour

{
    PlayerController player;
    
    private void OnEnable()
    {
        player = PlayerController.instance;
        player.isLevelDone = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        player.isLevelDone = true;

    }
}
