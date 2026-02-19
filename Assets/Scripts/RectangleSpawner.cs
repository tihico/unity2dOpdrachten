using System.Collections.Generic;
using UnityEngine;

public class RectangleSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject _RectanglePrefab;
    [SerializeField] private List<Transform> _RectangleSpawnLocations;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (Transform location in _RectangleSpawnLocations)
        {
            Instantiate(_RectanglePrefab, location.position, location.rotation);
        }
        Destroy(this.gameObject);
    }
}
