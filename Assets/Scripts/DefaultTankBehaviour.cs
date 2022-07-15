/*
    Universidade de Brasília
    Departamento de Ciência da Computação
    Object Pooling Tester
    André Cássio Barros de Souza
    16/0111943
*/

using UnityEngine;

public class DefaultTankBehaviour : MonoBehaviour
{
    [SerializeField] private TankDataSO _tankData;

    [SerializeField] private GameObject _projectilePrefab;
    [SerializeField] private Transform _projectileSpawnPosition;

    private bool _canStartShooting;
    private float _currentTimeToShoot;

    
    private void Start()
    {
        InitializeObject();
    }

    private void InitializeObject()
    {
        _canStartShooting = false;
        _currentTimeToShoot = _tankData.GetTimeToStartShooting;
    }

    private void Update()
    {
        HandleStartShootingTime();
        HandleShootDelay();
    }

    private void HandleStartShootingTime()
    {
        if(_canStartShooting)
            return;

        _currentTimeToShoot -= Time.deltaTime;

        if(_currentTimeToShoot <= 0f)
            _canStartShooting = true;
    }

    private void HandleShootDelay()
    {
        if(!_canStartShooting)
            return;

        _currentTimeToShoot -= Time.deltaTime;

        if(_currentTimeToShoot <= 0f)
        {
            Shoot();
            _currentTimeToShoot = _tankData.GetTimeBetweenShots;
        }
    }

    private void Shoot()
    {
        Instantiate(_projectilePrefab, _projectileSpawnPosition.position, Quaternion.identity, this.transform);
    }

}


