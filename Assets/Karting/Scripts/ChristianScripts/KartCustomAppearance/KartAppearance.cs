using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartAppearance : MonoBehaviour
{

    /*
        Creo arrays para cada una de las partes de que se van a personalizar para que el diseñador tenga control para hacer cambios 
    */
    public Color[] llantaColores;
    public Material llantaMaterial;


    public Color[] colorJugador;
    public Material jugadorMaterial;


    public Texture[] texturasKart;
    public Material kartMaterial;

    public void Start()
    {
        llantaMaterial.color = Color.black;
        kartMaterial.mainTexture = null;
    }

    public void ColorLlanta(int num)
    {
        if(num == 1)
        {
            llantaMaterial.color = llantaColores[0];
        }
        else if (num == 2)
        {
            llantaMaterial.color = llantaColores[1];
        }
        else if (num == 3)
        {
            llantaMaterial.color = llantaColores[2];
        }
        else if (num == 4)
        {
            llantaMaterial.color = llantaColores[3];
        }
    }

    public void ColorJugador(int num)
    {
        if (num == 1)
        {
            jugadorMaterial.color = colorJugador[0];
        }
        else if (num == 2)
        {
            jugadorMaterial.color = colorJugador[1];
        }
        else if (num == 3)
        {
            jugadorMaterial.color = colorJugador[2];
        }
        else if (num == 4)
        {
            jugadorMaterial.color = colorJugador[3];
        }
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
