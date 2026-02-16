using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class speedboost : MonoBehaviour
{
    [SerializeField] private string _speedboost = "speedboost";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.W))
        {



            Vector3 position = new Vector3(0, 0, 0);
            transform.position += new Vector3(0, 1, 0);
         
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
       
        {
            
            
        }
    }
}


    
        

