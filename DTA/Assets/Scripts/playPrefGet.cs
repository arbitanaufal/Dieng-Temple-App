using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPrefGet : MonoBehaviour
{
    public GameObject CandiArjunaObj, CandiSemarObj, CandiSrikandiObj, CandiPuntadewaObj, CandiSembadraObj, CandiGatotkacaObj;
    int candiArjuna, candiSemar, candiSrikandi, candiPuntadewa, candiSembadra, candiGatotkaca;
    // Start is called before the first frame update
    void Start()
    {
        candiArjuna = PlayerPrefs.GetInt("CandiArjuna");
        candiSemar = PlayerPrefs.GetInt("CandiSemar");
        candiSrikandi = PlayerPrefs.GetInt("CandiSrikandi");
        candiPuntadewa = PlayerPrefs.GetInt("CandiPuntadewa");
        candiSembadra = PlayerPrefs.GetInt("CandiSembadra");
        candiGatotkaca = PlayerPrefs.GetInt("CandiGatotkaca");

        if (candiArjuna == 1)
        {
            CandiArjunaObj.SetActive(true);
        }

        if (candiSemar == 1)
        {
            CandiSemarObj.SetActive(true);
        }

        if (candiSrikandi == 1)
        {
            CandiSrikandiObj.SetActive(true);
        }

        if (candiPuntadewa == 1)
        {
            CandiPuntadewaObj.SetActive(true);
        }

        if (candiSembadra == 1)
        {
            CandiSembadraObj.SetActive(true);
        }

        if (candiGatotkaca == 1)
        {
            CandiGatotkacaObj.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        candiArjuna = PlayerPrefs.GetInt("CandiArjuna");
        candiSemar = PlayerPrefs.GetInt("CandiSemar");
        candiSrikandi = PlayerPrefs.GetInt("CandiSrikandi");
        candiPuntadewa = PlayerPrefs.GetInt("CandiPuntadewa");
        candiSembadra = PlayerPrefs.GetInt("CandiSembadra");
        candiGatotkaca = PlayerPrefs.GetInt("CandiGatotkaca");

        if (candiArjuna == 0)
        {
            CandiArjunaObj.SetActive(false);
        }

        if (candiSemar == 0)
        {
            CandiSemarObj.SetActive(false);
        }

        if (candiSrikandi == 0)
        {
            CandiSrikandiObj.SetActive(false);
        }

        if (candiPuntadewa == 0)
        {
            CandiPuntadewaObj.SetActive(false);
        }

        if (candiSembadra == 0)
        {
            CandiSembadraObj.SetActive(false);
        }

        if (candiGatotkaca == 0)
        {
            CandiGatotkacaObj.SetActive(false);
        }
    }

    public void RESET()
    {
        PlayerPrefs.SetInt("CandiArjuna", 0);
        PlayerPrefs.SetInt("CandiSemar", 0);
        PlayerPrefs.SetInt("CandiSrikandi", 0);
        PlayerPrefs.SetInt("CandiPuntadewa", 0);
        PlayerPrefs.SetInt("CandiSembadra", 0);
        PlayerPrefs.SetInt("CandiGatotkaca", 0);
    }
}
