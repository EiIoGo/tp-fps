using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeScript : MonoBehaviour
{
    public AlimentoScript script;

    public int nivelHambre;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TomarAlimento(int valorAlimentario)
    {
        nivelHambre -= valorAlimentario;
        if (nivelHambre < 0)
        {
            nivelHambre = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger " + other.name);
        AlimentoScript alimento = other.GetComponent<AlimentoScript>();
        TomarAlimento(alimento.valorAlimentario);
    }
}
