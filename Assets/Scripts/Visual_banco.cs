using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Visual_banco : MonoBehaviour
{
    public Model_banco model;
    public Controller_banco controller;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        if (model.esconde == true)
        {
            model.espere.SetActive(true);
        }
        else
        {
            model.espere.SetActive(false);
        }
    }
    public void Siguiente()
    {
        model.siguiente = true;
    }
    
}
