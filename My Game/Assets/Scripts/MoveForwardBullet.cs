using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardBullet : MonoBehaviour
{
    public float speed = 50;
    private PlayerController playerControllerScript;
    Vector3 tempPos;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.position = new Vector3(transform.position.x, 5, transform.position.z);

            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        
    }
}
