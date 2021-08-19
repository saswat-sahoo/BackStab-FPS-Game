using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
  public float mouseSensitivity = 10f;
  
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // binding camera to player
         transform.position = player.position + offset;
         //adding camera movement with mouse
         float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
         float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
         Vector3 rotPlayer = player.transform.rotation.eulerAngles;
         rotPlayer.x += mouseY;
         rotPlayer.z = 0;
         rotPlayer.y += mouseX;
         player.rotation = Quaternion.Euler(rotPlayer);

    }
}
