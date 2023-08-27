using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldController : MonoBehaviour
{
    InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<InputField>();
        inputField.onValueChanged.AddListener(OnInputChange);
    }

    public void OnInputChange(string newValue)
    {
        PersistentManager.Instance.namePlayer = newValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
