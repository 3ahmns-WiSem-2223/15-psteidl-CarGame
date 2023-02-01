using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item6 : MonoBehaviour
{
    [SerializeField]
    Gamemanager manager;
    [SerializeField]
    CarControl car;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (car.movSpeed >= 0.75f)
        {
            car.movSpeed = 0.75f;
        }
        if (manager.itemspawning7 == true)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        car.movSpeed += 0.005f;
        manager.itemspawning1 = true;
    }
}
