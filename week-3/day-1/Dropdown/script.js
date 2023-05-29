// JavaScript code for appending a new paragraph element with the text input value and matching color

// Get the necessary elements from the DOM
const colorSelect = document.getElementById("colorSelect");
const textInput = document.getElementById("textInput");
const submitButton = document.getElementById("submitButton");
const paragraphContainer = document.getElementById("paragraphContainer");

// Add event listener to the button
submitButton.addEventListener("click", addParagraph);

// Function to add a new paragraph element with the text input value and matching color to the DOM
function addParagraph() {
  const inputValue = textInput.value; // Get the text input value
  const selectedColor = colorSelect.value; // Get the selected color from the dropdown

  const newParagraph = document.createElement("p"); // Create a new paragraph element
  newParagraph.textContent = inputValue;
  newParagraph.style.color = selectedColor; // Set the color of the new paragraph element

  paragraphContainer.appendChild(newParagraph); // Append the new paragraph to the paragraph container

  textInput.value = ""; // Clear the text input
}
