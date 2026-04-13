using UnityEngine;
using System;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;
    public Transform startPoint;
    public Transform[] path;
    public static event Action<int> OnCurrencyChanged;

    [SerializeField] private int _currency;
    public int Currency
    {
        get => _currency;

        private set
        {
            _currency = value;
            OnCurrencyChanged?.Invoke(_currency);
        }
    }

    private void Awake()
    {
        main = this;
    }

    private void Start()
    {
        Currency = 100;
    }

    public void IncreaseCurrency(int amount)
    {
        Currency += amount;
    }

    public bool SpendCurrency(int amount)
    {
        if (amount <= Currency)
        {
            Currency -= amount;
            return true;
        }

        return false;
    }
}
