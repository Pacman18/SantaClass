using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    static private UIManager _instance;

    public Canvas _canvas;


    private Dictionary<string, UIBase> _uiContainer = new Dictionary<string, UIBase>();

    public static UIManager Instance
    {
        get
        { 
            if(_instance == null)
                _instance = FindAnyObjectByType<UIManager>();

            if (_instance == null)
            {
                var go = new GameObject("UIManager");
                _instance = go.AddComponent<UIManager>();   
            }

            return _instance;
        }
    }

    public T CreatePage<T>() where T : MonoBehaviour
    {
        string objName = typeof(T).ToString();

        GameObject uiPage = Resources.Load<GameObject>("Prefab/UI/"+ objName);

        if (_uiContainer.ContainsKey(objName))
            return null;

        GameObject ui = Instantiate(uiPage);

        T uiChild = ui.GetComponent<T>();

        if (uiChild == null)
        {
            Debug.LogError("규칙에 맞지 않음");
        }
        _uiContainer.Add(objName, uiChild as UIBase);
    

        ui.transform.SetParent(_canvas.transform);
        (ui.transform as RectTransform).offsetMin = Vector3.zero;
        (ui.transform as RectTransform).offsetMax = Vector3.zero;

        return uiChild;
    }

    public void RemovePage<T>() where T : UIBase
    {
        string objName = typeof(T).ToString();

        if (_uiContainer.ContainsKey(objName))
        {
            GameObject ui = _uiContainer[objName].gameObject;
            Destroy(ui);

            _uiContainer.Remove(objName);
        }
    }



    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        _canvas = FindAnyObjectByType<Canvas>();
        DontDestroyOnLoad(_canvas.gameObject);
    }


}
