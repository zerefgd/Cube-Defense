using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 720f;
    public Transform spawnPoint;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, speed * Time.deltaTime * Input.GetAxis("Horizontal"), 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Finish"))
        {
            Destroy(other.gameObject);
            GameManager.instance.EndGame();
        }
    }
}
