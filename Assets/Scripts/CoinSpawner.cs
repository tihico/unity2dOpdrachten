using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.FilePathAttribute;


public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private List<Transform> _coinSpawnLocations;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (Transform location in _coinSpawnLocations){
            Instantiate(_coinPrefab, location.position, location.rotation);
        }
        Destroy(this.gameObject);
    }
}