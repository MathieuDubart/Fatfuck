using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName="FruitData", menuName ="Scriptables/FruitReset")]
public class FruitPreset : ScriptableObject
{
[Header("Fruit Propreties")]
[Tooltip("Score of fruit")]
[Range(-100,100)]


public float rotateSelfSpeed;
public float Size;
public GameObject FruitModel;

}
