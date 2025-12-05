using System;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    [SerializeField] private string _coinTag = "Coin";
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
            Rigidbody2D.SlideMovement.Equals(transform.position, position);
        }
        if (Input.GetKey(KeyCode.A))
        {

            Vector3 position = new Vector3(0, 0, 0);
            transform.position += new Vector3(-1, 0, 0);



        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 position = new Vector3(0, 0, 0);
            transform.position += new Vector3(1, 0, 0);


        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = new Vector3(0, 0, 0);
            transform.position += new Vector3(0, -1, 0);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(_coinTag))
        { Destroy(collision.gameObject); }
    }
}



