using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Koin_Skor : MonoBehaviour
{
    public float KecepatanPutar;
    GameObject manajer;
    // Start is called before the first frame update
    // mencari benda
    void Start()
    {
        manajer = GameObject.FindGameObjectWithTag("manajer");
        // bukan FindGameObjects ... tanpa s
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 0, KecepatanPutar);
    }

    // mencari collision
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pemain")
        {
            manajer.GetComponent<Game_Manager>().skor++;
        }
    }
}
