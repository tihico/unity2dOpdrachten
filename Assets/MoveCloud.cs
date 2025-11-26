using UnityEngine;

public class movecloud : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(0, 0, 0);
        transform.position += new Vector3(1, 0, 0);


        if (transform.position.x > 200000)
        {
            { 
                transform.position = new Vector3(-215, 99, 0);
            }
        }
    }
}

