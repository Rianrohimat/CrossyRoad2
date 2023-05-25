using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class PlayCountDown : MonoBehaviour
{
    [SerializeField] TMP_Text tmpText;
    public UnityEvent OnStart;
    public UnityEvent OnEnd;

    private void Start()
    {
        OnStart.Invoke();
        var sequence = DOTween.Sequence();
        tmpText.transform.localScale = Vector3.zero;
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            0.7f).OnStart(() => { 
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "3"; 
                }));

        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            0.7f).OnStart(() => { 
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "2"; 
                }));

        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            0.7f).OnStart(() => { 
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "1"; 
                }));

        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            0.7f).OnStart(() => { 
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "GO!"; 
                }));

        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            0.7f).OnStart(() => { 
                OnEnd.Invoke(); 
                }));
    }

}
