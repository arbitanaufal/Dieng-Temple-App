using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playPref : MonoBehaviour
{
    public void SaveArjuna()
    {
        PlayerPrefs.SetInt("CandiArjuna", 1);
    }

    public void SaveSemar()
    {
        PlayerPrefs.SetInt("CandiSemar", 1);
    }

    public void SaveSrikandi()
    {
        PlayerPrefs.SetInt("CandiSrikandi", 1);
    }

    public void SavePuntadewa()
    {
        PlayerPrefs.SetInt("CandiPuntadewa", 1);
    }

    public void SaveSembadra()
    {
        PlayerPrefs.SetInt("CandiSembadra", 1);
    }

    public void SaveGatotkaca()
    {
        PlayerPrefs.SetInt("CandiGatotkaca", 1);
    }
}
