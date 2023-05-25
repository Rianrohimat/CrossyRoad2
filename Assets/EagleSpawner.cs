using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EagleSpawner : MonoBehaviour
{
    [SerializeField] Eagle eagle;
    [SerializeField] Character character;
    [SerializeField] float initialTimer = 10;

    public UnityEvent OnEagleActive;


    float timer;
    private void Start() {
        timer = initialTimer;
        eagle.gameObject.SetActive(false);
    }

    private void Update() {
        if(timer<=0 && eagle.gameObject.activeInHierarchy==false){
            eagle.gameObject.SetActive(true);
            OnEagleActive.Invoke();
            eagle.transform.position = character.transform.position + new Vector3(0,0,13);
            character.SetNotMoveAble(true);
        }
        timer -= Time.deltaTime;
    }
    

    public void ResetTimer(){
        timer = initialTimer;
    }



}
