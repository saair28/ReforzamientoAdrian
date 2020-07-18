using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Model : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;

    public int choose;
    private void Awake()
    {
        choose = 1;
    }
}