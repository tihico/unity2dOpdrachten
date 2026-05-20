using UnityEngine;

public class bossheal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
       //     Boss boss = Boss

         //   if (Health >=  0)
            {
                
         //       boss.Health(10000);
            }
        }
    }
}
