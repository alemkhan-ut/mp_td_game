using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMover : MonoBehaviour
{
    private bool _isPlayer;
    private Vector2 _spawnPosition;
    private Vector2 _target;

    private Joystick _joystick;
    private Transform _transform;
    private BaseSpawn _baseSpawn;

    [SerializeField] private float _moveSpeed;

    private void Start()
    {
        _transform = transform;

        if (GetComponent<Player>())
        {
            Player player = GetComponent<Player>();

            _isPlayer = true;
        }
        else
        {
            _target = Player.Instance.transform.position;
        }

        _joystick = Joystick.Instance;
        _baseSpawn = BaseSpawn.Instance;

        // Перевести в другой метод
        _spawnPosition = _baseSpawn.SpawnPointObjects[Random.Range(0, _baseSpawn.SpawnPointObjects.Count)].transform.position;
    }

    private void Update()
    {
        if (_isPlayer)
        {
            if (_joystick.Input == Vector2.zero)
            {
                _target = _spawnPosition;
            }
            else
            {
                _target = _joystick.Input;
            }
        }

        _transform.position = Vector2.MoveTowards(_transform.position, _target, _moveSpeed * Time.deltaTime);
    }
}
