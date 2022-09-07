using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    private CharacterController characterController;
    // private bool isPowerUp = false;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        characterController.Move(movement * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PowerUp")
        {
            Debug.Log("Player Power Up");
            // isPowerUp = true;
        }

        /*
        if (collision.gameObject.tag == "Enemy")
        {
            if (isPowerUp == false)
            {
                Debug.Log("Player lose 1 life");
            }
            else
            {
                Debug.Log("Enemy ate by Player");
            }
        }
        */
    }
}
