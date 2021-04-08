using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform spawnPoint;
    


     void OnTriggerEnter(Collider other)
    {
        player.transform.position = spawnPoint.transform.position;
    }
}
