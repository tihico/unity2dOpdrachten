using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.W))
        {


            Console.WriteLine("ik heb W ingeclickt");
            Vector3 position = new Vector3(0, 0, 0);
            transform.position += new Vector3(0, 1, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            
            Vector3 position = new Vector3(0, 0, 0);
            transform.position += new Vector3(-1, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            

        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 position = new Vector3(0, 0, 0);
            transform.position += new Vector3(1, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = new Vector3(0, 0, 0);
            transform.position += new Vector3(0, -1, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}

