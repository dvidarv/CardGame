using UnityEngine;

public class MouseManager : MonoBehaviour
{
    [HideInInspector]
    public static MouseManager Instance;
    
    private Camera _mainCamera;

    [SerializeField] private LayerMask _whatIsInteractable;

    private IHoverable _currentHoverTarget = null;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        _mainCamera = Camera.main;
    }
    private void Start()
    {
        InputManager.Instance.OnLeftClick += HandleLeftClick;
        InputManager.Instance.OnRightClick += HandleRightClick;
    }
    private void Update()
    {
        HandleHover();
    }

    private void HandleHover() //CONTINUOUSLY CASTS A RAY FROM CAMERA TO GAME AND IF RAY TOUCHES A IHOVERABLE OBJECT IT PERFORMS ITS DESIGNATED ACTION
    {
        Ray ray = _mainCamera.ScreenPointToRay(InputManager.Instance.GetMousePointVector());
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, _whatIsInteractable)) //IF THE RAY TOUCHES AN OBJECT WITH THE IHOVERABLE INTERFACE
        {
            IHoverable hoverTarget = hit.collider.GetComponent<IHoverable>();

            if (hoverTarget != _currentHoverTarget) //IF WE ARE HOVERING AN OBJECT DIFFERENT FROM THE LAST HOVERED OBJECT
            {
                if (_currentHoverTarget != null) // IF THE IS A PREVIOUSLY HOVERED OBJECT
                    _currentHoverTarget.OnHoverExit(); // THE OBJECT STOPS BEING HOVERED AND PERFORMS AN EXIT ACTION

                if (hoverTarget != null) // IF THE RAY DOES NOT HIT ANY OBJECT
                    hoverTarget.OnHoverEnter(); // IF THERE IS A PREVIOUS HOVERED OBJECT, IT STOPS HOVERING AND PERFORMS EXIT ACTION

                _currentHoverTarget = hoverTarget;
            }
        }
        else //IF THE RAY DOES NOT TOUCH ANY OBJECT THAT CONTAINS THE IHOVERABLE INTERFACE
        {
            if (_currentHoverTarget != null) // IF THERE WAS A PREVIOUS HOVERED OBJECT, IT STOPS BEING HOVERED AND PERFORMS ITS EXIT ACTION
            {
                _currentHoverTarget.OnHoverExit();
                _currentHoverTarget = null;
            }
        }
    }

    private void HandleLeftClick() //CASTS A REY FROM THE CAMERA TO THE GAME. IF THE RAY TOUCHES AN OBJECT WITH THE ICLICKABLE INTERFACE, IT PERFORMS ITS DEISGNATED ACTION
    {
        Ray ray = _mainCamera.ScreenPointToRay(InputManager.Instance.GetMousePointVector());
        if(Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, _whatIsInteractable))
        {
            IClickable clickTarget = hit.collider.GetComponent<IClickable>();
            if(clickTarget != null)
            {
                clickTarget.OnLeftClick();
            }
        }
    }

    private void HandleRightClick() //SAME TO PREVIOUS FUNCION BUT FOR RIGHT CLICK
    {
        Ray ray = _mainCamera.ScreenPointToRay(InputManager.Instance.GetMousePointVector());
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, _whatIsInteractable))
        {
            IClickable clickable = hit.collider.GetComponent<IClickable>();
            if (clickable != null)
            {
                clickable.OnRightClick();
            }
        }
    }
}
