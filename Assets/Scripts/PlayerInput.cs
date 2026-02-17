using System;
using TMPro;
using UnityEditor;
using UnityEditor.Rendering;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    [SerializeField] private string _coinTag = "Coin";
    [SerializeField] private TMP_Text _coinText;
    [SerializeField] private string _SpeedUp = "speedUp";
    [SerializeField] private string _SpeedDown = "speedDown";
    [SerializeField] private playerinputv2 _playerinput;
    private int Coin = 0;
    public TextMeshProUGUI score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.W))
        {
            _playerinput.MovePlayer(Vector2.up);

            
           // Vector3 position = new Vector3(0, 0, 0);
           // transform.position += new Vector3(0, 1* _speed, 0);
            // Rigidbody2D.SlideMovement.Equals(transform.position, position);
        }
        if (Input.GetKey(KeyCode.A))
        {

            Vector3 position = new Vector3(0, 0, 0);
            transform.position += new Vector3(-1*_speed, 0, 0);



        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 position = new Vector3(0, 0, 0);
            transform.position += new Vector3(1*_speed, 0, 0);


        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = new Vector3(0, 0, 0);
            transform.position += new Vector3(0, -1*_speed, 0);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        secondspeedscript Speedup;

        if (collision.gameObject.CompareTag(_coinTag))
        {
            Destroy(collision.gameObject);
            Coin++;
            score.text = "Score: " + Coin.ToString();
        }
        if (collision.gameObject.CompareTag(_SpeedUp) && collision.gameObject.TryGetComponent<secondspeedscript>(out Speedup))
        {
            _speed += Speedup.GetSpeedValue();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag(_SpeedDown))
        {





        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
   

    }
}



