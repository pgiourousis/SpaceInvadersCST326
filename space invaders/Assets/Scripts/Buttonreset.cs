using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonreset : MonoBehaviour
{
    public void butotnReset()
    {
        SceneManager.LoadScene(1);
    }
}