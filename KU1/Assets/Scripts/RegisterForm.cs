using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RegisterForm : MonoBehaviour
{
    public InputField inputFieldUser;
    public InputField inputFieldPasswd;
    public InputField inputFieldConfirmPasswd;
    public Slider sliderAge;
    public Text textAge;
    public Dropdown dropdownGender;
    public Toggle toggleAgree;

    RegisterModel registerModel = new RegisterModel();

    public void SubmitForm()
    {
        registerModel.UserName = inputFieldUser.text;
        registerModel.Password = inputFieldPasswd.text;
        registerModel.Gender = dropdownGender.options[dropdownGender.value].text;
        registerModel.Age = (int)sliderAge.value;
        registerModel.Accepted = toggleAgree.isOn;

        print(JsonUtility.ToJson(registerModel));
   
    }

    public void ShowAgeValue()
    {
        textAge.text = sliderAge.value.ToString();
    }
}

