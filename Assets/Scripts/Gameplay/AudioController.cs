using UnityEngine;
using UnityEngine.UI;  // Required for UI elements

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;  // Reference to the AudioSource component
    public Button playButton;        // Reference to the Play Button
    public Button pauseButton;       // Reference to the Pause Button

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("AudioController script initialized."); // Log when script starts

        // Ensure buttons are not null to avoid errors
        if (playButton != null && pauseButton != null)
        {
            // Add click listeners to the buttons
            playButton.onClick.AddListener(PlayAudio);
            pauseButton.onClick.AddListener(PauseAudio);

            Debug.Log("Play and Pause buttons linked successfully."); // Log successful linking

            // Set initial button states
            playButton.gameObject.SetActive(true);
            pauseButton.gameObject.SetActive(false);

            Debug.Log("Initial button states set: PlayButton Active, PauseButton Inactive.");
        }
        else
        {
            Debug.LogWarning("Play or Pause button is not assigned in the Inspector.");
        }
    }

    // Function to play the audio and toggle button states
    public void PlayAudio()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            Debug.Log("Play Button clicked. Playing audio now...");

            // Toggle the visibility of buttons
            playButton.gameObject.SetActive(false);
            pauseButton.gameObject.SetActive(true);

            // Play the audio
            audioSource.Play();

            Debug.Log("Audio started playing.");
        }
        else if (audioSource == null)
        {
            Debug.LogError("AudioSource is not assigned or not found!");
        }
        else
        {
            Debug.LogWarning("Audio is already playing.");
        }
    }

    // Function to pause the audio and toggle button states
    public void PauseAudio()
    {
        if (audioSource != null && audioSource.isPlaying)
        {
            Debug.Log("Pause Button clicked. Pausing audio now...");

            // Toggle the visibility of buttons
            playButton.gameObject.SetActive(true);
            pauseButton.gameObject.SetActive(false);

            // Pause the audio
            audioSource.Pause();

            Debug.Log("Audio paused successfully.");
        }
        else if (audioSource == null)
        {
            Debug.LogError("AudioSource is not assigned or not found!");
        }
        else
        {
            Debug.LogWarning("Audio is not currently playing.");
        }
    }
}
