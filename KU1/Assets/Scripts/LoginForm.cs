using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginForm : MonoBehaviour
{
    public InputField inputFieldUser;
    public InputField inputFieldPasswd;

    public void CheckUserAndPassword()
    {
        if(inputFieldUser.text == inputFieldPasswd.text)
        {
            print("Pass");
        }
        else
        {
            print("Try again");
        }
    }
}
