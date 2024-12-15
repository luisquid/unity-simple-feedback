using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class FeedbackForm : MonoBehaviour
{
    [Header("Form Settings")]
    [SerializeField] private KeyCode feedbackKey;
    [SerializeField] private bool includeBuildInfo = false;
    [SerializeField] private GameObject formGameObject;


    [Header("Google Forms Setup")]
    [SerializeField] private string baseURL = "";
    [SerializeField] private string usernameFieldID = "";
    [SerializeField] private string emailFieldID = "";
    [SerializeField] private string feedbackFieldID = "";

    [Header("Form Input Fields")]
    [SerializeField] private TMP_InputField usernameInputField;
    [SerializeField] private TMP_InputField emailInputField;
    [SerializeField] private TMP_InputField feedbackInputField;

    private string username;
    private string email;
    private string feedback;

    /// We set the Simple Feedback Form prefab to not be destroyed on load
    private void Awake()
    {
        DontDestroyOnLoad(this.transform.parent.gameObject);   
    }

    //If the feedback key is pressed, it will show the form
    private void Update()
    {
        if(Input.GetKeyDown(feedbackKey))
        {
            formGameObject.SetActive(!formGameObject.activeSelf);
        }
    }

    public void Send()
    {
        username = usernameInputField.text;
        email = emailInputField.text;
        feedback = "# Feedback Comments: " + feedbackInputField.text + "\n";

        if(includeBuildInfo)
            feedback = GatherBuildInfo(feedback);

        StartCoroutine(Post());
    }

    private string GatherBuildInfo(string _feedback)
    {
        _feedback += "\n# Device and Build info:";
        _feedback += "\n+ Build version: " + Application.version;
        _feedback += "\n+ Build GUID: " + Application.buildGUID;
        _feedback += "\n+ Build Platform: " + Application.platform;

        return _feedback; 
    }

    private IEnumerator Post()
    {
        WWWForm form = new WWWForm();
        form.AddField(usernameFieldID, username);
        form.AddField(emailFieldID, email);
        form.AddField(feedbackFieldID, feedback);

        using UnityWebRequest www = UnityWebRequest.Post(baseURL, form);

        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log("REQUEST ERROR: " + www.error);
        }
        else
        {
            Debug.Log("Success!");
        }

        CleanInputFields();
        formGameObject.SetActive(false);
    }

    private void CleanInputFields()
    {
        usernameInputField.text = "";
        emailInputField.text = "";
        feedbackInputField.text = "";
    }
}
