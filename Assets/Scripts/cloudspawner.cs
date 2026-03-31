using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CloudSpawner : MonoBehaviour
{
    
    [SerializeField] private GameObject _Cloud;
    [SerializeField] private Transform _CloudSpawn;
    
    
    void Start()
    {
        InvokeRepeating(nameof(Projectile), 0.0f, 5.0f);
    }
    void Projectile()
    {
        float randomY = Random.Range(180, 260);

        Vector3 spawnPos = new Vector3(transform.position.x, randomY, transform.position.z);

        Instantiate(_Cloud, spawnPos, transform.rotation);

        
            
        }
    
        
        
    }


