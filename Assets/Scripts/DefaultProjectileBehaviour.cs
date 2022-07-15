/*
    Universidade de Brasília
    Departamento de Ciência da Computação
    Object Pooling Tester
    André Cássio Barros de Souza
    16/0111943
*/

using System;
using UnityEngine;

public class DefaultProjectileBehaviour : MonoBehaviour
{
    [SerializeField] [Range(1f, 15f)] private int _speed;

    private void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }
}


