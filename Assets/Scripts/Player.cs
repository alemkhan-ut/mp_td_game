using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    private RectTransform _rectTransform;

    [SerializeField] private int _playerNumber;

    public static Player Instance;

    public int PlayerNumber { get => _playerNumber; }

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
        _rectTransform.sizeDelta = new Vector2(Size, Size);
    }

    void Update()
    {

    }
}
