using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    public GameObject Death_Panel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController.isDead = true;
            Death_Panel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
