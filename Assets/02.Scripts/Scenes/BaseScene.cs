using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class BaseScene : MonoBehaviour
{
    public Define.ESCENE SceneType { get; protected set; } = Define.ESCENE.NONE;

    private void Awake()
    {
        Init();
    }


    protected virtual void Init()
    {
        Object obj = GameObject.FindObjectOfType(typeof(EventSystem));

        if (obj == null)
            Managers.Resource.Instantiate("UI/EventStstem").name = "@EventSystem";

    }

    public abstract void Clear();
}
