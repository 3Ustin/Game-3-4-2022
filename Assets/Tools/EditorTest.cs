using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
public class EditorTest : EditorWindow
{

    [SerializeField]
    private VisualTreeAsset tree;

    private Toggle activeToggle;
    private Toggle allignToGrid;
    private LayerMaskField layerInput;
    private Vector3Field minRotation;
    private Vector3Field maxRotation;
    private FloatField minScale;
    private FloatField maxScale;
    private GameObject prefab;


    private bool OnGUICalled = false;
    [MenuItem("Window/MapEditor")]
    public static void ShowWindow() {
        GetWindow<EditorTest>("MapEditor");
    }

    private void OnSceneGui(SceneView obj){
        if(!activeToggle.value) {return;}
        Event evt = Event.current;
        if(evt.type == EventType.MouseDown && evt.button == 0){
            Ray ray = HandleUtility.GUIPointToWorldRay(evt.mousePosition);
            Physics.Raycast(ray, out RaycastHit raycastHit, maxDistance: Mathf.Infinity, layerInput.value);
            if(raycastHit.collider){
                Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow);
                instantiateObject(raycastHit.collider.gameObject, raycastHit.point);
            }
        }

    }
    private void CreateGUI(){
        tree.CloneTree(rootVisualElement);
        initFields();
        SceneView.duringSceneGui += OnSceneGui;
    }
                                                                                    //
    //OnGUI is called for rendering and handling GUI events.
    // This function can be called multiple times per frame (one call per event).
                                                                                    //

    private void instantiateObject(GameObject objectHit, Vector3 hitLocation){
        Debug.Log("Center of Object Hit" + objectHit.transform.position);
        Debug.Log("Point where Object was Hit" + hitLocation);
        Debug.Log("Vector - Vector" + (objectHit.transform.position - hitLocation));
        if(layerInput.ToString() == "Ground"){
            instantiateObjectGround(objectHit, hitLocation);
        }
        


    }
    private void instantiateObjectGround(GameObject objectHit, Vector3 hitLocation){
        if(Mathf.Abs(objectHit.transform.position.x - hitLocation.x) == .5f){
            var obj = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
            Vector3 instantiatedObjectPosition = objectHit.transform.position + new Vector3(1,0,0);
            obj.transform.position = instantiatedObjectPosition;
        }
    }
    private void initFields(){
        layerInput = rootVisualElement.Q<LayerMaskField>(name:"Layer");
        minRotation = rootVisualElement.Q<Vector3Field>(name:"MinRotation");
        maxRotation = rootVisualElement.Q<Vector3Field>(name:"MaxRotation");
        minScale = rootVisualElement.Q<FloatField>(name:"MinScale");
        maxScale = rootVisualElement.Q<FloatField>(name:"MaxScale");
        activeToggle = rootVisualElement.Q<Toggle>(name:"Active");
        allignToGrid = rootVisualElement.Q<Toggle>(name:"AllignToGrid");

        ObjectField prefabInput = rootVisualElement.Q<ObjectField>(name:"Prefab");
        prefabInput.RegisterValueChangedCallback(evnt => {
            prefab = evnt.newValue as GameObject;
        });
    }
}
