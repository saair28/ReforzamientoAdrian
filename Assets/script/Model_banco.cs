using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEditor.Experimental.AssetImporters;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class Model_banco : MonoBehaviour
{
    public Controller_banco controller;
    public Text PanelIzqui;
    public Text PanelCent;
    public Text PanelDere;
    public bool siguiente = false;
    public int turnos;
    public GameObject espere;

    public void Start()
    {
        turnos = 0;

    }
}
