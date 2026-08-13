fetch("https://localhost:7071/api/Users")
  .then((response) => response.json())
  .then((data) => console.log("Success:", data))
  .catch((error) => console.error("Error:", error));

fetch("https://localhost:7071/api/Users/2")
  .then((response) => response.text())
  .then((data) => console.log("Success:", data))
  .catch((error) => console.error("Error:", error));
