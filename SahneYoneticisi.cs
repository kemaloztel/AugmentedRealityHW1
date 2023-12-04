using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneYoneticisi : MonoBehaviour
{
    public void kaplanlar(){
        SceneManager.LoadScene("Sahne1");
    }

    public void kemal(){
        SceneManager.LoadScene("Sahne2");
    }

    public void sanalButonlar(){
        SceneManager.LoadScene("Sahne3");
    }
}
