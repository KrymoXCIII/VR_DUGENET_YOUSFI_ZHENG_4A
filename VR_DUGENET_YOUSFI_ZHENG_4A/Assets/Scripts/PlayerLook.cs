using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;

    private float _xRotation = 0f;

    public float xSensitivity = 30f;

    public float ySensitivity = 30f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        
        // Calculate camera rotation for looking up and down

        _xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        _xRotation = Mathf.Clamp(_xRotation, -80f, 80f);
        
        // Apply to camera transform
        
        cam.transform.localRotation = Quaternion.Euler(_xRotation,0,0);
        
        // Rotate Player to look left ands right 
        
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime * xSensitivity));
        

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}