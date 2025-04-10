using UnityEngine;

public class InputManager: MonoBehaviour
{
    public static InputManager Instance;

    private InputActions _inputActions;

    [Header("Mouse Position Inputs")]
    public Vector2 _mousePointInput;


    [Header("Mouse Click Inputs")]
    private bool _leftClickInput = false;
    private bool _rightClickInput = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnEnable()
    {
        if(_inputActions == null)
        {
            _inputActions = new InputActions();
            _inputActions.MouseActions.Point.performed += i => _mousePointInput = i.ReadValue<Vector2>();
            _inputActions.MouseActions.LeftClick.performed += i => _leftClickInput = true;
            _inputActions.MouseActions.RightClick.performed += i => _rightClickInput = true;
        }

        _inputActions.Enable();
    }

    private void Update()
    {
        HandleAllInputs();
    }

    private void HandleAllInputs()
    {
        HandleLeftClickInput();
        HandleRightClickInput();
    }

    private void HandleLeftClickInput()
    {
        if (_leftClickInput)
        {
            _leftClickInput = false;
            Debug.Log("Left Click pressed");
            //PERFORM LEFT CLICK ACTION ON MOUSE MANAGER SCRIPT TO MANAGE THE CLICK FUNCTION
        }
    }

    private void HandleRightClickInput()
    {
        if (_rightClickInput)
        {
            _rightClickInput = false;
            Debug.Log("Right Click pressed");
            //PERFORM RIGHT CLICK ACTION ON MOUSE MANAGER SCRIPT TO MANAGE THE CLICK FUNCTION
        }
    }
}
