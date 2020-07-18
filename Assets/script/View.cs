using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    public Controller controller;
    public Model model;

    public void Start()
    {
        controller.ObtenerCodigo(model.text1);
        controller.ObtenerCodigo(model.text2);
        controller.ObtenerCodigo(model.text3);
    }

    private void Update()
    {


        switch (model.choose)
        {
            case 1:
                controller.Aumentar(model.text1);

                break;
            case 2:
                controller.Aumentar(model.text2);

                break;
            case 3:
                controller.Aumentar(model.text3);

                break;
        }
    }
}