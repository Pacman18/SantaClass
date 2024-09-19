
using UnityEngine;
using UnityEngine.UI;

public class UIFadeInOut : UIBase
{
    enum FADE_STATE
    {
        IN,
        OUT,
    }

    private Image _fadeImg;

    [SerializeField]
    private float _fadeInTime;

    [SerializeField]
    private float _fadeOutTime;

    private float _accTime;

    private FADE_STATE _state =  FADE_STATE.IN;

    private bool _isStart = false;

    void Start()
    {
        _fadeImg = GetComponent<Image>(); // 현재 스크립트에 붙어있는 영역에서 
    }

    public void StartFadeIn()
    {
        _state = FADE_STATE.IN;
        _isStart = true;
    }

    public void StartFadeOut()
    {
        _state = FADE_STATE.OUT;
        _isStart = true;
    }

    private void Update()
    {
        if (_isStart == false)
            return;           

        if(_state == FADE_STATE.IN)
        {
            FadeIn();
        }
        
        if( _state == FADE_STATE.OUT)
        {
            FadeOut();
        }
    }

    private void FadeIn()
    {
        _accTime += Time.deltaTime;

        float alpha = 1 - (1 - (_fadeOutTime - _accTime) / _fadeOutTime);

        Color prevColor = _fadeImg.color;

        prevColor.a = alpha;

        _fadeImg.color = prevColor;
    }

    private void FadeOut()
    {
        _accTime += Time.deltaTime;

        float alpha = (1 - (_fadeOutTime - _accTime) / _fadeOutTime);

        Color prevColor = _fadeImg.color;

        prevColor.a = alpha;

        _fadeImg.color = prevColor;
    }

}
