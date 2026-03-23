using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject _Bullet;
    [SerializeField] private Transform _BulletSpawn;
    
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            {
                Instantiate(_Bullet, transform.position, transform.rotation, _BulletSpawn);
                _Bullet.transform.position = transform.position;
                Console.WriteLine("Bullet");
            }

        }
    }
}
