/*
    Universidade de Brasília
    Departamento de Ciência da Computação
    Object Pooling Tester
    André Cássio Barros de Souza
    16/0111943
*/

using System.Collections.Generic;
using UnityEngine;

public class ProjectilePoolingManager : MonoBehaviour
{
    private static ProjectilePoolingManager instance;
    public static ProjectilePoolingManager Instance
    {
        get
        {
            if(instance == null)
                instance = FindObjectOfType<ProjectilePoolingManager>();

            return instance;
        }
    }

    [SerializeField] private GameObject _projectilePrefab;
    [SerializeField] private List<PoolingProjectileBehaviour> _projectiles;

    private void Awake()
    {
        InitializeVariables();
    }

    private void InitializeVariables()
    {
        _projectiles = new List<PoolingProjectileBehaviour>();
    }

    public PoolingProjectileBehaviour GetAvailableProjectile()
    {
        foreach(PoolingProjectileBehaviour projectile in _projectiles)
        {
            if(!projectile.IsActive)
                return projectile;
        }

        return CreateNewProjectile();
    }

    private PoolingProjectileBehaviour CreateNewProjectile()
    {
        PoolingProjectileBehaviour newProjectile = Instantiate(_projectilePrefab, Vector3.zero, Quaternion.identity, this.transform).GetComponent<PoolingProjectileBehaviour>();

        newProjectile.Deactivate();

        _projectiles.Add(newProjectile);

        return newProjectile;

    }

}

