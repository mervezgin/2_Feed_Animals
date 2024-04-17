using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Player"))
        {
            Debug.Log("Animal hit the player and GAME OVER!");
        }
    }
}
