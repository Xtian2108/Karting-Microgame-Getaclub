using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartAppearance : MonoBehaviour
{

    /*
        Creo arrays para cada una de las partes de que se van a personalizar para que el diseñador tenga control para hacer cambios 
    */
    public Material llantaMaterial;
    public Material jugadorMaterial;


    public Texture[] texturasKart;
    public Material kartMaterial;

    public void Start()
    {
        llantaMaterial.color = Color.black;
        kartMaterial.mainTexture = null;
    }

    public void CambiarColorLlanta(KartWheelsAppeareanceScriptableObject so)
    {
        llantaMaterial.color = so.colorWheels;
    }

    public void CambiarColorJugador(KartPlayerAppeareanceScriptableObject so)
    {
        jugadorMaterial.color = so.colorPlayer;
    }


    public void TexturaKart(int num)
    {
        if (num == 1)
        {
            kartMaterial.mainTexture = texturasKart[0];
        }
        else if (num == 2)
        {
            kartMaterial.mainTexture = texturasKart[1];
        }
        else if (num == 3)
        {
            kartMaterial.mainTexture = texturasKart[2];
        }
        else if (num == 4)
        {
            kartMaterial.mainTexture = texturasKart[3];
        }
    }
}
