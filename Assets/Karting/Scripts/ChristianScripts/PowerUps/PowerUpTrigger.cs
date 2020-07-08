using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTrigger : MonoBehaviour
{
    //Creo un enum por si en un futuro se agregan nuevos powerups y estos puedan agregados aqui solo creando un nuevo PowerUp scriptableObject desde la carpeta proyecto 
    public enum PowerUpType
    {
        AddTime
    }

    public PowerUpType powerupT;
    public PowerUpsController powerupC;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && powerupT == PowerUpType.AddTime)
        {
            powerupC.AddExtraTime();
        }    
    }
}
