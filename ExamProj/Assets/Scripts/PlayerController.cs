using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject Menu_Panel;
    
    private Rigidbody rb;

    public float speedPlayer = 10f;
    public float JumpForce = 20f;
   
    private bool isGrounded;
    public static bool isPaused;
    public static bool isDead = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Time.timeScale = 1;
    }

    void Update()
    {
        Move();
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.Escape) && !isDead)
        {
            if (!isPaused)
            {
                Pause();
                isPaused = true;
            }
            else
            {
                Resume();
                isPaused = false;
            }
            
        }
    }

    public void Pause()
    {
        Menu_Panel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Menu_Panel.SetActive(false);
        Time.timeScale = 1;
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(x, 0.0f, z);

        transform.Translate(movement * speedPlayer * Time.deltaTime);
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        isGrounded = false;
        Debug.Log("Jump");
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("isGrounded = true");
        }
    }
}
