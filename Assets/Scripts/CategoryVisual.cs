using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CategoryVisual : MonoBehaviour
{
    [SerializeField] private Category category;
    [SerializeField] private Text output;
    [SerializeField] private Text outputAllSumm;
    public void UpdateList()
    {
        output.text = "";
        foreach (float value in category.dataMoney)
            output.text += $"{value}\n";

    }

    public void AllSum()
    {
        float summ = 0;
        foreach (float value in category.dataMoney)
            summ += value;
        outputAllSumm.text = summ + "";
    }
    private void Start()
    {
        AllSum();
    }
}
