using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName="FruitData", menuName ="Scriptables/FruitReset")]
public class FruitPreset : ScriptableObject
{
    [Header("Fruit Propreties")]
    


    public float rotateSelfSpeed;
    public float Size;
    public GameObject FruitModel;
    
    [Tooltip("Score of fruit")]
    [Range(-100,100)]
    public int fruitValue;

    [Tooltip("Fruit combo multiplier")]
    [Range(0f,1f)]
    public float fruitMultiplier;

    [Tooltip("Fruit time adding")]
    [Range(-2f, 2f)]
    public float fruitTimeAdding;
}
