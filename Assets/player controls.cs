using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformrotatiion : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        const float speed = 0.01f;
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed);

        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(transform.up * 5, ForceMode.Impulse);
        }
            if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 bullet_spawn_point = new Vector3(transform.position.x, transform.position.y, transform.position.z+ 1.26f);
            GameObject newObject = Instantiate(bullet, bullet_spawn_point, transform.rotation);
        }

    }
}
