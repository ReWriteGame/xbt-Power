using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CategoryController : MonoBehaviour
{
    [SerializeField] private Category category;
    [SerializeField] private Text textData = null;


    public void AddData()
    {
        if (textData == null || textData.text == "" || float.Parse(textData.text) == 0) return;
        category.dataMoney.Add(float.Parse(textData.text));
    }

    public void RemoveLast()
    {
        if (category.dataMoney.Count <= 0) return;
        category.dataMoney.RemoveAt(category.dataMoney.Count);
    }

    public void RemoveAllList()
    {
        category.dataMoney = new List<float>(100);
    }
}
