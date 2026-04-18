using UnityEngine;
using UnityEngine.UIElements;

public class BulletMovement : MonoBehaviour

{
    [SerializeField] private GameObject _speed;
    void Update()
    {
        transform.Translate(Vector3.up * 200 * Time.deltaTime);


        if (transform.position.x < -5000 || transform.position.y < -5000 || transform.position.x < 5000 || transform.position.y < 5000 )
        {
            {
                //Destroy(gameObject);
            }
        }
    }
}