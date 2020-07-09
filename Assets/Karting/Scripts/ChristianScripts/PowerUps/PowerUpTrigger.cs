using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTrigger : MonoBehaviour
{
    //Creo un enum por si en un futuro se agregan nuevos powerups y estos puedan agregados aqui solo creando un nuevo PowerUp scriptableObject desde la carpeta proyecto 
    public enum PowerUpType
    {
        AddTime,Jump,LoseControl,Turbo
    }

    public PowerUpsController powerupC;
    public PowerUpScriptableObject powerupSO;
    public PowerUpType powerupT;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && powerupT == PowerUpType.AddTime)
        {
            powerupC.AddExtraTime(powerupSO);
        }

        if (other.tag == "Player" && powerupT == PowerUpType.Turbo)
        {
            powerupC.AddTurbo(powerupSO);
        }

        if (other.tag == "Player" && powerupT == PowerUpType.LoseControl)
        {
            powerupC.AddLoseControl(powerupSO);
        }

        if (other.tag == "Player" && powerupT == PowerUpType.Jump)
        {
            powerupC.AddJump(powerupSO);
        }
    }
}
