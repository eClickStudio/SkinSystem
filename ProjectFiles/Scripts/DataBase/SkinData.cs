using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(menuName = "data/skins/skinData", fileName = "skinData")]
public class SkinData : ScriptableObject
{
    [Header("SkinData")]
    [SerializeField] private Sprite _skinSprite;
    [SerializeField] private string _skinName;
    [SerializeField] private string _skinDescription;

    public Sprite SkinSprite => _skinSprite;
    public string SkinName => _skinName;
    public string SkinDescription => _skinDescription;
}
