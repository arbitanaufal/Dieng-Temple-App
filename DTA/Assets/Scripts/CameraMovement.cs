using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Camera cam; //Cam = Jenis object //cam = nama object
    [SerializeField] private Transform target; //Transform = Jenis Object //target = nama object

    private Vector3 oldPosition; //private = variable //Vector3 = jenis variable //oldPosition = nama variable

    void Update()//Update berlangsung setiap saat terjadi perubahan
    {
        if (Input.GetMouseButtonDown(0)) //Input.GetMouseButtonDown = Ditekan // (0) = Left click (1) = Right click
        {
            oldPosition = cam.ScreenToViewportPoint(Input.mousePosition); //Posisi vector3(x,y,z) = kamera sesuai point tekanan jari menurut Viewport Point 
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 newPosition = cam.ScreenToViewportPoint(Input.mousePosition); //newPosition = nama variable posisi baru //newPosition = kamera sesuai point tekanan jari menurut Viewport Point
            Vector3 direction = oldPosition - newPosition; //arah Vector3 = oldPosition - newPosition

            float rotationAroundYAxis = -direction.x * 180; 

            cam.transform.position = target.position;

            cam.transform.Rotate(new Vector3(0, 1, 0), rotationAroundYAxis, Space.World);

            cam.transform.Translate(new Vector3(0, 0, 0));

            oldPosition = newPosition;
        }
    }
}
