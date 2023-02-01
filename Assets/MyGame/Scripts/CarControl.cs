using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{

    public float movSpeed, mov;
    public float rotSpeed, rot;
    public Rigidbody rb;
    [SerializeField]
    GameObject cam;
    [SerializeField]
    GameObject car;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rot = Input.GetAxis("Horizontal") * rotSpeed;
        mov = Input.GetAxis("Vertical") * movSpeed;

        transform.Translate(0, mov, 0);
        transform.Rotate(0, 0, -rot);

        //rb.AddForce(Vector2.up * movSpeed);
        //rb.AddForce(Vector2.up * movSpeed);
    }

    private void LateUpdate()
    {
        cam.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -5);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
    }
}
