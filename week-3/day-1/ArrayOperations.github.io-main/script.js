function getUniqueNumbers(numbers) {
    const uniqueNumbers = {};
    const intersection = [];
  
    for (let i = 0; i < numbers.length; i++) {
      if (!uniqueNumbers[numbers[i]]) {
        uniqueNumbers[numbers[i]] = true;
      } else {
        intersection.push(numbers[i]);
      }
    }
  
    return [Object.keys(uniqueNumbers).map(Number), intersection];
  }
  
  function performOperations() {
    const numbersInput = document.getElementById("numbers").value;
    const arr1Input = document.getElementById("arr1").value;
    const arr2Input = document.getElementById("arr2").value;
  
    const numbers = numbersInput.split(",").map(Number);
    const arr1 = arr1Input.split(",").map(Number);
    const arr2 = arr2Input.split(",").map(Number);
  
    const [unique, common] = getUniqueNumbers(numbers);
    const [commonNumbers] = getUniqueNumbers([...arr1, ...arr2]);
  
    document.getElementById("uniqueResult").textContent = unique.join(", ");
    document.getElementById("commonResult").textContent = common.join(", ");
    document.getElementById("commonNumbersResult").textContent = commonNumbers.join(", ");
  }
  