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
            transform.position = new Vector3(0, 0, 0);
            transform.rotation = Quaternion.Euler(0, 5, 0);
            transform.localScale += new Vector3(1, 1, 1);
            
        }
    }
}
