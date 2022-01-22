using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainDataBase : MonoBehaviour
{
    [SerializeField] private List<Category> categories;
    [SerializeField] private Text text;


    public void UpdateAllScore()
    {
        float allMoney = 0;
        foreach (Category category in categories)
            foreach (float value in category.dataMoney)
                allMoney += value;

        text.text = allMoney + "";
    }

    private void Start()
    {
        UpdateAllScore();
    }
}
