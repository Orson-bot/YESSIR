using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newcode : MonoBehaviour
{
    private bool togglebool = true;

    private void OnGUI()
    {
        togglebool = GUI.Toggle(new Rect(25, 25, 100, 30), togglebool, "toggle");
        if (togglebool)
            Debug.Log("toggleBool is true");
        else
            Debug.Log("toggleBool is false");
    }
}
