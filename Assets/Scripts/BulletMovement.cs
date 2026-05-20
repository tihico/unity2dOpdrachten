using UnityEngine;
using UnityEngine.UIElements;


public class BulletMovement : MonoBehaviour


{
    [SerializeField] private GameObject _Explosion;
    [SerializeField] private int _SpeedValue;
    void Update()
    {
        transform.Translate(Vector3.up * _SpeedValue * Time.deltaTime);


        if (transform.position.x < -20000 || transform.position.y < -20000 || transform.position.x > 20000 || transform.position.y > 20000)
        {
            {
                Destroy(gameObject);
            }
        }
    }
            private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Instantiate(_Explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Untagged"))
        {
            Instantiate(_Explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Boss"))
        {
            Instantiate(_Explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }




    }
}
        