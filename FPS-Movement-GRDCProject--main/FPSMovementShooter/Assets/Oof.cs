using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oof : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;
    }

    // Update is called once per frame
   
}
