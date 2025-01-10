using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    private string _remainingString = "Seeds Remaining: ";
    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        _remainingText.text = _remainingText.text + seedsPlanted.ToString();
    }
}