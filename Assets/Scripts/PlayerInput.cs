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
    private bool canJump = false;
    public Rigidbody2D body;
    private bool speedReduce = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.W) && canJump)
        {
            canJump = false;
            _playerinput.JumpPlayer();
        }
     



        if (Input.GetKey(KeyCode.A))
        {

            body.linearVelocityX = -75;
            speedReduce = false;
            //if (!Input.GetKey(KeyCode.A))
            //{
            //    speedReduce = true;

            //}
            while (!Input.GetKey(KeyCode.A))
            {
                body.linearVelocityX = body.linearVelocityX / 99;
            }
                

                


        }
        if (Input.GetKey(KeyCode.D))
        {
            body.linearVelocityX = 75;


        }
        if (Input.GetKey(KeyCode.S))
        {
            body.linearVelocityY = -75;
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
    void OnCollisionEnter2D(Collision2D collision)
    {
   if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }

    }
}



