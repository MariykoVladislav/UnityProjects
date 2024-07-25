using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notification : MonoBehaviour
{
    public GameObject NotificationPanel;

    public void Ok()
    {
        NotificationPanel.SetActive(false);
        Time.timeScale = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            NotificationPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
