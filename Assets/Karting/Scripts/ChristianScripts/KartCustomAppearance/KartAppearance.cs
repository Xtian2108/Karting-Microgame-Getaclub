using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartAppearance : MonoBehaviour
{

    /*
        Creo arrays para cada una de las partes de que se van a personalizar para que el diseñador tenga control para hacer cambios 
    */
    public Material wheelsMaterial;
    public Material playerMaterial;


    public Texture[] kartTextures;
    public Material kartMaterial;

    public void Start()
    {
        wheelsMaterial.color = Color.black;
        kartMaterial.mainTexture = null;
    }

    public void ChangeColorWheels(KartWheelsAppeareanceScriptableObject so)
    {
        wheelsMaterial.color = so.colorWheels;
    }

    public void ChangeColorPlayer(KartPlayerAppeareanceScriptableObject so)
    {
        playerMaterial.color = so.colorPlayer;
    }


    public void ChangeTextureKart(int num)
    {
        if (num == 1)
        {
            kartMaterial.mainTexture = kartTextures[0];
        }
        else if (num == 2)
        {
            kartMaterial.mainTexture = kartTextures[1];
        }
        else if (num == 3)
        {
            kartMaterial.mainTexture = kartTextures[2];
        }
        else if (num == 4)
        {
            kartMaterial.mainTexture = kartTextures[3];
        }
    }
}
