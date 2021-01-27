using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuUtama()
    {
        SceneManager.LoadScene(0);
    }

    public void CandiArjuna()
    {
        SceneManager.LoadScene(1);
    }

    public void CandiSemar()
    {
        SceneManager.LoadScene(2);
    }

    public void CandiSrikandi()
    {
        SceneManager.LoadScene(3);
    }

    public void CandiPuntadewa()
    {
        SceneManager.LoadScene(4);
    }

    public void CandiSembadra()
    {
        SceneManager.LoadScene(5);
    }

    public void CandiGatotkaca()
    {
        SceneManager.LoadScene(6);
    }
}
