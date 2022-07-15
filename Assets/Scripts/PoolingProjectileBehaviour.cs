/*
    Universidade de Brasília
    Departamento de Ciência da Computação
    Object Pooling Tester
    André Cássio Barros de Souza
    16/0111943
*/

using System;
using UnityEngine;

public class PoolingProjectileBehaviour : MonoBehaviour
{
    [SerializeField] [Range(1f, 30f)] private int _speed;

    [Header("Pooling Info")]
    public bool IsActive;


    private void Update()
    {
        if(!IsActive)
            return;

        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Wall"))
        {
            Deactivate();
        }
    }

    public void Deactivate()
    {
        transform.position = new Vector3(-1000f, -1000f, -1000f);
        IsActive = false;
    }

    public void Activate(Vector3 startPosition)
    {
        transform.position = startPosition;
        IsActive = true;
    }
}


