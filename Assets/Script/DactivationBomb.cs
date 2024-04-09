using UnityEngine;
using UnityEngine.UI;

public class DactivationBomb : MonoBehaviour
{
    [SerializeField] private InputField _inputField;
    [SerializeField] private Boomb _boomb;

    [SerializeField] private int _code;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.KeypadEnter))
        {
            if(_inputField.text == _code.ToString())
            {
                _inputField.text.Remove(0, _inputField.text.Length);
                _boomb.DactivationBoomb();
            }

            else
            {
                _boomb.Dead();
            }
        }
    }
}
