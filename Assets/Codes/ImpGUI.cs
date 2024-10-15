
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq.Expressions;
public class ImpGUI : MonoBehaviour
{

    public string text = "Stat check bro";
    private int agep1 = 127;
    private int attackp1 = 1001;
    private int defp1 = 23;
    private int votesp1 = 102300;


    private int agep2 = 666;
    private int attackp2 = 0;
    private int defp2 = 82;
   private int votesp2 = 1300;

    private int agep3 = 56;
    private int attackp3 = 13213;
    private int defp3 = 2000;
    private int votesp3 = 30112;

    private void OnGUI()
    {
        GUI.Box(new Rect(227, 120, 995, 400), "Options");

        if (GUI.Button(new Rect(260, 145, 90, 80), "Player One"))
        {
            print("Player One");
            text = $"Name: Diwata Pares \r\n Race : Filipino \r\n Age: {agep1} \r\n Attack : {attackp1} \r\n DEFENSE : {defp1} \r\n Votes : {votesp1}";
        }
        if (GUI.Button(new Rect(260, 275, 90, 80), "Player Two"))
        {
            print("pTwo");
            text = $"Name: BBM \r\n Race : Aien \r\n Age: {agep2} \r\n Attack : {attackp2} \r\n DEFENSE : {defp2} \r\n Votes : {votesp2}"; 
        }
        if (GUI.Button(new Rect(260, 415, 90, 80), "Player Three"))
        {
            print("pThree");
            text = $"Name: Rastaman \r\n Race : SuperHuman \r\n Age: {agep3} \r\n Attack : {attackp3} \r\n DEFENSE : {defp3} \r\n Votes : {votesp2}"; 
        }

        GUI.Label(new Rect(750, 250, 200, 200), text);
    }


}
