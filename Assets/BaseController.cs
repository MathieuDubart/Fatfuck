using UnityEngine;

public class BaseController<ControllerType> : MonoBehaviour
    where ControllerType : Object
{
    private static ControllerType _instance = null;

    public static ControllerType Instance()
    {
        if (_instance == null)
            _instance = FindFirstObjectByType<ControllerType>();
        return _instance;
    }

}