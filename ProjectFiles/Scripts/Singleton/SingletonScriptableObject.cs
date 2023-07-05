using System;
using UnityEngine;

public class SingletonScriptableObject<SingletonType> : ScriptableObject
    where SingletonType : SingletonScriptableObject<SingletonType>
{
    private static SingletonType _instance;

    public static SingletonType Instance
    {
        get
        {
            if (_instance == null)
            {
                SingletonType[] instances = Resources.LoadAll<SingletonType>("");

                if (instances == null || instances.Length < 1)
                {
                    throw new InvalidOperationException($"There arent any SingletonScriptableObject<{typeof(SingletonType)}>.");
                }
                else if (instances.Length > 1)
                {
                    throw new InvalidOperationException($"There are too many SingletonScriptableObject<{typeof(SingletonType)}>.");
                }

                _instance = instances[0];
            }

            return _instance;
        }
    }
}

