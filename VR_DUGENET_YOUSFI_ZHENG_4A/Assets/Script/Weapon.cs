using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(XRGrabInteractable))]

public class Weapon : MonoBehaviour
{
    public float shootingForce;
    public float recoilForce;
    public Transform bulletSpawn;
    public float damage;
    public PlayerManager player;

    private Rigidbody rb;
    private XRGrabInteractable interactableWeapon;
    
    protected virtual void Awake()
    {
        interactableWeapon = GetComponent<XRGrabInteractable>();
        rb = GetComponent<Rigidbody>();
        SetupInteractableWeaponEvents();
    }

    private void SetupInteractableWeaponEvents()
    {
        interactableWeapon.selectEntered.AddListener(PickUpWeapon);
        interactableWeapon.selectExited.AddListener(DropWeapon);
        interactableWeapon.activated.AddListener(StartShooting);
        interactableWeapon.deactivated.AddListener(StopShooting);
    }

    private void PickUpWeapon(SelectEnterEventArgs interactor)
    {
        //cacher les mains lorsqu'on grab l'arme?
        //interactor.GetComponent<MeshHidder>().Hide();
    }
 
    private void DropWeapon(SelectExitEventArgs interactor)
    {
        //interactor.GetComponent<MeshHidder>().Show();
    }

    protected virtual void StartShooting(ActivateEventArgs interactor)
    {

    }

    protected virtual void StopShooting(DeactivateEventArgs interactor)
    {

    }

    protected virtual void Shoot()
    {
        ApplyRecoil();
    }

    private void ApplyRecoil()
    {
        rb.AddRelativeForce(Vector3.back * recoilForce, ForceMode.Impulse);
    }

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
