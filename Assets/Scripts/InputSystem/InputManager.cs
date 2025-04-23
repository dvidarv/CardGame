using System;
using UnityEngine;

public class InputManager: MonoBehaviour
{
    public static InputManager Instance;

    private InputActions _inputActions;

    public event Action OnLeftClick;
    public event Action OnRightClick;
    public event Action<Vector2> OnMouseScroll;


    [Header("Mouse Position Inputs")]
    public Vector2 _mousePointInput;

    [Header("Mouse Scroll Input")]
    public Vector2 _mouseScrollInput;

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
            _inputActions.MouseActions.Scroll.performed += i =>
            {
                _mouseScrollInput = i.ReadValue<Vector2>();
                OnMouseScroll?.Invoke(_mouseScrollInput);
            };

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
            OnLeftClick?.Invoke();
        }
    }

    private void HandleRightClickInput()
    {
        if (_rightClickInput)
        {
            _rightClickInput = false;
            OnRightClick?.Invoke();
        }
    }

    public Vector2 GetMousePointVector()
    {
        return _mousePointInput;
    }
}
