using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;

    // change the skin width to min Value seems solved the problem of collision detect between player and enemy
    private CharacterController characterController;
    private bool isPowerUp = false;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        characterController.Move(move * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" && !isPowerUp)
        {
            Debug.Log("Enemy touch!");
        }

        if (collision.gameObject.tag == "Powerup")
        {
            Debug.Log("Power Up!");

            foreach (GameObject g in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                g.SendMessage("BeFreezed");

                float timer = 0;

                while (timer <= 5)
                {
                    timer += Time.deltaTime;
                    isPowerUp = true;
                }

                isPowerUp = false;
            }
        }
    }
}
