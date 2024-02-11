using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour
{
    public Transform shellSpawnPoint;
    public GameObject shellPrefab;
    public int maxShells = 1;
    private int currentShells = 0;
    private bool canFire = false;

    void OnTriggerEnter(Collider getShell)
    {
        if (getShell.gameObject.tag == "ItemBox")
        {
            if (currentShells < maxShells)
            {
                currentShells++;

                //Debug.Log("Shell Lock and Loaded!");

                canFire = true;
            }
        }
    }

    void Update()
    {
        if (canFire && Input.GetKeyDown(KeyCode.Space))
        {
            FireShell();
        }
    }

    void FireShell()
    {
        Vector3 forwardDirection = transform.forward;

        GameObject shell = Instantiate(shellPrefab, shellSpawnPoint.position, Quaternion.identity);
        shell.transform.Rotate(90f, 0f, 0f, Space.Self);
            
        Rigidbody shellRigidbody = shell.GetComponent<Rigidbody>();

        // Apply a force in the forward direction
        if (shellRigidbody != null)
        {
            float shellSpeed = 30f; // Adjust the speed as needed
            shellRigidbody.AddForce(forwardDirection * shellSpeed, ForceMode.VelocityChange);
        }

        
        currentShells--;

        //Debug.Log("PEW PEW! Shells: " + currentShells);

        canFire = (currentShells > 0);
    }
}
