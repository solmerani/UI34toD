using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public InputField passwordinput;
    private string contraseña = "hola";
    // Start is called before the first frame update
    void Start()
    {
        if (passwordinput.text == contraseña)
        {
            Debug.Log("Contraseña Correcta");
        }
        else
        {
            Debug.Log("Contraseña Incorrecta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void checkPassword()
    {
        if (passwordinput.text == contraseña)
        {
            Debug.Log("Contraseña Correcta");
        }
        else
        {
            Debug.Log("Contraseña Incorrecta");
        }
    }
}
