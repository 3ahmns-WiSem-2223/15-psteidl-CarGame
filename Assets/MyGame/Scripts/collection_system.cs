using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collection_system : MonoBehaviour
{
    [SerializeField]
    Gamemanager manager;

    private void Start()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (manager.collected == false)
        {
            manager.collected = true;
            Object.Destroy(gameObject);
        }
    }
}
