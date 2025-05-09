using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class Vibration : MonoBehaviour
{

    [SerializeField] private Button vibrationDuration;


    private void Vibracion()
    {
         
        Handheld.Vibrate();

    }


    private void Habilitado()
    {
        vibrationDuration.onClick.AddListener(Vibracion);
    }

    private void Deshabilitado()
    {
        vibrationDuration.onClick.RemoveListener(Vibracion);
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
