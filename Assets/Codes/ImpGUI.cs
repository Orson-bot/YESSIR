using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ImpGUI : MonoBehaviour
{
    public string labelText = "Hello";
    private void OnGUI()
    {
        GUI.Box(new Rect(30, 40, 1400, 650), "Change Statistics");

       if (GUI.Button(new Rect(50,100, 100, 100), "Player 1"))
        {
            labelText = "Name : Rastaman\n\rAttack:7642\n\r Defense : 0\n\r Speed:8\n\r Charimsa: 10000000\n\r Influence: 9999999999\n\r Votes: 2890439";

        }
        if (GUI.Button(new Rect(50, 300, 100, 100), "Player 2"))
        {
            print("p2");
            labelText = "Name : Ferdinand Romualdez  Marcos Jr.\n\r Attack:-100000\n\r Defense : 10000000\n\r Speed:-800\n\r Charimsa: -99999999\n\r Influence: 100\n\r Votes: 11700000";

        }
        if (GUI.Button(new Rect(50, 500, 100, 100), "Player 3"))
        {
            print("p3");
            labelText = "Name : Diwata Pares\n\r Attack:77777777\n\r Defense : 8080\n\r Speed:99999999\n\r Charimsa: 9975763\n\r Influence: 1100010\n\r Votes: 10987";
        }
        GUI.Label(new Rect(500, 100, 200, 300), labelText);
    }
}
