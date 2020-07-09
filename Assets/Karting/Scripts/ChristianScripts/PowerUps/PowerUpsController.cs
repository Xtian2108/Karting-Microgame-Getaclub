using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class PowerUpsController : MonoBehaviour
{
    public ArcadeKart arcadeK;
    public Rigidbody kart;

    TimeManager m_TimeManager; // Para Acceder a la variable TimeRemaining tuve que cambiar el set de private a public

    private void Start()
    {
        m_TimeManager = FindObjectOfType<TimeManager>(); //Busco el script TimeManager cuando inicio la escena ya que este solo aparece en runtime
    }

    public void AddExtraTime(PowerUpScriptableObject powerupSO)
    {
        m_TimeManager.TimeRemaining += powerupSO.addTime;  // Añado tiempo extra mediante los atributos del scriptableobject el cual ayuda mucho para que el diseñador pueda cambiarlo directamente desde el editor
    }

    public void AddJump(PowerUpScriptableObject powerupSO)
    {
        kart.AddForce(Vector3.up * powerupSO.jumpForce); // Uso el rigidbody del personaje principal para añadirle una fuerza que lo impulse hacia arriba. Para el valor se usa un scriptableobject
    }

    public void AddTurbo(PowerUpScriptableObject powerupSO)
    {
        arcadeK.baseStats.TopSpeed = powerupSO.addSpeed; //Modifico el valor de sus stats base para aumentarle la maxima velocidad a la que puiede alcanzar. El valor se modifica mediante el scriptable object
    }

    public void AddLoseControl(PowerUpScriptableObject powerupSO)
    {
        arcadeK.baseStats.Steer = powerupSO.loseControl; // Modifico el valor de su stat base para aumentarle la sensibilidad del timon para que de la sensacion que perdio el control. El valor se modifica mediante el scriptableobject
    }
}
