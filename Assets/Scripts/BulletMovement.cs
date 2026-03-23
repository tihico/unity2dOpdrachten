using UnityEngine;
using UnityEngine.UIElements;

public class BulletMovement : MonoBehaviour
{
    
    void Update()
    {
        transform.position += Vector3.right * 200 * Time.deltaTime;
    }
}
