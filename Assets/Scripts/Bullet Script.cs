using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject _Bullet;
    [SerializeField] private Transform _BulletSpawn;
    public int distanceFromCamera = 10;
    private void Update()
    {
        var pos = Camera.main.WorldToScreenPoint(transform.position);
        var dir = Input.mousePosition - pos;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            {
                Instantiate(_Bullet, transform.position, transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward));
                Console.WriteLine("Bullet");
            }

        }
    }
}
