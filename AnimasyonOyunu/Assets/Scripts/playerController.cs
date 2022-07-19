using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody rb;
    private Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.forward * 2);
        if (Input.GetKeyDown("left") || Input.GetKeyDown("a"))
        {
            transform.position = new Vector3(-2.5f, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown("right") || Input.GetKeyDown("d"))
        {
            transform.position = new Vector3(3f, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown("up") || Input.GetKeyDown("w"))
        {
            playerAnimator.SetTrigger("jump");
            transform.position = new Vector3(this.transform.position.x, 2.5f, this.transform.position.z);
            Invoke("asagiIndir", 0.6f);
        }
    }

    void asagiIndir()
    {
        transform.position = new Vector3(this.transform.position.x, -4.768372e-07f, this.transform.position.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "buyukEngel" || collision.gameObject.tag == "kucukEngel")
        {
            Time.timeScale = 0f;
        }
    }
}
