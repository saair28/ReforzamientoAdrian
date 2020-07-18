using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public Model model;
    public void ObtenerCodigo(Text text)
    {
        text.text = text.GetComponent<Texto>().name + text.GetComponent<Texto>().codigo;
    }

    public void Aumentar(Text text)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            model.choose = Random.Range(1, 4);
            text.GetComponent<Texto>().codigo++;
            text.text = text.GetComponent<Texto>().name + text.GetComponent<Texto>().codigo;
            Debug.Log(model.choose);
        }

    }
}
