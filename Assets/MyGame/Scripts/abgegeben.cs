using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abgegeben : MonoBehaviour
{
    [SerializeField]
    Gamemanager manager;
    [SerializeField]
    CarControl car;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (manager.collected == true)
        {
            manager.collected = false;
            manager.score++;
        }
    }
}
