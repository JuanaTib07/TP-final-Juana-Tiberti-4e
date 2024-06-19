using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MANEGADOR : MonoBehaviour
{
    public GameObject[] comida;
    public int currentIndex = -1;

    // Start is called before the first frame update
    void Start()
    {
        DesactivateAll(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex++;

            if (currentIndex < comida.Length)
            {
                DesactivateAll();
                ActivateIndex(currentIndex);
            }

            else if (currentIndex >= comida.Length)
            {
                currentIndex = -1;
            }
            


        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            currentIndex--;

            if (currentIndex < comida.Length)
            {
                DesactivateAll();
                ActivateIndex(currentIndex);
            }

            else if (currentIndex >= comida.Length)
            {
                currentIndex = 13;
            }

        }
    }

    void DesactivateAll()
    {
        for (int i = 0; i < comida.Length; i++)
        {
            comida[i].SetActive(false);
        }
    }

    void ActivateIndex(int index)
    {
        comida[index].SetActive(true);
    }



}
