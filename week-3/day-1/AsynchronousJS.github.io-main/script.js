// Using Promises
function simulateAsyncOperation(callback) {
    return new Promise((resolve, reject) => {
      setTimeout(() => {
        callback();
        resolve();
      }, 3000);
    });
  }
  
  function myCallback() {
    console.log("Simulated asynchronous operation complete!");
    document.getElementById("result").textContent = "Simulated asynchronous operation complete!";
  }
  
  // Using async/await
  async function simulateAsyncOperationAsync(callback) {
    await new Promise((resolve) => setTimeout(resolve, 3000));
    callback();
  }
  
  // Example usage of Promises
  simulateAsyncOperation(myCallback)
    .then(() => {
      console.log("Promise-based simulated asynchronous operation complete!");
    })
    .catch((error) => {
      console.error("An error occurred:", error);
    });
  
  // Example usage of async/await
  (async () => {
    await simulateAsyncOperationAsync(myCallback);
    console.log("Async/await-based simulated asynchronous operation complete!");
  })();
  