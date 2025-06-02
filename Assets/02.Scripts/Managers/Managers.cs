using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Managers : MonoBehaviour
{
    static Managers s_instance; // ���ϼ��� ����ȴ�
    static Managers Inst { get { Init(); return s_instance; } } // ������ �Ŵ����� ����´�

    #region Contents
    GameManager _game = new GameManager();
    ObjectManager _object = new ObjectManager();

    public static GameManager Game { get { return Inst?._game; } }
    public static ObjectManager Object { get { return Inst?._object; } }

    #endregion

    #region Core
    DataManager _data = new DataManager();
    PoolManager _pool = new PoolManager();
    ResourceManager _resource = new ResourceManager();
    SoundManager _sound = new SoundManager();
    UIManager _ui = new UIManager();


    public static DataManager Data { get { return Inst?._data; } }
    public static PoolManager Pool { get { return Inst?._pool; } }
    public static ResourceManager Resource { get { return Inst?._resource; } }
    public static SoundManager Sound { get { return Inst?._sound; } }
    public static UIManager UI { get { return Inst?._ui; } }
    #endregion


    public static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();

        }
    }

    public static void Clear()
    {
        //Sound.Clear();
        //Scene.Clear();
        //UI.Clear();
        //Pool.Clear();
        //Object.Clear();
    }


}
