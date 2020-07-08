using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUpsController : MonoBehaviour
{
    public PowerUpScriptableObject powerupSO;
    TimeManager m_TimeManager; // Para Acceder a la variable TimeRemaining tuve que cambiar el set de private a public

    private void Start()
    {
        m_TimeManager = FindObjectOfType<TimeManager>(); //Busco el script TimeManager cuando inicio la escena ya que este solo aparece en runtime
    }

    public void AddExtraTime()
    {
        m_TimeManager.TimeRemaining += powerupSO.addTime;  // Añado tiempo extra mediante los atributos del scriptableobject el cual ayuda mucho para que el diseñador pueda cambiarlo directamente desde el editor
    }
}
