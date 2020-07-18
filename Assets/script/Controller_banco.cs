using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Controller_banco : MonoBehaviour
{
    //es una idea pero no funciona
    public Model_banco model;
    public Visual_banco visual;
    public int a;
    public int b;
    public int c;
    public bool esconde = false;

    public void update()
    {
        if (model.siguiente == true)
        {
            model.turnos = model.turnos + 1;

            if (model.turnos == 1)
            {
                a = a + 1;

                esconde = false;

                if (a == 1)
                {
                    model.PanelIzqui.text = "DF18";
                }

                if (a == 2)
                {
                    model.PanelIzqui.text = "PO32";
                }

                if (a == 3)
                {
                    model.PanelIzqui.text = "AT23";

                    a = 0;
                }
            }

            if (model.turnos == 2)
            {
                b = b + 1;

                esconde = false;

                if (b == 1)
                {
                    model.PanelCent.text = "OT48";
                }

                if (b == 2)
                {
                    model.PanelCent.text = "ET6";
                }

                if (b == 3)
                {
                    model.PanelCent.text = "MV34";

                    b = 0;
                }
            }

            if (model.turnos == 3)
            {
                c = c + 1;

                esconde = false;

                if (c == 1)
                {
                    model.PanelDere.text = "TY8";
                }

                if (c == 2)
                {
                    model.PanelDere.text = "LO1";
                }

                if (c == 3)
                {
                    model.PanelDere.text = "UO9";

                    c = 0;
                }
            }

            if (model.turnos >= 4)
            {
                model.turnos = 0;

                esconde = true;
            }

            model.siguiente = false;
        }
    }
        public void Siguiente()
        {
            model.siguiente = true;
        }
}