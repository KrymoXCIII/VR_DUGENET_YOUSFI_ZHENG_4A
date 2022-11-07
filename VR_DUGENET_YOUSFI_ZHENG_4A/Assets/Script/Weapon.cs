using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(Rigidbody))]
//[RequireComponent(typeof(XRGrabInteractable))]

public class Weapon : MonoBehaviour
{
    public float shootingForce;
    public float recoilForce;
    public Transform bulletSpawn;
    public float damage;

    private Rigidbody rb;
    //private XRGrabInteractable interactableWeapon;

    public void shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }
}
