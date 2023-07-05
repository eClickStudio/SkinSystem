using UnityEngine;

public abstract class AbstractSkinsDataBase<SkinType> : 
    SingletonScriptableObject<AbstractSkinsDataBase<SkinType>>,
    ISkinDataBase<SkinType>
{
    [SerializeField] private SkinType[] _skins;

    public virtual int Count => _skins.Length;

    public SkinType this[int index]
    {
        get
        {
            return _skins[index];
        }
    }
}
