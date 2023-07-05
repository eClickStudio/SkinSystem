using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(menuName = "data/grounds/groundData", fileName = "groundData")]
public class GroundData : ScriptableObject
{
    [Header("Ground Data")]
    [SerializeField] private Sprite _groundSprite;

    public Sprite SkinSprite => _groundSprite;
}
