using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript 
{
    int i = 10; //gak dipakai hanya untuk demo this
    public float speed = 5f;

    public void methodsaya()
    {
        Debug.Log("memanggil method saya");
    }

    public Vector3 berjalan()
    {
        // mendapatkan input horizontal dan vertikal
        float horizontalinput = Input.GetAxis("Horizontal");
        float verticalinput = Input.GetAxis("Vertical");

        // menghitung vector gerakan 
        Vector3 movement = new Vector3(horizontalinput, 0f, verticalinput)*speed*Time.deltaTime; // sumbu X, Y, Z

        return movement;
    }
}
