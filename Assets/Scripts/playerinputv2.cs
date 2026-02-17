using UnityEngine;

public class playerinputv2 : MonoBehaviour
{
    [SerializeField] private float _speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void MovePlayer(Vector2 direction)
    {

        transform.position += new Vector3(direction.x, direction.y, 0) * _speed * Time.deltaTime;
    }
}
