using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    [SerializeField] private Camera dropPoint;

    public GameObject correctForm, nextCF, CameraMovement, TemplePart, InvIMG;

    private bool moving, finish;

    private float startPosX, startPosY, startPosZ;

    private Vector3 resetPosition;

    void Start()
    {
        resetPosition = TemplePart.transform.localPosition;
    }
    void Update()
    {
        if (finish == false)
        {
            if (moving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = dropPoint.ScreenToWorldPoint(mousePos);

                TemplePart.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, mousePos.z);
            } 
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CameraMovement.SetActive(false);
            TemplePart.SetActive(true);
            InvIMG.SetActive(false);

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x = correctForm.transform.localPosition.x;
            startPosY = mousePos.y = correctForm.transform.localPosition.y;
            startPosZ = mousePos.z = correctForm.transform.localPosition.z;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        CameraMovement.SetActive(true);
        TemplePart.SetActive(false);
        InvIMG.SetActive(true);
        moving = false;

        if ((correctForm.activeInHierarchy == true) && 
            Mathf.Abs(TemplePart.transform.localPosition.x - correctForm.transform.localPosition.x) <= 0.25f &&
            Mathf.Abs(TemplePart.transform.localPosition.y - correctForm.transform.localPosition.y) <= 0.25f &&
            Mathf.Abs(TemplePart.transform.localPosition.z - correctForm.transform.localPosition.z) <= 0.25f)
        {
            TemplePart.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            TemplePart.gameObject.GetComponent<Collider>().enabled = false;
            finish = true;
            nextCF.SetActive(true);
            TemplePart.SetActive(true);
            InvIMG.SetActive(false);
        }
        else
        {
            TemplePart.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }
    }
}
