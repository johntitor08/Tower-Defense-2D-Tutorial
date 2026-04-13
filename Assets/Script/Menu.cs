using TMPro;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private TextMeshProUGUI currencyUI;
    [SerializeField] private Animator anim;

    private bool isMenuOpen = true;

    private void OnEnable()
    {
        LevelManager.OnCurrencyChanged += UpdateCurrencyUI;
    }

    private void OnDisable()
    {
        LevelManager.OnCurrencyChanged -= UpdateCurrencyUI;
    }

    private void UpdateCurrencyUI(int currentCurrency)
    {
        currencyUI.text = currentCurrency.ToString();
    }

    public void ToggleMenu()
    {
        isMenuOpen = !isMenuOpen;
        anim.SetBool("MenuOpen", isMenuOpen);
    }
}
