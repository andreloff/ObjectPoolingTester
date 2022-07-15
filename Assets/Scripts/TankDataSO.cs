/*
    Universidade de Brasília
    Departamento de Ciência da Computação
    Object Pooling Tester
    André Cássio Barros de Souza
    16/0111943
*/

using System;
using UnityEngine;

[CreateAssetMenu(fileName = "TankData", menuName = "Object Pooling Tester/New Tank Data")]
public class TankDataSO : ScriptableObject
{
    [SerializeField] [Range(0.5f, 2f)] private float _timeToStartShooting = 1f;
    public float GetTimeToStartShooting => _timeToStartShooting;

    [SerializeField] [Range(0.01f, 2f)] private float _timeBetweenShots = 0.2f;
    public float GetTimeBetweenShots => _timeBetweenShots;

}

