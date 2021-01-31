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

    public void OnMouseDown()
    {
        CameraMovement.SetActive(false);
    }

    public void OnMouseUp()
    {
        CameraMovement.SetActive(true);
    }
}
