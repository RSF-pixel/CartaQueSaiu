using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartaDraw : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Clica na tecla espaço para tirares uma carta do baralho");

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            getRandomCard();


        }

    }

    //Metodo para encontrar uma carta de maneira random
    void getRandomCard()
    {

        //Escolher o tipo de carta (espadas,copas etc)
        int randomType = Random.Range(1, 4);
        string type = " de Copas";

        switch(randomType)
        {
            case 1:
                type = " de Copas";
                break;
            case 2:
                type = " de Espadas";
                break;
            case 3:
                type = " de Ouros";
                break;
            case 4:
                type = " de Paus";
                break;
            default:
                Debug.Log("Erro a escolher o tipo");
                break;
        }

        //Encontrar a carta em si 
        int randomCard = Random.Range(1, 13);
        string prefix = "Saiu o ";

        switch (randomCard)
        {
            case 1:
                //AS
                Debug.Log(prefix + "ÁS" + type);

                break;
            case 2:
                //2
                Debug.Log(prefix + "2" + type);

                break;

            case 3:
                //3
                Debug.Log(prefix + "3" + type);

                break;

            case 4:
                //4
                Debug.Log(prefix + "4" + type);

                break;

            case 5:
                //5
                Debug.Log(prefix + "5" + type);

                break;

            case 6:
                //6
                Debug.Log(prefix + "6" + type);

                break;

            case 7:
                //7
                Debug.Log(prefix + "7" + type);

                break;

            case 8:
                //8
                Debug.Log(prefix + "8" + type);

                break;

            case 9:
                //9
                Debug.Log(prefix + "9" + type);

                break;

            case 10:
                //10
                Debug.Log(prefix + "10" + type);

                break;

            case 11:
                //Valete
                Debug.Log(prefix + "Valete" + type);

                break;

            case 12:
                //Rainha
                Debug.Log(prefix + "Rainha" + type);

                break;
            case 13:
                //Rei
                Debug.Log(prefix + "Rei" + type);

                break;

            default:
                //Caso seja erro
                Debug.Log("Carta não encontrada");
                break;
        }
    }
}
