using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    public int Health = 1000;
    public TextMeshPro health;
    [SerializeField] private string _Bullet = "Bullet";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // boss death
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadSceneAsync("End");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(_Bullet))
        {
            // damage from bullets
            Health = Health - 100;
            health.text = "Health: " + Health.ToString();

        }
       
    }
}
