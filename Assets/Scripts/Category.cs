using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Category", menuName = "ScriptableObjects/Category")]
public class Category : ScriptableObject
{
    public List<float> dataMoney = new List<float>(100);
}
