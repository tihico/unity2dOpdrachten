using UnityEngine;

public class playerinputv2 : MonoBehaviour
{
    [SerializeField] private float _speed= 50;
    [SerializeField] private Rigidbody2D _rb;
   // [SerializeField] private float _jumpforce = 100;
    [SerializeField] private PlayerInput _playerInput;


    private void Start()
    {
        _playerInput.OnPlayerInputReceived.AddListener(MovePlayer);
         // _rb.OnPlayerInputReceivedW.AddListener(JumpPlayer);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void MovePlayer(Vector2 direction)
    {
        transform.position += new Vector3(direction.x, direction.y, 0) * _speed * Time.deltaTime;
    }
    public void JumpPlayer()
    {
      //  _rb.linearVelocityY += _jumpforce;
    }
}
