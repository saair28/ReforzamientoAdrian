using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEditor.Experimental.AssetImporters;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class Model_banco : MonoBehaviour
{

    public Text PanelIzqui;
    public Text PanelCent;
    public Text PanelDere;
    public int contPanel;
    public int turnos;
    public bool siguiente = false;
    public int a;
    public int b;
    public int c;
    public GameObject espere;

    public void Start()
    {
        turnos = 0;

        espere.SetActive(false);

    }

    public void Update()
    {

    }
}
