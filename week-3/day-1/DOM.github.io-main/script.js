// JavaScript code for appending a new paragraph element with the text input value

// Get the text input and button elements from the DOM
const textInput = document.getElementById("textInput");
const submitButton = document.getElementById("submitButton");
const paragraphContainer = document.getElementById("paragraphContainer");

// Add event listener to the button
submitButton.addEventListener("click", addParagraph);

// Function to add a new paragraph element with the text input value to the DOM
function addParagraph() {
  // Get the value from the text input
  const inputValue = textInput.value;

  // Create a new paragraph element
  const newParagraph = document.createElement("p");
  newParagraph.textContent = inputValue;

  // Append the new paragraph to the paragraph container
  paragraphContainer.appendChild(newParagraph);

  // Clear the text input
  textInput.value = "";
}
