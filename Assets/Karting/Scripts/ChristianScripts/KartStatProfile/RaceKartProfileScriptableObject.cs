using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class RaceKartProfileScriptableObject : ScriptableObject
{

    /* Reuso las variables de la clase Arcade Kart*/
    [Header("Car Stats")]
    [Tooltip("The maximum speed forwards")]
    public float TopSpeed;

    [Tooltip("How quickly the Kart reaches top speed.")]
    public float Acceleration;

    [Tooltip("The maximum speed backward.")]
    public float ReverseSpeed;

    [Tooltip("The rate at which the kart increases its backward speed.")]
    public float ReverseAcceleration;

    [Tooltip("How quickly the Kart starts accelerating from 0. A higher number means it accelerates faster sooner.")]
    [Range(0.2f, 1)]
    public float AccelerationCurve;

    [Tooltip("How quickly the Kart slows down when going in the opposite direction.")]
    public float Braking;

    [Tooltip("How quickly to slow down when neither acceleration or reverse is held.")]
    public float CoastingDrag;

    [Range(0, 1)]
    [Tooltip("The amount of side-to-side friction.")]
    public float Grip;

    [Tooltip("How quickly the Kart can turn left and right.")]
    public float Steer;

    [Tooltip("Additional gravity for when the Kart is in the air.")]
    public float AddedGravity;

    [Tooltip("How much the Kart tries to keep going forward when on bumpy terrain.")]
    [Range(0, 1)]
    public float Suspension;
}
