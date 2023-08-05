using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputController : Singleton<InputController>
{

    bool _isBtnLeftPress;
    bool _isBtnRightPress;
    bool _isBtnUpPress;
    bool _isBtnSpacePress;
    bool _isBtnDashPress;

    float _horizontalMove;
    float _verticalMove;

    [HideInInspector] public float horizontalMove { get { return _horizontalMove; } }
    [HideInInspector] public float verticalMove { get { return _verticalMove; } }
    [HideInInspector] public bool isKeySpacePress { get { return _isBtnSpacePress; } }
    [HideInInspector] public bool isKeyDashPress { get { return _isBtnDashPress; } }

    //--------------------------------------------------------
    void Start()
    {
#if UNITY_ANDROID
        gameObject.SetActive(true);
    #else
        gameObject.SetActive(false);
# endif

    }

    public void SetSpaceBtn(bool _isPress)
    {
        _isBtnSpacePress = _isPress;
    }
    public void SetDashBtn(bool _isPress)
    {
        _isBtnDashPress = _isPress;
    }
    public void SetLeftBtn(bool _isPress)
    {
        _isBtnLeftPress = _isPress;
    }
    public void SetRightBtn(bool _isPress)
    {
        _isBtnRightPress = _isPress;
    }

    void SetUpBtn(bool _isPress)
    {
        _isBtnUpPress = _isPress;
    }

    void ProcessInput()
    {
        _horizontalMove = (_isBtnLeftPress ? -1 : 0) + (_isBtnRightPress ? 1 : 0);
        _verticalMove = _isBtnUpPress ? 1 : 0;
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        Debug.Log(isKeySpacePress);
    }
}
