using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Bullet(GameObject Bullet)
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Instantiate(Bullet.gameObject);
            Console.WriteLine("Bullet");
        }
    }
}
