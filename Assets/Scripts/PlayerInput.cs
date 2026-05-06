using System;
using System.Collections.Generic;
using TMPro;
using UnityEditor;


using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] public float _speed = 1;
    [SerializeField] private string _coinTag = "Coin";
    [SerializeField] private string _healthTag = "Health";
    [SerializeField] private TMP_Text _coinText;
    [SerializeField] private string _SpeedUp = "speedUp";
    [SerializeField] private string _SpeedDown = "speedDown";
    [SerializeField] private string _Explosion = "Explosion";
    [SerializeField] private playerinputv2 _playerinput;
    [SerializeField] private UnityEngine.Transform SpawnLocation;
    [SerializeField] private UnityEngine.Transform Hospital;

    private int Coin = 0;
    public int Health = 100;
    public TextMeshProUGUI score;
    public TextMeshProUGUI health;
    private bool canJump = false;
    public Rigidbody2D body;
    private bool speedReduce = false;
    public UnityEvent<Vector2> OnPlayerInputReceived = new UnityEvent<Vector2>();
    public UnityEvent<Vector2> OnPlayerInputReceivedW = new UnityEvent<Vector2>();

    private void Start()
    {
        
        {
            InvokeRepeating("Regenerate", 1.0f, 0.2f);
        }
    }
    void Regenerate()
    {
        if (Health <= 100)
        {
            health.text = "Health: " + Health.ToString();
            Health++;
        }
    }
        void Update()
    {
        if (transform.position.y < -200)
        { health.text = "Health: 100"; Health = 100; transform.position = SpawnLocation.position; }

        if (Health < 1) 
        { health.text = "Health: 100"; Health = 100; transform.position = SpawnLocation.position; }
        
        if (Input.GetKey(KeyCode.W) && canJump)
        {
            canJump = false;
            // OnPlayerInputReceivedW.Invoke(MoveDirection.Up);
            body.linearVelocityY += 200;
        }
   
        if (Input.GetKey(KeyCode.A))
        {

         //   body.linearVelocityX = -75;
         //   speedReduce = false;
            OnPlayerInputReceived.Invoke(Vector2.left);
            //if (!Input.GetKey(KeyCode.A))
            //{
            //    speedReduce = true;
            //}
        }

        if (Input.GetKey(KeyCode.D))
        {
           // body.linearVelocityX = 75;
            OnPlayerInputReceived.Invoke(Vector2.right);
        }

        if (Input.GetKey(KeyCode.S))
        {
            body.linearVelocityY = -400;
            //OnPlayerInputReceived.Invoke(Vector2.down);
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
        if (collision.gameObject.CompareTag(_SpeedDown))
        {
            _speed -= 50;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag(_Explosion))
        {
            body.linearVelocityY = 500;
            Health = Health - 6;
            health.text = "Health: " + Health.ToString();
        }
    
        if (collision.gameObject.CompareTag("Door"))
        {
            SpawnLocation.position = Hospital.position;
            transform.position = Hospital.position;
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




