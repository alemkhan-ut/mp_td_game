using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSpawn : MonoBehaviour
{
    [SerializeField] private List<GameObject> _spawnPointObjects;

    public List<GameObject> SpawnPointObjects { get => _spawnPointObjects; }

    public static BaseSpawn Instance;

    private void Awake()
    {
        Instance = this;
    }
}
