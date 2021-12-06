using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;

    private void Start()
    {
        gameOverCanvas.enabled = false;
    }

    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        // Stops time
        Time.timeScale = 0;
        // Make cursor not locked and visible
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
