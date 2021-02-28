using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CArjunaTest : MonoBehaviour
{
    public GameObject CAPanel;
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
            CAPanel.SetActive(true);
        }
    }

    public void CAPanelOff()
    {
        CAPanel.SetActive(false);
    }
}
