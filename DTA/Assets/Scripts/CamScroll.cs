using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScroll : MonoBehaviour
{
    public GameObject CameraMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CameraMovement.SetActive(false);
        }
    }

    private void OnMouseUp()
    {
        CameraMovement.SetActive(true);
    }
}
