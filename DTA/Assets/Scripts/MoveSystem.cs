using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    public GameObject correctForm;
    public GameObject CameraMovement;
    public GameObject TemplePart;
    private bool moving;

    private float startPosX;
    private float startPosY;
    private float startPosZ;

    private Vector3 resetPosition;

    void Start()
    {
        resetPosition = this.transform.localPosition;
    }
    void Update()
    {
        if (moving)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, mousePos.z - startPosZ);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CameraMovement.SetActive(false);
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x -2.5f;
            startPosY = mousePos.y - this.transform.localPosition.y;
            startPosZ = mousePos.z - this.transform.localPosition.z -2.5f;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;
        CameraMovement.SetActive(true);

        if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 10.0f &&
            Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 0.6f &&
            Mathf.Abs(this.transform.localPosition.z - correctForm.transform.localPosition.z) <= 10.0f)
        {
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            TemplePart.gameObject.GetComponent<Collider>().enabled = false;
        }
        else
        {
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }
    }
}
