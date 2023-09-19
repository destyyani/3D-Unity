using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOP : MonoBehaviour
{
    // Start is called before the first frame update

    //membuat object di unity
    NewBehaviourScript testOOP = new NewBehaviourScript();
    void Start()
    {
        Debug.Log("skrip pertama");
        int i = 5;

       
        testOOP.methodsaya();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(testOOP.berjalan());
    }
}
