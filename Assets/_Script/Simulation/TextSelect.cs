using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextSelect : MonoBehaviour
{
    public string[] titles;
    public TMP_Text _text;

    private void Start()
    {
        _text.text = titles[ModelSelector.Instance.modelIndex];
    }
}
