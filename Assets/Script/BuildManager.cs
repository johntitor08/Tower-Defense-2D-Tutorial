using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager main;
    private int selectedTower = 0;

    [Header("References")]
    [SerializeField] private Tower[] towers;

    private void Awake()
    {
        main = this;
    }

    public Tower GetSelectedTower()
    {
        return towers[selectedTower];
    }

    public void SetSelectedTower(int selectedTower)
    {
        this.selectedTower = selectedTower;
    }
}
