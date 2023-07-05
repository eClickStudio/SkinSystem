using UnityEngine;
using UnityEngine.UI;

public class SkinSwapper : MonoBehaviour
{
    [Header("SkinSwapper")]
    [SerializeField] private Image _skinImage;
    [SerializeField] private Text _skinText;
    [SerializeField] private Text _skinDescription;

    private int _skinIndex;

    private ISkinDataBase<SkinData> _skinDataBase;

    private void Start()
    {
        _skinDataBase = SkinsDataBase.Instance;

        _skinIndex = PlayerPrefs.GetInt("skin");
        UpdateSkin(_skinIndex);
    }

    public void SwapRight()
    {
        _skinIndex = (_skinIndex + 1) % _skinDataBase.Count;

        UpdateSkin(_skinIndex);
    }

    public void SwapLeft()
    {
        if (_skinIndex == 0)
        {
            _skinIndex = _skinDataBase.Count - 1;
        }
        else
        {
            _skinIndex = (_skinIndex - 1) % _skinDataBase.Count;
        }

        UpdateSkin(_skinIndex);
    }

    private void UpdateSkin(int index)
    {
        SkinData skin = _skinDataBase[index];

        _skinImage.sprite = skin.SkinSprite;
        _skinText.text = skin.SkinName;
        _skinDescription.text = skin.SkinDescription;

        PlayerPrefs.SetInt("skin", index);
    }
}
